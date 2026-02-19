using AlberSoft.alojamientoEInventario;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CrucigramaPt1
{
    public partial class fmCrucigrama : Form
    {
        private TextBox[,] cuadricula;
        private Dictionary<(int r, int c), char> solucion = new Dictionary<(int, int), char>();
        private List<Label> etiquetasNumeros = new List<Label>();
        private Random Aleatorio = new Random();
        // Timer declarado en el Designer: use `tmrContador` inicializado en InitializeComponent
        private int tiempoRestanteSeconds = 0;
        private int tiempoInicialSeconds = 0;

        // Ajusta aquí las palabras/pistas (ampliadas a 10 horizontales y 10 verticales)
        private readonly (string palabra, string pista)[] palabrasHorizontales = new[]
        {
            ("JUGO", "Bebida de frutas que se prepara exprimiéndolas."),
            ("AGUA", "Líquido transparente que tomamos para hidratarnos."),
            ("CAMISA", "Prenda con botones y mangas que se usa en la parte de arriba."),
            ("CAMA", "Mueble con colchón donde duermes cada noche."),
            ("ZAPATO", "Prenda que cubre los pies."),
            ("ATUN", "Pescado que se vende conservado en latas."),
            ("SILLA", "Mueble con respaldo donde se sienta una persona."),
            ("LLAVE", "Objeto de metal que se usa para abrir cerraduras."),
            ("LLUVIA", "Gotas de agua que caen del cielo cuando está nublado."),
            ("PLATO", "Recipiente donde se sirve la comida.")
        };

        private readonly (string palabra, string pista)[] palabrasVerticales = new[]
        {
            ("JEFE", "Persona que está a cargo y toma decisiones en un lugar."),
            ("PANTALON", "Prenda que cubre desde la cintura hasta los pies por ambas piernas."),
            ("GALLETA", "Bocadillo dulce o salado, crujiente, que se come como snack."),
            ("ABRIGO", "Prenda larga y gruesa que se usa encima de la ropa para el frío."),
            ("ASIGNAR", "Acción de darle algo a alguien de forma oficial."),
            ("LISTA", "Conjunto de elementos escritos uno debajo del otro."),
            ("HABITAR", "Verbo relacionado con vivir en un lugar."),
            ("SARDINA", "Pescado pequeño que se vende conservado en latas."),
            ("PAN", "Alimento horneado hecho con harina y agua"),
            ("FALDA", "Prenda de ropa femenina que cubre desde la cintura hacia abajo.")
        };

        // Tamaño de la cuadrícula (CrucigramaPrincipal tiene textBox1..textBox100 -> 10x10)
        private const int TamañoCuadricula = 10;

        public fmCrucigrama()
        {
            InitializeComponent();
            FormarCuadricula();
            // Suscribir el cambio de dificultad y generar crucigrama inicial
            if (cuiCmbDificultad != null)
                cuiCmbDificultad.SelectedIndexChanged += cuiCmbDificultad_SelectedIndexChanged;

            // Pausar el contador cuando se abra el tutorial (referencias)
            if (btnReferencias != null)

                // Configurar timer de segundos (instanciado en el Designer)
                tmrContador.Interval = 1000; // 1 segundo
            tmrContador.Tick += tmrContador_Tick;

            // Establecer tiempo inicial según selección por defecto
            var selInit = cuiCmbDificultad?.SelectedItem?.ToString()?.ToUpperInvariant() ?? "";
            if (selInit.Contains("FACIL")) tiempoRestanteSeconds = 60;
            else if (selInit.Contains("INTERMEDIO")) tiempoRestanteSeconds = 80;
            else tiempoRestanteSeconds = 120;
            tiempoInicialSeconds = tiempoRestanteSeconds;
            lblTiempo.Text = tiempoRestanteSeconds.ToString();
            // Desactivar botones hasta condiciones
            btnLimpiar.Enabled = false;
            btnSolucion.Enabled = false;

            tmrContador.Start();

            CrucigramaAleatorio();
        }

        private void btnReferencias_Click(object? sender, EventArgs e)
        {
            try
            {
                // Pausar timer
                if (tmrContador != null && tmrContador.Enabled)
                    tmrContador.Stop();

                // Mostrar formulario de tutorial en modal
                using (var tut = new TutorialCrucigrama())
                {
                    tut.ShowDialog(this);
                }
            }
            finally
            {
                // Reanudar timer si queda tiempo
                if (tiempoRestanteSeconds > 0 && tmrContador != null)
                    tmrContador.Start();
            }
        }

        private void AttachCellHandlers(TextBox tb, int row, int col)
        {
            if (tb == null) return;
            // Mover con flechas: KeyDown
            tb.KeyDown -= Tb_KeyDown;
            tb.KeyDown += Tb_KeyDown;

            // Guardar posición en Tag para referencia
            tb.Tag = (row, col);
        }

        private void Tb_KeyDown(object? sender, KeyEventArgs e)
        {
            if (sender is not TextBox tb) return;
            if (!(tb.Tag is ValueTuple<int, int> pos)) return;
            int row = pos.Item1;
            int col = pos.Item2;

            // Handle arrow movement
            switch (e.KeyCode)
            {
                case Keys.Left:
                    MoveToCell(row, col - 1);
                    e.Handled = true;
                    break;
                case Keys.Right:
                    MoveToCell(row, col + 1);
                    e.Handled = true;
                    break;
                case Keys.Up:
                    MoveToCell(row - 1, col);
                    e.Handled = true;
                    break;
                case Keys.Down:
                    MoveToCell(row + 1, col);
                    e.Handled = true;
                    break;
                case Keys.Back:
                    // borrar y moverse a la izquierda
                    tb.Text = "";
                    MoveToCell(row, col - 1);
                    e.Handled = true;
                    break;
                default:
                    // Allow letter input: after typing a character, move right
                    break;
            }
        }

        private void MoveToCell(int row, int col)
        {
            if (row < 0 || row >= TamañoCuadricula || col < 0 || col >= TamañoCuadricula) return;
            var target = cuadricula[row, col];
            if (target == null) return;
            if (!target.Enabled) return;
            target.Focus();
            target.SelectAll();
        }

        private void tmrContador_Tick(object? sender, EventArgs e)
        {
            if (tiempoRestanteSeconds > 0)
            {
                tiempoRestanteSeconds--;
                lblTiempo.Text = tiempoRestanteSeconds.ToString();
                // Habilitar boton solucion cuando el tiempo restante sea <= la mitad del tiempo inicial
                if (!btnSolucion.Enabled && tiempoRestanteSeconds <= tiempoInicialSeconds / 2)
                {
                    btnSolucion.Enabled = true;
                    // Avisar al usuario cuando la solución se desbloquee
                    MessageBox.Show("Se ha habilitado la opción 'Solución'.\r\nPuedes ver la solución ahora.", "Solución disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                tmrContador.Stop();
                lblTiempo.Text = "0";
                // Tiempo agotado: mostrar solución y avisar
                MessageBox.Show("Tiempo agotado.", "Fin del tiempo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Revelar solución
                btnSolucion_Click(null, EventArgs.Empty);
            }
        }

        // Recalcula los números de pistas basándose en la posición en la cuadrícula
        // y reconstruye las listas horizontales/verticales con números coherentes (opción 2)
        private void RecalcularNumerosYListas(out List<(int numero, string palabra, string pista, int fila, int columna)> horizontales,
            out List<(int numero, string palabra, string pista, int fila, int columna)> verticales)
        {
            horizontales = new List<(int numero, string palabra, string pista, int fila, int columna)>();
            verticales = new List<(int numero, string palabra, string pista, int fila, int columna)>();

            // Limpiar etiquetas previas
            LimpiarLabels();

            int numero = 1;

            // Buscamos inicios de palabra: una celda es inicio horizontal si tiene una letra y la celda a la izquierda es vacía o fuera
            for (int r = 0; r < TamañoCuadricula; r++)
            {
                for (int c = 0; c < TamañoCuadricula; c++)
                {
                    if (!solucion.ContainsKey((r, c))) continue;

                    bool inicioHoriz = false;
                    bool inicioVert = false;

                    // inicio horizontal si o bien está en columna 0 o la celda izquierda no pertenece a solución
                    if (c == 0 || !solucion.ContainsKey((r, c - 1)))
                    {
                        // además debe haber al menos otra letra a la derecha para ser palabra de longitud >=1
                        if (c + 1 < TamañoCuadricula && solucion.ContainsKey((r, c + 1))) inicioHoriz = true;
                    }

                    // inicio vertical si o bien está en fila 0 o la celda de arriba no pertenece a solución
                    if (r == 0 || !solucion.ContainsKey((r - 1, c)))
                    {
                        if (r + 1 < TamañoCuadricula && solucion.ContainsKey((r + 1, c))) inicioVert = true;
                    }

                    if (inicioHoriz || inicioVert)
                    {
                        // Añadir etiqueta numérica visual en la celda
                        AgregarNumeroEnCeldas(r, c, numero);

                        if (inicioHoriz)
                        {
                            // reconstruir palabra horizontal completa y buscar pista en pool
                            string palabra = "";
                            int col = c;
                            while (col < TamañoCuadricula && solucion.ContainsKey((r, col)))
                            {
                                palabra += solucion[(r, col)];
                                col++;
                            }
                            // buscar pista en los pools originales
                            string pista = BuscarPistaPorPalabra(palabra, true);
                            horizontales.Add((numero, palabra, pista, r, c));
                        }

                        if (inicioVert)
                        {
                            string palabra = "";
                            int fila = r;
                            while (fila < TamañoCuadricula && solucion.ContainsKey((fila, c)))
                            {
                                palabra += solucion[(fila, c)];
                                fila++;
                            }
                            string pista = BuscarPistaPorPalabra(palabra, false);
                            verticales.Add((numero, palabra, pista, r, c));
                        }

                        numero++;
                    }
                }
            }

            // Ordenar por número por si acaso
            horizontales = horizontales.OrderBy(h => h.numero).ToList();
            verticales = verticales.OrderBy(v => v.numero).ToList();
        }

        private string BuscarPistaPorPalabra(string palabra, bool horizontal)
        {
            if (string.IsNullOrWhiteSpace(palabra)) return "";
            palabra = palabra.ToUpperInvariant();
            var pool = horizontal ? palabrasHorizontales : palabrasVerticales;
            var found = pool.FirstOrDefault(p => p.palabra.ToUpperInvariant() == palabra);
            return found.pista ?? "";
        }

        private void cuiCmbDificultad_SelectedIndexChanged(object? sender, EventArgs e)
        {
            // Al cambiar la dificultad regenerar el crucigrama con la cantidad de pistas correspondiente
            CrucigramaAleatorio();
            // Ajustar tiempo según dificultad seleccionada
            var sel = cuiCmbDificultad?.SelectedItem?.ToString()?.ToUpperInvariant() ?? "";
            if (sel.Contains("FACIL")) tiempoRestanteSeconds = 60;
            else if (sel.Contains("INTERMEDIO")) tiempoRestanteSeconds = 80;
            else tiempoRestanteSeconds = 120;

            tiempoInicialSeconds = tiempoRestanteSeconds;
            lblTiempo.Text = tiempoRestanteSeconds.ToString();
            // Reiniciar el timer al cambiar de dificultad
            tmrContador.Stop();
            tmrContador.Start();
        }

        // Construye la matriz cuadricula detectando TextBox en el formulario y ordenándolos por posición visual.
        #region Codigo para formar la cuadricula
        private void FormarCuadricula()
        {
            // Recoger todos los TextBox del form (incluye anidados)
            var allTextBoxes = GetAllControls(this).OfType<TextBox>()
                .Where(tb => tb.Name != null && tb.Name.StartsWith("textBox", StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Ordenar por Top (fila) y Left (columna)
            var sorted = allTextBoxes
                .OrderBy(tb => tb.Top)
                .ThenBy(tb => tb.Left)
                .ToList();

            // Intentar agrupar en GridSize x GridSize; si hay menos controles, se usarán los disponibles.
            cuadricula = new TextBox[TamañoCuadricula, TamañoCuadricula];

            // Si el número de textboxes es mayor que GridSize*GridSize, tomamos sólo los primeros GridSize*GridSize por posición
            int take = Math.Min(sorted.Count, TamañoCuadricula * TamañoCuadricula);
            for (int i = 0; i < take; i++)
            {
                int row = i / TamañoCuadricula;
                int col = i % TamañoCuadricula;
                cuadricula[row, col] = sorted[i];
                // Adjuntar manejadores para permitir navegación por teclado
                AttachCellHandlers(sorted[i], row, col);
            }

            // Para cualquier celda nula, crear un TextBox "fantasma" no usado para evitar NRE en otras rutinas
            for (int r = 0; r < TamañoCuadricula; r++)
                for (int c = 0; c < TamañoCuadricula; c++)
                    if (cuadricula[r, c] == null)
                        cuadricula[r, c] = null; // mantenemos null para poder distinguir celdas inexistentes
        }
        #endregion

        // Elige subconjuntos de palabras según la dificultad seleccionada
        private void ObtenerListasSegunDificultad(out (string palabra, string pista)[] horizSeleccionadas,
            out (string palabra, string pista)[] vertSeleccionadas,
            out int targetHorizontales, out int targetVerticales)
        {
            // Valores por defecto
            targetHorizontales = Math.Min(6, palabrasHorizontales.Length);
            targetVerticales = Math.Min(6, palabrasVerticales.Length);

            try
            {
                var sel = cuiCmbDificultad?.SelectedItem?.ToString()?.ToUpperInvariant() ?? "";
                if (sel.Contains("FACIL"))
                {
                    // Nivel fácil: 6 pistas en total -> 3 horizontales + 3 verticales
                    targetHorizontales = Math.Min(3, palabrasHorizontales.Length);
                    targetVerticales = Math.Min(3, palabrasVerticales.Length);
                }
                else if (sel.Contains("INTERMEDIO"))
                {
                    // Intermedio: 8 pistas en total -> 4 horizontales + 4 verticales
                    targetHorizontales = Math.Min(4, palabrasHorizontales.Length);
                    targetVerticales = Math.Min(4, palabrasVerticales.Length);
                }
                else
                {
                    // Difícil: 12 pistas en total -> 6 horizontales + 6 verticales
                    targetHorizontales = Math.Min(6, palabrasHorizontales.Length);
                    targetVerticales = Math.Min(6, palabrasVerticales.Length);
                }
            }
            catch
            {
                targetHorizontales = Math.Min(6, palabrasHorizontales.Length);
                targetVerticales = Math.Min(6, palabrasVerticales.Length);
            }

            // Devolver pool aleatorio (la selección final se hace en la generación)
            horizSeleccionadas = palabrasHorizontales.OrderBy(x => Aleatorio.Next()).ToArray();
            vertSeleccionadas = palabrasVerticales.OrderBy(x => Aleatorio.Next()).ToArray();
        }

        // Recursivo para obtener todos los controles hijos
        #region Codigo para obtener todos los controles hijos
        private IEnumerable<Control> GetAllControls(Control parent) //Declara un método que recibe un control “padre”
        {
            foreach (Control c in parent.Controls) //Recorre todos los controles que están directamente dentro del control padre
            {
                yield return c;  //Devuelve ese control uno por uno
                foreach (var child in GetAllControls(c)) //Llama al mismo método otra vez para buscar los controles que están dentro de ese control
                    yield return child;
            }
        }
        #endregion
        // Genera una nueva disposición aleatoria cada ejecución
        #region Codigo para generar crucigrama aleatorio
        private void CrucigramaAleatorio()
        {
            solucion.Clear();
            LimpiarLabels();

            // Reset botones: limpiar sólo habilitado tras verificación completa; solución habilitada según temporizador
            btnLimpiar.Enabled = false;
            btnSolucion.Enabled = false;

            // Obtener pool y targets según dificultad
            ObtenerListasSegunDificultad(out var horizPool, out var vertPool, out int targetHorizontales, out int targetVerticales);

            // Preparar estructuras que contendrán las pistas colocadas
            var ColocarHorizontal = new List<(int numero, string palabra, string pista, int fila, int columna)>();
            var ColocarVertical = new List<(int numero, string palabra, string pista, int fila, int columna)>();
            int PistaNumero = 1;

            // Intentar varias veces para asegurar que se coloquen exactamente los targets pedidos
            const int maxAttempts = 30;
            bool success = false;
            for (int attempt = 0; attempt < maxAttempts && !success; attempt++)
            {
                // limpiar soluciones y etiquetas antes de cada intento
                solucion.Clear();
                LimpiarLabels();

                var ColocarHorizontalTry = new List<(int numero, string palabra, string pista, int fila, int columna)>();
                var ColocarVerticalTry = new List<(int numero, string palabra, string pista, int fila, int columna)>();
                int PistaNumeroTry = 1;

                // Mezclar los pools para aleatoriedad
                var shuffledHoriz = horizPool.OrderBy(x => Aleatorio.Next()).ToList();
                var shuffledVert = vertPool.OrderBy(x => Aleatorio.Next()).ToList();

                // Colocar horizontales hasta alcanzar el target exacto (o agotar el pool)
                int placedHoriz = 0;
                foreach (var hw in shuffledHoriz)
                {
                    if (placedHoriz >= targetHorizontales) break;

                    if (ColocarPalabra(hw.palabra, horizontal: true, out int fila, out int columna)
                        || ProbarPalabraDeterminar(hw.palabra, horizontal: true, out fila, out columna))
                    {
                        LugarHorizontal(fila, columna, hw.palabra);
                        if (!NumberLabelExistsAt(fila, columna))
                        {
                            AgregarNumeroEnCeldas(fila, columna, PistaNumeroTry);
                            ColocarHorizontalTry.Add((PistaNumeroTry, hw.palabra, hw.pista, fila, columna));
                            PistaNumeroTry++;
                        }
                        else
                        {
                            ColocarHorizontalTry.Add((ObtenerNumero(fila, columna), hw.palabra, hw.pista, fila, columna));
                        }
                        placedHoriz++;
                    }
                }

                // Colocar verticales hasta alcanzar el target exacto (o agotar el pool)
                int placedVert = 0;
                foreach (var vw in shuffledVert)
                {
                    if (placedVert >= targetVerticales) break;

                    if (ColocarPalabra(vw.palabra, horizontal: false, out int fila, out int columna)
                        || ProbarPalabraDeterminar(vw.palabra, horizontal: false, out fila, out columna))
                    {
                        lugarVertical(fila, columna, vw.palabra);
                        if (!NumberLabelExistsAt(fila, columna))
                        {
                            AgregarNumeroEnCeldas(fila, columna, PistaNumeroTry);
                            ColocarVerticalTry.Add((PistaNumeroTry, vw.palabra, vw.pista, fila, columna));
                            PistaNumeroTry++;
                        }
                        else
                        {
                            ColocarVerticalTry.Add((ObtenerNumero(fila, columna), vw.palabra, vw.pista, fila, columna));
                        }
                        placedVert++;
                    }
                }

                // Guardar último intento (para usar si no alcanzamos éxito tras todos los intentos)
                var lastHorizTry = ColocarHorizontalTry;
                var lastVertTry = ColocarVerticalTry;

                // Verificar si se alcanzaron los objetivos
                if (placedHoriz >= targetHorizontales && placedVert >= targetVerticales)
                {
                    // aceptar intento
                    ColocarHorizontal = ColocarHorizontalTry;
                    ColocarVertical = ColocarVerticalTry;
                    PistaNumero = PistaNumeroTry;
                    success = true;
                }
                else
                {
                    // limpiar y volver a intentar
                    solucion.Clear();
                    LimpiarLabels();
                    // Si es el último intento, usar lo que quedó en este intento parcial
                    if (attempt == maxAttempts - 1)
                    {
                        ColocarHorizontal = lastHorizTry;
                        ColocarVertical = lastVertTry;
                        PistaNumero = PistaNumeroTry;
                    }
                }
            }

            // Si no tuvo éxito tras maxAttempts, usar lo que se haya logrado en el último intento parcial
            if (!success)
            {
                // Recalcular números y listas a partir de la cuadrícula: opción 2
                RecalcularNumerosYListas(out ColocarHorizontal, out ColocarVertical);
            }

            // Inicializar celdas: habilitar sólo las usadas, bloquear las demás en negro
            #region Codigo para controlas las celdas
            for (int r = 0; r < TamañoCuadricula; r++)
            {
                for (int c = 0; c < TamañoCuadricula; c++)
                {
                    var tb = cuadricula[r, c];
                    if (tb == null) continue;

                    if (solucion.ContainsKey((r, c)))
                    {
                        tb.Enabled = true;
                        tb.Text = "";
                        tb.BackColor = Color.White;
                        tb.ForeColor = Color.Black;
                        tb.CharacterCasing = CharacterCasing.Upper;
                        tb.TextAlign = HorizontalAlignment.Center;
                    }
                    else
                    {
                        tb.Enabled = false;
                        tb.Text = "";
                        tb.BackColor = Color.FromArgb(133, 193, 220);
                        tb.ForeColor = Color.White;
                    }
                }
            }
            #endregion

            // Actualizar pistas con números asignados
            lblPistasH.Text = "HORIZONTALES:\r\n\r\n" +
                string.Join("\r\n", ColocarHorizontal.Select(ph => $"{ph.numero}. {ph.pista}"));

            lblPistasV.Text = "VERTICALES:\r\n\r\n" +
                string.Join("\r\n", ColocarVertical.Select(pv => $"{pv.numero}. {pv.pista}"));

            lblResultado.Text = "Resultado: -";

            // Desactivar o activar btnLimpiar según si todas las palabras ya están correctas
            // btnLimpiar debe permanecer inactivo hasta que todas las palabras hayan sido verificadas correctamente
            // Se activará cuando el usuario verifique y todas sean correctas (vease btnVerificar)
        }
        #endregion
        private bool ColocarPalabra(string palabra, bool horizontal, out int fueraFila, out int fueraColumna)
        {
            int intentos = 500;
            int len = palabra.Length;
            for (int a = 0; a < intentos; a++)
            {
                if (horizontal)
                {
                    int fila = Aleatorio.Next(0, TamañoCuadricula);
                    int columna = Aleatorio.Next(0, TamañoCuadricula - len + 1);
                    if (Colocar(palabra, fila, columna, true))
                    {
                        fueraFila = fila;
                        fueraColumna = columna;
                        return true;
                    }
                }
                else
                {
                    int fila = Aleatorio.Next(0, TamañoCuadricula - len + 1);
                    int columna = Aleatorio.Next(0, TamañoCuadricula);
                    if (Colocar(palabra, fila, columna, false))
                    {
                        fueraFila = fila;
                        fueraColumna = columna;
                        return true;
                    }
                }
            }

            fueraFila = -1;
            fueraColumna = -1;
            return false;
        }

        private bool ProbarPalabraDeterminar(string palabra, bool horizontal, out int fueraFila, out int fueraColumna)
        {
            int len = palabra.Length;
            if (horizontal)
            {
                for (int r = 0; r < TamañoCuadricula; r++)
                    for (int c = 0; c <= TamañoCuadricula - len; c++)
                        if (Colocar(palabra, r, c, true))
                        {
                            fueraFila = r; fueraColumna = c; return true;
                        }
            }
            else
            {
                for (int c = 0; c < TamañoCuadricula; c++)
                    for (int r = 0; r <= TamañoCuadricula - len; r++)
                        if (Colocar(palabra, r, c, false))
                        {
                            fueraFila = r; fueraColumna = c; return true;
                        }
            }

            fueraFila = -1; fueraColumna = -1; return false;
        }

        private bool Colocar(string palabra, int fila, int columna, bool horizontal)
        {
            for (int i = 0; i < palabra.Length; i++)
            {
                int r = horizontal ? fila : fila + i;
                int c = horizontal ? columna + i : columna;
                if (r < 0 || r >= TamañoCuadricula || c < 0 || c >= TamañoCuadricula) return false;
                if (cuadricula[r, c] == null) return false; // celda inexistente en el diseñador
                if (solucion.TryGetValue((r, c), out char existing))
                {
                    if (existing != char.ToUpperInvariant(palabra[i])) return false;
                }
            }
            return true;
        }

        private void LugarHorizontal(int fila, int columnaInicio, string palabra)
        {
            for (int i = 0; i < palabra.Length; i++)
            {
                int c = columnaInicio + i;
                solucion[(fila, c)] = char.ToUpperInvariant(palabra[i]);
            }
        }

        private void lugarVertical(int filaInicio, int columna, string palabra)
        {
            for (int i = 0; i < palabra.Length; i++)
            {
                int r = filaInicio + i;
                solucion[(r, columna)] = char.ToUpperInvariant(palabra[i]);
            }
        }

        // Añade etiqueta numérica en la esquina superior izquierda del TextBox
        private void AgregarNumeroEnCeldas(int fila, int columna, int numero)
        {
            var tb = cuadricula[fila, columna];
            if (tb == null) return;

            var lbl = new Label
            {
                AutoSize = true,
                Text = numero.ToString(),
                Font = new Font("Arial", 8, FontStyle.Bold),
                BackColor = Color.Yellow,
                ForeColor = Color.Black,
                Tag = (fila, columna, numero)
            };

            Control parent = tb.Parent ?? this;
            parent.Controls.Add(lbl);

            // Posición relativa al contenedor del TextBox
            lbl.Location = new Point(tb.Left + 2, tb.Top + 2);
            lbl.BringToFront();

            etiquetasNumeros.Add(lbl);
        }

        private bool NumberLabelExistsAt(int fila, int columna)
        {
            return etiquetasNumeros.Any(l => l.Tag is ValueTuple<int, int, int> t && t.Item1 == fila && t.Item2 == columna);
        }

        private int ObtenerNumero(int fila, int columna)
        {
            var lbl = etiquetasNumeros.FirstOrDefault(l => l.Tag is ValueTuple<int, int, int> t && t.Item1 == fila && t.Item2 == columna);
            return lbl != null && lbl.Tag is ValueTuple<int, int, int> v ? v.Item3 : -1;
        }

        private void LimpiarLabels()
        {
            foreach (var lbl in etiquetasNumeros.ToList())
            {
                if (lbl.Parent != null && lbl.Parent.Controls.Contains(lbl)) lbl.Parent.Controls.Remove(lbl);
                lbl.Dispose();
            }
            etiquetasNumeros.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            for (int r = 0; r < TamañoCuadricula; r++)
                for (int c = 0; c < TamañoCuadricula; c++)
                {
                    var tb = cuadricula[r, c];
                    if (tb == null) continue;
                    if (tb.Enabled)
                    {
                        tb.Text = "";
                        tb.BackColor = Color.White;
                        tb.ForeColor = Color.Black;
                    }
                }
            CrucigramaAleatorio();
            lblResultado.Text = "Resultado: -";
            // Reiniciar el temporizador al limpiar
            tiempoRestanteSeconds = tiempoInicialSeconds;
            lblTiempo.Text = tiempoRestanteSeconds.ToString();
            tmrContador.Stop();
            tmrContador.Start();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int total = solucion.Count;
            int correct = 0;

            foreach (var kv in solucion)
            {
                var (r, c) = kv.Key;
                char expected = kv.Value;
                var tb = cuadricula[r, c];
                if (tb == null) continue;

                string text = (tb.Text ?? "").Trim().ToUpperInvariant();
                if (text.Length == 1 && text[0] == expected)
                {
                    tb.BackColor = Color.LightGreen;
                    correct++;
                }
                else
                {
                    tb.BackColor = Color.LightSalmon;
                }
            }

            double pct = total == 0 ? 0 : Math.Round(100.0 * correct / total, 1);
            lblResultado.Text = $"Resultado: {correct}/{total} ({pct}%)";

            if (correct == total && total > 0)
            {
                // Detener el contador cuando todas las palabras son correctas
                tmrContador.Stop();
                MessageBox.Show("¡Bien hecho! Todas las palabras están correctas.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Habilitar el botón Limpiar sólo cuando todas las palabras fueron verificadas correctamente
                btnLimpiar.Enabled = true;
            }

            // si no todas correctas, enfocar la primera incorrecta
            if (correct != total && total > 0)
            {
                foreach (var kv in solucion)
                {
                    var (r, c) = kv.Key;
                    var tb = cuadricula[r, c];
                    if (tb == null) continue;
                    string text = (tb.Text ?? "").Trim().ToUpperInvariant();
                    if (!(text.Length == 1 && text[0] == kv.Value))
                    {
                        tb.Focus();
                        tb.SelectAll();
                        break;
                    }
                }
            }
        }

        private void btnSolucion_Click(object sender, EventArgs e)
        {
            foreach (var kv in solucion)
            {
                var (r, c) = kv.Key;
                var tb = cuadricula[r, c];
                if (tb == null) continue;
                tb.Text = kv.Value.ToString();
                tb.BackColor = Color.Yellow;
                tb.ForeColor = Color.Black;
            }

            lblResultado.Text = $"Resultado: {solucion.Count}/{solucion.Count} (100%)";
        }
    }
}