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

        // Ajusta aquí las palabras/pistas
        private readonly (string palabra, string pista)[] palabrasHorizontales = new[]
        {
            ("JUGO", "Bebida que se sirve con la merienda."),
            ("AGUA", "Bebida esencial para todos los huéspedes."),
            ("CAMISA", "Prenda que cubre la parte superior del cuerpo."),
            ("CAMA", "Lugar donde duerme una persona."),
            ("ZAPATO", "Prenda que cubre los pies."),
            ("ATUN", "Alimento que se guarda en latas.")
        };

        private readonly (string palabra, string pista)[] palabrasVerticales = new[]
        {
            ("JEFE", "Persona que cuida el orden en el albergue."),
            ("CUPO", "Número que indica cuántas camas hay libres."),
            ("GALLETA", "Alimento que se sirve con café."),
            ("ABRIGO", "Prenda que se usa en el frío."),
            ("ASIGNAR", "Acción de dar una cama a alguien."),
            ("LISTA", "Registro donde se anotan las prendas disponibles.")
        };

        // Tamaño de la cuadrícula (CrucigramaPrincipal tiene textBox1..textBox100 -> 10x10)
        private const int TamañoCuadricula = 10;

        public fmCrucigrama()
        {
            InitializeComponent();
            FormarCuadricula();
            CrucigramaAleatorio();
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
            }

            // Para cualquier celda nula, crear un TextBox "fantasma" no usado para evitar NRE en otras rutinas
            for (int r = 0; r < TamañoCuadricula; r++)
                for (int c = 0; c < TamañoCuadricula; c++)
                    if (cuadricula[r, c] == null)
                        cuadricula[r, c] = null; // mantenemos null para poder distinguir celdas inexistentes
        }
        #endregion

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

            var ColocarHorizontal = new List<(int numero, string palabra, string pista, int fila, int columna)>();
            var ColocarVertical = new List<(int numero, string palabra, string pista, int fila, int columna)>();
            int PistaNumero = 1;

            // Mezclar palabras para que el orden de colocación sea aleatorio cada vez
            var horizontalesMezcladas = palabrasHorizontales.OrderBy(x => Aleatorio.Next()).ToList();
            var verticalesMezcladas = palabrasVerticales.OrderBy(x => Aleatorio.Next()).ToList();

            // Colocar horizontales
            #region Código previo para colocar horizontales
            foreach (var hw in horizontalesMezcladas)
            {
                if (ColocarPalabra(hw.palabra, horizontal: true, out int fila, out int columna)
                    || ProbarPalabraDeterminar(hw.palabra, horizontal: true, out fila, out columna))
                {
                    LugarHorizontal(fila, columna, hw.palabra);
                    if (!NumberLabelExistsAt(fila, columna))
                    {
                        AgregarNumeroEnCeldas(fila, columna, PistaNumero);
                        ColocarHorizontal.Add((PistaNumero, hw.palabra, hw.pista, fila, columna));
                        PistaNumero++;
                    }
                    else
                    {
                        ColocarHorizontal.Add((ObtenerNumero(fila, columna), hw.palabra, hw.pista, fila, columna));
                    }
                }
            }
            #endregion

            // Colocar verticales
            #region Código previo para colocar verticales
            foreach (var vw in verticalesMezcladas)
            {
                if (ColocarPalabra(vw.palabra, horizontal: false, out int fila, out int columna)
                    || ProbarPalabraDeterminar(vw.palabra, horizontal: false, out fila, out columna))
                {
                    lugarVertical(fila, columna, vw.palabra);
                    if (!NumberLabelExistsAt(fila, columna))
                    {
                        AgregarNumeroEnCeldas(fila, columna, PistaNumero);
                        ColocarVertical.Add((PistaNumero, vw.palabra, vw.pista, fila, columna));
                        PistaNumero++;
                    }
                    else
                    {
                        ColocarVertical.Add((ObtenerNumero(fila, columna), vw.palabra, vw.pista, fila, columna));
                    }
                }
            }
            #endregion

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

        // Añade etiqueta numérica en la esquina superior izquierda del TextBox (misma parent)
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
                MessageBox.Show("¡Bien hecho! Todas las palabras están correctas.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSolucion_Click(object sender, EventArgs e)
        {
            foreach (var kv in solucion)
            {
                var (r, c) = kv.Key;
                var tb = cuadricula[r, c];
                if (tb == null) continue;
                tb.Text = kv.Value.ToString();
                tb.BackColor = Color.LightGreen;
                tb.ForeColor = Color.Black;
            }

            lblResultado.Text = $"Resultado: {solucion.Count}/{solucion.Count} (100%)";
        }
    }
}