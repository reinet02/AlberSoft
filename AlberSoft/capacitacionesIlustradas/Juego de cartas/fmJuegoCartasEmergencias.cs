using AlberSoft.capacitacionesIlustradas.Juego_de_cartas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AlberSoft.capacitacionesIlustradas
{
    public partial class fmJuegoCartasEmergencias : Form
    {
        // Referencia al formulario anterior (menu) para poder reinsertarlo en el panel al volver
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Control? FormularioAnterior { get; set; }
        // Límite de cartas en la mano
        private const int MaxCartasMano = 6;
        // Lista con las cartas visibles en la mano
        private List<ControlCarta> mano = new List<ControlCarta>();
        // Guardar posición Y original para animaciones de hover
        private Dictionary<ControlCarta, int> originalY = new Dictionary<ControlCarta, int>();
        // Carta actualmente bajo el cursor
        private ControlCarta cartaHoverActual = null;
        private Mazo? mazo;
        // Mazo que contiene las cartas enviadas al cementerio (no retornables hasta GAME OVER)
        private Mazo cementerioMazo = new Mazo();
        private List<Carta> cartasEnMano = new();

        // Drag state
        private ControlCarta? dragSource = null;
        private Point dragStartPoint;
        // Timer para el conteo de tiempo por nivel
        private System.Windows.Forms.Timer nivelTimer;
        // segundos restantes del temporizador
        private int segundosRestantes;

        // Duración del nivel en segundos (se establecerá desde el formulario del menú antes de abrir este)
        private int duracionNivelSegundos = 120;
        // Duración originalmente configurada por el menú (se mantiene como referencia al reiniciar)
        private int duracionNivelInicial = 120;

        // Controla si las cartas puestas en el tablero pueden regresar a la mano (configurable desde el menú)
        private bool permitirRegresoEnTablero = true;

        // Métodos para configurar parámetros desde el formulario de menú
        public void ConfigurarDuracionNivel(int segundos)
        {
            duracionNivelSegundos = Math.Max(1, segundos);
            duracionNivelInicial = duracionNivelSegundos;
        }

        // Actualiza `labelEscenario` con descripción legible según el escenario actual
        private void ActualizarLabelEscenario()
        {
            try
            {
                if (labelEscenario == null) return;

                // Determinar escenario por su nombre (índice actual). Evitamos comparar
                // referencias de Image porque recursos cargados pueden no ser la misma instancia.
                var nombre = ObtenerNombreEscenarioActual();
                if (string.Equals(nombre, "incendio", StringComparison.OrdinalIgnoreCase))
                {
                    labelEscenario.Content = "Escenario: Incendio en el albergue";
                    labelEscenario.Visible = true;
                    // asegurarnos de usar la imagen correspondiente
                    try { pbEscenarios.Image = Properties.Resources.incendio; } catch { }
                    return;
                }
                if (string.Equals(nombre, "inundacion", StringComparison.OrdinalIgnoreCase))
                {
                    labelEscenario.Content = "Escenario: Inundación";
                    labelEscenario.Visible = true;
                    try { pbEscenarios.Image = Properties.Resources.inundacion; } catch { }
                    return;
                }
                if (string.Equals(nombre, "sismo", StringComparison.OrdinalIgnoreCase))
                {
                    labelEscenario.Content = "Escenario: Sismo";
                    labelEscenario.Visible = true;
                    try { pbEscenarios.Image = Properties.Resources.sismo; } catch { }
                    return;
                }

                labelEscenario.Content = "";
                labelEscenario.Visible = false;
            }
            catch { }
        }

        public void ConfigurarPermitirRegreso(bool permitir)
        {
            permitirRegresoEnTablero = permitir;
        }

        // Indica si la partida/turno está en marcha. Mientras sea false no se permiten
        // operaciones de arrastre hacia el tablero.
        private bool juegoIniciado = false;

        // Puntos de vida del jugador (se muestran en lbPuntosVidaConteo / lbPuntosVidaTitulo)
        private int puntosVida = 100;
        // Evita abrir múltiples formularios de corrección simultáneamente
        private bool mostrandoCorreccion = false;

        // Temporizador para ocultar el mensaje de vida perdida temporal mostrado en la UI
        private System.Windows.Forms.Timer vidaPerdidaTimer = null;

        // Obtiene los puntos de vida actuales
        public int ObtenerPuntosVida() => puntosVida;

        // Resta puntos de vida y actualiza la interfaz. El valor se clampa a >= 0.
        public void RestarPuntosVida(int cantidad)
        {
            try
            {
                puntosVida = Math.Max(0, puntosVida - Math.Max(0, cantidad));
                // actualizar display (si existen controles)
                try { lbPuntosVidaConteo.Content = puntosVida.ToString(); } catch { }
                try { lbPuntosVidaTitulo.Content = $"Puntos de vida: "; } catch { }

                // Si la vida llegó a cero, programar la apertura del formulario de corrección indicando derrota por vida
                if (puntosVida == 0)
                {
                    try
                    {
                        // marcar juego como no iniciado para bloquear interacciones
                        juegoIniciado = false;
                        try { tablaTableroCartas.AllowDrop = false; } catch { }
                        try { pbMazo.Enabled = false; } catch { }

                        // detener temporizador
                        try { PararTemporizador(); } catch { }

                        // construir lista de resultados a partir del tablero actual
                        var lista = new List<(string titulo, bool correcto)>();
                        try
                        {
                            var controles = tablaTableroCartas.Controls.Cast<Control>().OfType<ControlCarta>().ToList();
                            foreach (var cc in controles)
                            {
                                Carta modelo = cc.Modelo ?? (cc.Titulo != null ? new Carta(-1, cc.Titulo, cc.Imagen) : null);
                                bool correcto = false;
                                if (modelo != null) correcto = EsCartaCorrectaParaEscenario(modelo);
                                var titulo = modelo?.Nombre ?? cc.Titulo ?? cc.Name ?? "(sin nombre)";
                                lista.Add((titulo, correcto));
                            }
                        }
                        catch { }

                        // mostrar formulario de corrección en modo "vida agotada" de forma segura
                        MostrarCorreccionPorVidaAgotada(lista);
                    }
                    catch { }
                }
            }
            catch { }
        }

        // Overload que acepta una razón y muestra durante 5 segundos un mensaje en la UI del juego
        // El mensaje se muestra en el label `labelPuntosPerdidos` (visible durante la partida)
        public void RestarPuntosVida(int cantidad, string razon)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    this.BeginInvoke(new Action(() => RestarPuntosVida(cantidad, razon)));
                    return;
                }

                // Aplicar la resta y actualizar contadores
                try { RestarPuntosVida(cantidad); } catch { }

                // Mostrar inmediatamente en el label de la UI sólo la cantidad de puntos perdidos
                // (la razón/nombre de la carta se muestra en `labelPuntosPerdidosCarta`)
                try
                {
                    if (labelPuntosPerdidos != null)
                    {
                        labelPuntosPerdidos.Content = $"-{cantidad} pts.";
                        labelPuntosPerdidos.ForeColor = Color.FromArgb(180, 0, 0);
                        labelPuntosPerdidos.Visible = true;
                    }
                }
                catch { }

                // Reiniciar timer si ya existía
                try
                {
                    if (vidaPerdidaTimer != null)
                    {
                        vidaPerdidaTimer.Stop();
                        vidaPerdidaTimer.Tick -= VidaPerdidaTimer_Tick;
                        try { vidaPerdidaTimer.Dispose(); } catch { }
                        vidaPerdidaTimer = null;
                    }

                    vidaPerdidaTimer = new System.Windows.Forms.Timer();
                    vidaPerdidaTimer.Interval = 5000; // 5 segundos
                    vidaPerdidaTimer.Tick += VidaPerdidaTimer_Tick;
                    vidaPerdidaTimer.Start();
                }
                catch { }
            }
            catch { }
        }

        private void VidaPerdidaTimer_Tick(object? sender, EventArgs e)
        {
            try
            {
                if (vidaPerdidaTimer != null)
                {
                    vidaPerdidaTimer.Stop();
                    vidaPerdidaTimer.Tick -= VidaPerdidaTimer_Tick;
                    try { vidaPerdidaTimer.Dispose(); } catch { }
                    vidaPerdidaTimer = null;
                }

                // Ocultar el label de puntos perdidos usado durante la partida
                try
                {
                    if (labelPuntosPerdidos != null)
                    {
                        labelPuntosPerdidos.Content = "";
                        labelPuntosPerdidos.Visible = false;
                    }
                    if (labelPuntosPerdidosCarta != null)
                    {
                        labelPuntosPerdidosCarta.Content = "";
                        labelPuntosPerdidosCarta.Visible = false;
                    }
                }
                catch { }
            }
            catch { }
        }

        // Reinicia los puntos de vida al valor inicial (100)
        public void ResetearPuntosVida()
        {
            puntosVida = 100;
            try { lbPuntosVidaConteo.Content = puntosVida.ToString(); } catch { }
            try { lbPuntosVidaTitulo.Content = "Puntos de vida: "; } catch { }
        }

        // Guardar manejadores MouseUp adjuntados al colocar en el tablero, para poder eliminarlos
        private Dictionary<Control, MouseEventHandler> tableroMouseUpHandlers = new Dictionary<Control, MouseEventHandler>();

        public fmJuegoCartasEmergencias()
        {
            InitializeComponent();
            InicializarMano();
            // asegurar que el evento Load esté conectado (Designer puede no haberlo generado)
            this.Load += fmJuegoCartasEmergencias_Load;
            // Recalcular posiciones cuando el panel cambia de tamaño
            panelMano.Resize += (s, e) => DistribuirMano();

            // Inicialmente no permitir drop en el tablero hasta que el usuario pulse Jugar
            // (Se habilitará en BtnJugar_Click)
            tablaTableroCartas.AllowDrop = false;
            tablaTableroCartas.DragEnter += TableroCartas_DragEnter;
            tablaTableroCartas.DragOver += TableroCartas_DragOver;
            tablaTableroCartas.DragDrop += TableroCartas_DragDrop;

            // Deshabilitar interacción con el mazo hasta pulsar Jugar
            // permitir que el usuario pueda clicar el mazo para robar una carta
            pbMazo.Enabled = true;

            // inicializar temporizador de nivel
            nivelTimer = new System.Windows.Forms.Timer();
            nivelTimer.Interval = 1000; // 1 segundo
            nivelTimer.Tick += NivelTimer_Tick;

            // Preparar el cementerio (permitir drop sobre pbCementerio)
            try
            {
                pbCementerio.AllowDrop = true;
                pbCementerio.DragEnter += (s, ev) =>
                {
                    if (ev.Data.GetData(typeof(ControlCarta)) is ControlCarta) ev.Effect = DragDropEffects.Move;
                    else ev.Effect = DragDropEffects.None;
                };
                pbCementerio.DragDrop += PbCementerio_DragDrop;
            }
            catch { }

            // Suscribir eventos de UI: validar y volver al menú
            if (btnValidar != null) btnValidar.Click += BtnValidar_Click;
            if (btnVolverMenuInicio != null) btnVolverMenuInicio.Click += BtnVolverMenuInicio_Click;
            if (btnInstrucciones != null) btnInstrucciones.Click += BtnInstrucciones_Click;

            // Ahora la carta se eleva solo cuando el usuario hace click en ella.
            // Se elimina la elevación por hover para evitar comportamientos inesperados.

            // suscribir el evento Click del mazo para añadir una carta a la mano
            pbMazo.Click += pbMazo_Click;

            // No iniciar el temporizador aquí: se iniciará explícitamente cuando el menú invoque `IniciarJuego()`
            // Mostrar la duración del nivel en segundos en lbTiempo desde el inicio (valor por defecto)
            lbTiempo.Content = $"Tiempo: {duracionNivelSegundos} segundos";

            // Detener y resetear el temporizador automáticamente cuando el formulario deje de ser visible
            // o sea removido de su contenedor (navegación hacia otro formulario). No usamos Deactivate
            // para evitar interferir con diálogos modales que desactivan la ventana sin intención de resetear.
            this.VisibleChanged += (s, e) => { if (!this.Visible) ResetTimerAndState(); };
            this.ParentChanged += (s, e) => { if (this.Parent == null) ResetTimerAndState(); };
        }

        // Inicia el juego: activa temporizador, habilita interacción y muestra tiempo en segundos.
        public void IniciarJuego()
        {
            // usar la duración original configurada por el menú para iniciar
            segundosRestantes = duracionNivelInicial;
            lbTiempo.Content = $@"Tiempo: {segundosRestantes} segundos";
            nivelTimer.Start();
            juegoIniciado = true;
            tablaTableroCartas.AllowDrop = true;
            pbMazo.Enabled = true;
        }

        // Registrar manejadores de click en todos los controles hijos para reenviar
        // el evento como si hubiese un click en la carta principal.
        // Además reenviamos los eventos de ratón para permitir iniciar arrastre si el usuario
        // pulsa/arrastra sobre un control hijo (imagen, etiqueta, textbox).
        private void AttachClickHandlers(Control root, ControlCarta owner)
        {
            foreach (Control child in root.Controls)
            {
                // reenviar Click
                child.Click += (s, e) => Carta_Click(owner, e);

                // reenviar eventos de ratón para que el drag se inicie aunque el usuario empiece
                // el gesto sobre un control hijo (PictureBox, Label, TextBox...)
                child.MouseDown += (s, me) => ControlCarta_MouseDown(owner, (MouseEventArgs)me);
                child.MouseMove += (s, me) => ControlCarta_MouseMove(owner, (MouseEventArgs)me);
                child.MouseUp += (s, me) => ControlCarta_MouseUp(owner, (MouseEventArgs)me);

                if (child.HasChildren)
                    AttachClickHandlers(child, owner);
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InicializarMano()
        {
            // vaciar mano previa si existiera
            mano.Clear();
            originalY.Clear();
            cartasEnMano.Clear();

            // No eliminar los controles estáticos añadidos por el diseñador (p.ej. tablaContieneTableroCartas)
            // que contienen `tablaTableroCartas`. Sólo eliminar controles dinámicos `ControlCarta` que
            // puedan haber quedado de partidas anteriores.
            try
            {
                var dinámicos = panelMano.Controls.Cast<Control>().Where(c => c is ControlCarta).ToList();
                foreach (var d in dinámicos)
                {
                    try { panelMano.Controls.Remove(d); } catch { }
                }
            }
            catch { }

            // iniciar con mano vacía para que cada click en el mazo añada una carta
            const int cartas = 0;
            // Tamaño aproximado de las cartas; puedes ajustar
            int cardWidth = 140;
            int cardHeight = 200;

            for (int i = 0; i < cartas; i++)
            {
                var c = new ControlCarta
                {
                    Size = new Size(cardWidth, cardHeight),
                    BackColor = Color.Transparent,
                    Titulo = $"Carta {i + 1}",
                    Descripcion = "",
                    Imagen = null // asigna la imagen real aquí si la tienes
                };

                // Sólo manejador de Click; la detección de hover es global en panelMano
                // Registrar click en el control y en todos sus hijos para asegurarnos que
                // pulsar sobre la imagen, etiqueta o textbox también active la carta.
                c.Click += Carta_Click;
                AttachClickHandlers(c, c);

                // añadir al panel y a la lista
                panelMano.Controls.Add(c);
                mano.Add(c);
            }

            // distribuir en el panel
            DistribuirMano();
        }

        private void DistribuirMano()
        {
            if (panelMano == null) return;
            if (mano.Count == 0) return;

            // Restaurar cualquier carta elevada antes de recalcular posiciones
            if (cartaHoverActual != null && originalY.ContainsKey(cartaHoverActual))
            {
                cartaHoverActual.Top = originalY[cartaHoverActual];
                cartaHoverActual = null;
            }

            int cardWidth = mano[0].Width;
            int cardHeight = mano[0].Height;
            int overlap = 40; // solapamiento horizontal en píxeles (ajusta según estética)
            int cartas = mano.Count;

            int totalWidth = cardWidth + (cartas - 1) * (cardWidth - overlap);
            int startX = Math.Max(0, (panelMano.Width - totalWidth) / 2);
            int baseY = Math.Max(0, panelMano.Height - cardHeight - 10); // margen inferior

            // Desactivar layout mientras posicionamos para evitar múltiples redraws
            panelMano.SuspendLayout();
            for (int i = 0; i < cartas; i++)
            {
                var c = mano[i];
                int x = startX + i * (cardWidth - overlap);
                c.Location = new Point(x, baseY);
                // registrar posición original
                originalY[c] = c.Top;
            }

            // Ajustar orden Z para que las cartas laterales se solapen correctamente.
            // Queremos que las cartas con índice mayor queden por encima de las anteriores,
            // excepto la carta central que destacamos por encima.
            for (int i = 0; i < cartas; i++)
            {
                var ctrl = mano[i];
                if (panelMano.Controls.Contains(ctrl))
                {
                    // poner el índice de z-order: el último elemento (i==cartas-1) debe estar al frente
                    panelMano.Controls.SetChildIndex(ctrl, cartas - 1 - i);
                }
            }

            // Dar prioridad visual a la carta central
            int centro = cartas / 2;
            if (centro >= 0 && centro < cartas && panelMano.Controls.Contains(mano[centro]))
            {
                panelMano.Controls.SetChildIndex(mano[centro], 0);
            }
            panelMano.ResumeLayout();
        }

        // Manejador global para detectar la carta bajo el cursor sin provocar tantos eventos
        private void PanelMano_MouseMove(object? sender, MouseEventArgs e)
        {
            // Hover deshabilitado: la elevación ocurre sólo al hacer click en la carta.
        }

        private void PanelMano_MouseLeave(object? sender, EventArgs e)
        {
            // No hacer nada; el estado de elevación depende del click.
        }

        private void Carta_Click(object? sender, EventArgs e)
        {
            if (sender is ControlCarta c)
            {
                int indice = mano.IndexOf(c);
                if (indice >= 0)
                {
                    OnCartaClick(indice);
                }
                // Mostrar la carta seleccionada en el panel de información
                MostrarCartaEnPanelInfo(c);
            }
        }

        // Muestra la carta seleccionada dentro de `panelInfoCartas` usando el control
        // `controlCarta1` que está dentro de ese panel.
        private void MostrarCartaEnPanelInfo(ControlCarta carta)
        {
            if (carta == null) return;
            if (controlCarta1 == null) return;

            // Preferir el modelo vinculado si existe, sino copiar propiedades visuales
            if (carta.Modelo != null)
            {
                controlCarta1.VincularModelo(carta.Modelo);
                try
                {
                    controlCarta1.EstablecerColor(PaletaCatppuccin.ColorParaCarta(carta.Modelo.Id));
                }
                catch { }
            }
            else
            {
                controlCarta1.Titulo = carta.Titulo;
                controlCarta1.Imagen = carta.Imagen;
                controlCarta1.Descripcion = carta.Descripcion;
                try
                {
                    // si no hay modelo, usar hash del título para color
                    controlCarta1.EstablecerColor(PaletaCatppuccin.ColorParaTexto(carta.Titulo ?? string.Empty));
                }
                catch { }
            }

            controlCarta1.Dock = DockStyle.Fill;
            controlCarta1.BringToFront();
        }

        private void OnCartaClick(int index)
        {
            // Alternar elevación (flotar) de la carta seleccionada al hacer click.
            if (index < 0 || index >= mano.Count) return;
            var c = mano[index];

            int deltaY = 20;

            // Si la carta ya está elevada, restaurarla
            if (ReferenceEquals(cartaHoverActual, c))
            {
                if (originalY.ContainsKey(c))
                    c.Top = originalY[c];
                cartaHoverActual = null;
                // restaurar prioridad a la central
                int centro = mano.Count / 2;
                if (centro >= 0 && centro < mano.Count)
                    mano[centro].BringToFront();
                return;
            }

            // Restaurar carta previamente elevada si existe
            if (cartaHoverActual != null && originalY.ContainsKey(cartaHoverActual))
            {
                cartaHoverActual.Top = originalY[cartaHoverActual];
            }

            // Elevar la carta clicada
            cartaHoverActual = c;
            if (!originalY.ContainsKey(cartaHoverActual))
                originalY[cartaHoverActual] = cartaHoverActual.Top;
            cartaHoverActual.Top = originalY[cartaHoverActual] - deltaY;
            cartaHoverActual.BringToFront();
        }


        private Mazo CrearMazoDesdeRecursos()
        {
            var lista = new List<Carta>();

            // Cartas para el escenario Incendio
            lista.Add(new Carta(1, "Usar extintor", Properties.Resources.extintor));
            lista.Add(new Carta(2, "Agacharse para evitar humo", Properties.Resources.agacharseHumo));
            lista.Add(new Carta(3, "Cubrir nariz y boca", Properties.Resources.cubrirNarizBoca));
            lista.Add(new Carta(4, "Evacuar por una ruta segura", Properties.Resources.salir)); // factor cómun en inundación y sismo
            lista.Add(new Carta(5, "Cerrar puertas para contener el fuego", Properties.Resources.cerrarPuertas));
            lista.Add(new Carta(6, "Alertar a otras personas", Properties.Resources.alertar));
            lista.Add(new Carta(7, "Llamar a servicios de emergencia", Properties.Resources.llamarEmergencias));

            // cartas trampa
            lista.Add(new Carta(8, "Regresar por objetos personales", Properties.Resources.regresarIncendio));
            lista.Add(new Carta(9, "Abrir ventanas", Properties.Resources.abrirVentanas));
            lista.Add(new Carta(10, "Usar ascensor", Properties.Resources.ascensor)); // factor común en sismo
            lista.Add(new Carta(11, "Tocar una puerta con la mano", Properties.Resources.tocarPuerta));
            lista.Add(new Carta(12, "Entrar en áreas llenas de humo", Properties.Resources.entrarHumo));

            // Cartas para el escenario Inundación
            lista.Add(new Carta(13, "Buscar zonas altas", Properties.Resources.buscarZonasAltas));
            lista.Add(new Carta(14, "Desconectar la electricidad si es seguro", Properties.Resources.desconectarElectricidad));
            lista.Add(new Carta(15, "Llevar documentos importantes en bolsa sellada", Properties.Resources.documentosSellados));
            lista.Add(new Carta(16, "Cerrar llaves de agua y gas", Properties.Resources.cerrarLlaves));

            // cartas trampa
            lista.Add(new Carta(17, "Intentar cruzar corrientes fuertes", Properties.Resources.cruzarCorrientes));
            lista.Add(new Carta(18, "Tocar aparatos eléctricos mojados", Properties.Resources.tocarAparatosElecMojados));

            // Cartas para el escenario Sismo
            lista.Add(new Carta(19, "Agacharse, cubrirse y sujetarse", Properties.Resources.agacharseSismo));
            lista.Add(new Carta(20, "Alejarse de ventanas y objetos que puedan caer", Properties.Resources.alejarseVentanasObjetos));
            lista.Add(new Carta(21, "Cortar gas o electricidad después del sismo (si es seguro)", Properties.Resources.cortarGasElecSismo));
            lista.Add(new Carta(22, "Reunirse en punto seguro", Properties.Resources.reunirsePuntoSeguro));

            // cartas trampa
            lista.Add(new Carta(23, "Salir corriendo durante el sismo", Properties.Resources.salirCorriendoSismo));
            lista.Add(new Carta(24, "Quedarse cerca de las paredes", Properties.Resources.cercaParedesSismo));

            return new Mazo(lista);
        }

        private void AgregarCartaAInterfaz(Carta carta)
        {
            if (carta == null) return;

            // validar límite de cartas en mano
            if (cartasEnMano.Count >= MaxCartasMano)
            {
                MessageBox.Show($"No puedes tener más de {MaxCartasMano} cartas en la mano.", "Límite de cartas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Crear un ControlCarta a partir del modelo y vincularlo
            var control = new ControlCarta
            {
                Size = new Size(140, 200),
                BackColor = Color.Transparent
            };

            control.VincularModelo(carta);
            try
            {
                // Asignar color único desde la paleta Mocha usando el id de la carta
                var color = PaletaCatppuccin.ColorParaCarta(carta.Id);
                control.EstablecerColor(color);
            }
            catch { }
            control.Click += Carta_Click;
            AttachClickHandlers(control, control);

            // --- Suscribir eventos para drag start (inicio de arrastre) ---
            control.MouseDown += ControlCarta_MouseDown;
            control.MouseMove += ControlCarta_MouseMove;
            control.MouseUp += ControlCarta_MouseUp;

            panelMano.Controls.Add(control);
            mano.Add(control);
            cartasEnMano.Add(carta);

            // recalcular posiciones
            DistribuirMano();
        }

        private void ActualizarMazoUI()
        {
            if (mazo == null) return;
            pbMazo.Image = mazo.Cantidad > 0 ? Properties.Resources.parteTrasera : Properties.Resources.parteTrasera;
        }


        private void pbMazo_Click(object sender, EventArgs e)
        {
            // Al hacer click en el mazo se roba una carta y se añade a la mano.
            // No requerimos que la partida haya empezado para esta acción.
            if (mazo == null)
            {
                mazo = CrearMazoDesdeRecursos();
                mazo.Barajar();
            }

            // Deshabilitar temporalmente el control para evitar clicks rápidos consecutivos
            pbMazo.Enabled = false;
            try
            {
                Carta? carta = null;
                lock (mazo)
                {
                    carta = mazo.Robar();
                }

                if (carta == null)
                {
                    MessageBox.Show("El mazo está vacío.");
                    return;
                }

                // Añadir la carta al modelo y a la interfaz de forma rápida.
                // Suspender layout del panel de mano para reducir repintados costosos.
                panelMano.SuspendLayout();
                try
                {
                    AgregarCartaAInterfaz(carta);
                }
                finally
                {
                    panelMano.ResumeLayout();
                }

                // Actualizar UI del mazo (cantidad/imagen)
                ActualizarMazoUI();
            }
            finally
            {
                // Reactivar el picturebox si quedan cartas en el mazo
                pbMazo.Enabled = (mazo?.Cantidad > 0);
            }
        }

        // Nota: la selección de nivel se gestiona desde el formulario de menú. Las funciones
        // relacionadas con el cambio de nivel se han eliminado de este formulario.

        // Escenarios disponibles y posición actual
        private readonly string[] escenarios = new[] { "incendio", "inundacion", "sismo" };
        private int indiceEscenarioActual = 0;
        // nivel seleccionado (0=facil,1=intermedio,2=dificil) — expuesto para record y menu
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int NivelSeleccionado { get; set; } = 0;

        // Avanza al siguiente escenario y actualiza la imagen
        public void AvanzarEscenario()
        {
            indiceEscenarioActual = (indiceEscenarioActual + 1) % escenarios.Length;
            var nombre = escenarios[indiceEscenarioActual];
            try
            {
                // Buscar recurso por nombre en Properties.Resources
                var prop = typeof(Properties.Resources).GetProperty(nombre, System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.IgnoreCase);
                if (prop != null)
                {
                    var img = prop.GetValue(null) as System.Drawing.Image;
                    if (img != null) pbEscenarios.Image = img;
                }
            }
            catch { }
            // actualizar etiqueta descriptiva del escenario
            try { ActualizarLabelEscenario(); } catch { }
        }

        // Mover las cartas del tablero de vuelta al mazo, rebarajar, repartir mano inicial,
        // avanzar el escenario, y resetear el temporizador para el nuevo nivel.
        public void AvanzarASiguienteEscenario()
        {
            // Detener temporizador mientras manipulamos cartas
            try { DetenerTemporizador(); } catch { }

            // Recoger todas las cartas del tablero y devolverlas al mazo
            var controles = tablaTableroCartas.Controls.Cast<Control>().OfType<ControlCarta>().ToList();
            foreach (var cc in controles)
            {
                try
                {
                    // intentar extraer el modelo asociado para devolver al mazo
                    if (cc.Modelo != null)
                        mazo?.Agregar(cc.Modelo);
                }
                catch { }

                // quitar manejadores y remover control
                try { DetachTableroMouseUp(cc); } catch { }
                try { tablaTableroCartas.Controls.Remove(cc); } catch { }
            }

            // Rebarajar el mazo
            try { mazo?.Barajar(); } catch { }

            // Limpiar la mano actual y controles asociados
            foreach (var c in mano.ToList())
            {
                try { panelMano.Controls.Remove(c); } catch { }
            }
            mano.Clear();
            originalY.Clear();
            cartasEnMano.Clear();

            // Robar nuevas cartas iniciales
            const int cartasIniciales = 3;
            for (int i = 0; i < cartasIniciales; i++)
            {
                var carta = mazo?.Robar();
                if (carta == null) break;
                AgregarCartaAInterfaz(carta);
            }

            ActualizarMazoUI();

            // Avanzar escenario visualmente
            AvanzarEscenario();

            try { ActualizarLabelEscenario(); } catch { }

            // Resetear temporizador al valor configurado e iniciar
            segundosRestantes = duracionNivelInicial;
            lbTiempo.Content = FormatoTiempo(segundosRestantes);
            nivelTimer.Start();
            juegoIniciado = true;
            tablaTableroCartas.AllowDrop = true;
            pbMazo.Enabled = (mazo?.Cantidad > 0);
        }

        // Conjunto de nombres correctos para el escenario actual
        private HashSet<string> CorrectNamesForScenario()
        {
            // Solo pueden haber hasta 10 cartas correctas por escenario
            // porque el tablero solo tiene 10 espacios para colocar cartas
            return escenarios[indiceEscenarioActual] switch
            {
                "incendio" => new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                {
                    "Usar extintor",
                    "Agacharse para evitar humo",
                    "Cubrir nariz y boca",
                    "Evacuar por una ruta segura",
                    "Cerrar puertas para contener el fuego",
                    "Alertar a otras personas",
                    "Llamar a servicios de emergencia"
                },
                "inundacion" => new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                {
                    "Buscar zonas altas",
                    "Desconectar la electricidad si es seguro",
                    "Llevar documentos importantes en bolsa sellada",
                    "Cerrar llaves de agua y gas"
                },
                "sismo" => new HashSet<string>(StringComparer.OrdinalIgnoreCase)
                {
                    "Agacharse, cubrirse y sujetarse",
                    "Alejarse de ventanas y objetos que puedan caer",
                    "Cortar gas o electricidad después del sismo (si es seguro)",
                    "Reunirse en punto seguro"
                },
                _ => new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            };
        }

        private bool EsCartaCorrectaParaEscenario(Carta c)
        {
            if (c == null) return false;
            var set = CorrectNamesForScenario();
            return set.Contains(c.Nombre);
        }

        // Exponer los nombres correctos para el escenario actual para uso externo
        public HashSet<string> ObtenerNombresCorrectosActual()
        {
            return CorrectNamesForScenario();
        }

        // Devuelve el nombre del escenario actual (p.ej. "incendio", "inundacion", "sismo").
        public string ObtenerNombreEscenarioActual()
        {
            try
            {
                if (indiceEscenarioActual >= 0 && indiceEscenarioActual < escenarios.Length)
                    return escenarios[indiceEscenarioActual];
            }
            catch { }
            return string.Empty;
        }

        // Muestra el formulario de corrección en modo "vida agotada" de forma segura
        public void MostrarCorreccionPorVidaAgotada(List<(string titulo, bool correcto)> lista)
        {
            if (mostrandoCorreccion)
            {
                // Si ya hay un formulario de corrección abierto, marcarlo para que muestre GAME OVER
                try
                {
                    this.BeginInvoke(new Action(() =>
                    {
                        try
                        {
                            var openForm = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f is fmCorreccionRespuestas) as fmCorreccionRespuestas;
                            if (openForm != null)
                            {
                                try { openForm.MarcarComoVidaAgotada(); } catch { }
                            }
                        }
                        catch { }
                    }));
                }
                catch { }

                return;
            }

            mostrandoCorreccion = true;
            try
            {
                // Usar BeginInvoke para asegurar que no estamos en medio de la construcción
                // de otro diálogo que pueda provocar reentradas.
                this.BeginInvoke(new Action(() =>
                {
                    try
                    {
                        var form = new fmCorreccionRespuestas(lista, this, true);
                        form.StartPosition = FormStartPosition.CenterParent;
                        try { form.ShowDialog(this); } catch { try { form.ShowDialog(); } catch { } }
                    }
                    catch { }
                    finally
                    {
                        mostrandoCorreccion = false;
                    }
                }));
            }
            catch { mostrandoCorreccion = false; }
        }

        // Comprueba si el jugador ha colocado todas las cartas correctas del escenario en el tablero.
        private void CheckWinCondition()
        {
            var required = CorrectNamesForScenario();
            if (required == null || required.Count == 0) return;

            var presentes = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (Control ctrl in tablaTableroCartas.Controls)
            {
                if (ctrl is Juego_de_cartas.ControlCarta cc)
                {
                    var nombre = cc.Modelo?.Nombre ?? cc.Titulo ?? string.Empty;
                    if (!string.IsNullOrWhiteSpace(nombre)) presentes.Add(nombre);
                }
            }

            // verificar que todos los requeridos estén presentes
            foreach (var req in required)
            {
                if (!presentes.Contains(req)) return; // falta alguna
            }

            // Si llegamos aquí, el usuario ha colocado todas las cartas correctas: gana
            try { DetenerTemporizador(); } catch { }

            // No actualizar el récord desde aquí: la actualización y los mensajes
            // asociados se realizan en el formulario de corrección (`fmCorreccionRespuestas`)
            // tras mostrar la lista de resultados. Esto evita escrituras prematuras
            // o duplicadas en el gestor de récords cuando la comprobación se dispara
            // desde distintos puntos del flujo (drag/drop vs. validación manual).

            // Mostrar corrección y récord
            var lista = new List<(string titulo, bool correcto)>();
            foreach (Control ctrl in tablaTableroCartas.Controls)
            {
                if (ctrl is Juego_de_cartas.ControlCarta cc)
                {
                    Carta modelo = cc.Modelo ?? (cc.Titulo != null ? new Carta(-1, cc.Titulo, cc.Imagen) : null);
                    bool correcto = false;
                    if (modelo != null) correcto = EsCartaCorrectaParaEscenario(modelo);
                    var titulo = modelo?.Nombre ?? cc.Titulo ?? cc.Name ?? "(sin nombre)";
                    lista.Add((titulo, correcto));
                }
            }

            var form = new fmCorreccionRespuestas(lista, this);
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        // Colorea recursivamente un control y sus hijos
        private void SetForeColorRecursive(Control root, System.Drawing.Color color)
        {
            if (root == null) return;
            try { root.ForeColor = color; } catch { }
            foreach (Control child in root.Controls)
            {
                SetForeColorRecursive(child, color);
            }
        }

        // Manejar validación y mostrar ventana de corrección
        private void BtnValidar_Click(object? sender, EventArgs e)
        {
            // Recolectar cartas colocadas en el tablero
            var lista = new List<(string titulo, bool correcto)>();
            foreach (Control ctrl in tablaTableroCartas.Controls)
            {
                if (ctrl is Juego_de_cartas.ControlCarta cc)
                {
                    Carta modelo = cc.Modelo ?? (cc.Titulo != null ? new Carta(-1, cc.Titulo, cc.Imagen) : null);
                    bool correcto = false;
                    if (modelo != null) correcto = EsCartaCorrectaParaEscenario(modelo);
                    var titulo = modelo?.Nombre ?? cc.Titulo ?? cc.Name ?? "(sin nombre)";
                    lista.Add((titulo, correcto));

                    // Colorear directamente la carta en el tablero: rojo o verde según resultado
                    var rojo = System.Drawing.Color.FromArgb(243, 139, 168);
                    var verde = System.Drawing.Color.FromArgb(166, 227, 161);
                    SetForeColorRecursive(cc, correcto ? verde : rojo);
                }
            }

            // Mostrar formulario de corrección
            if (!mostrandoCorreccion)
            {
                mostrandoCorreccion = true;
                try
                {
                    var form = new fmCorreccionRespuestas(lista, this);
                    form.StartPosition = FormStartPosition.CenterParent;
                    try { form.ShowDialog(this); } finally { mostrandoCorreccion = false; }
                }
                catch { mostrandoCorreccion = false; }
            }
        }

        private void BtnJugar_Click(object? sender, EventArgs e)
        {
            // marcar partida iniciada, permitir drag/drop y habilitar mazo
            juegoIniciado = true;
            tablaTableroCartas.AllowDrop = true;
            pbMazo.Enabled = true;
            IniciarTemporizadorSegunNivel();
        }

        private void BtnTerminar_Click(object? sender, EventArgs e)
        {
            DetenerTemporizador();
        }

        private void BtnVolverMenuInicio_Click(object? sender, EventArgs e)
        {
            // Detener temporizador y cerrar este formulario para volver al menú de inicio
            try
            {
                DetenerTemporizador();
            }
            catch { }

            // Intentar insertar el formulario menuPrincipalJuegoCartas dentro de panel2 de fmMenu
            try
            {
                var main = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f.GetType().Name == "fmMenu");
                if (main != null)
                {
                    var tipoMain = main.GetType();
                    var metodo = tipoMain.GetMethod("abrirFormularioHijo", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
                    if (metodo != null)
                    {
                        var menuForm = new menuPrincipalJuegoCartas();
                        metodo.Invoke(main, new object[] { menuForm });
                        // cerrar este formulario si está como dialog o incrustado
                        try { this.Close(); } catch { }
                        return;
                    }
                }
            }
            catch { }

            // Fallback: cerrar el formulario
            try { this.Close(); } catch { }
        }

        private void BtnInstrucciones_Click(object? sender, EventArgs e)
        {
            try
            {
                // Mostrar formulario modal con instrucciones específicas del nivel seleccionado
                int nivel = NivelSeleccionado;
                var frm = new fmInstruccionesJuegoCartas(nivel);
                frm.StartPosition = FormStartPosition.CenterParent;
                try { frm.ShowDialog(this); } catch { try { frm.ShowDialog(); } catch { } }
            }
            catch { }
        }

        private void NivelTimer_Tick(object? sender, EventArgs e)
        {
            if (segundosRestantes > 0)
            {
                segundosRestantes--;
                // Mostrar tiempo restante en el formato solicitado: "Tiempo: 120 segundos"
                lbTiempo.Content = $"Tiempo: {segundosRestantes} segundos";
            }
            else
            {
                // tiempo agotado
                DetenerTemporizador();
                MessageBox.Show("Tiempo terminado para este nivel.", "Tiempo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // podrias disparar la lógica de fin de turno/ronda aquí
            }
        }

        private void IniciarTemporizadorSegunNivel()
        {
            // Usar la duración originalmente configurada (desde el menú) a menos que
            // se quiera permitir cambiarla desde la UI.
            int segundos = duracionNivelInicial;
            segundosRestantes = segundos;
            lbTiempo.Content = FormatoTiempo(segundosRestantes);
            nivelTimer.Start();
        }

        private void DetenerTemporizador()
        {
            nivelTimer?.Stop();
        }

        private void ActualizarDisplayTiempoSegunNivel()
        {
            int idx = cbNiveles?.SelectedIndex ?? -1;
            int segundos = idx switch
            {
                0 => 9 * 60,
                1 => 8 * 60,
                2 => 7 * 60,
                _ => 9 * 60
            };
            lbTiempo.Content = FormatoTiempo(segundos);
        }

        private string FormatoTiempo(int segundos)
        {
            // Mostrar en el formato solicitado: "Tiempo: N segundos"
            return $"Tiempo: {Math.Max(0, segundos)} segundos";
        }

        private void fmJuegoCartasEmergencias_Load(object sender, EventArgs e)
        {
            mazo = CrearMazoDesdeRecursos();
            mazo.Barajar();
            // Robar algunas cartas iniciales del mazo para poblar la mano
            const int cartasIniciales = 3;
            for (int i = 0; i < cartasIniciales; i++)
            {
                var carta = mazo.Robar();
                if (carta == null) break;
                AgregarCartaAInterfaz(carta);
            }

            // Asegurar que el contador de puntos de vida muestre el valor inicial
            ResetearPuntosVida();

            try { ActualizarLabelEscenario(); } catch { }

            ActualizarMazoUI();
        }

        // Reinicia completamente el estado del juego como al iniciar la aplicación por primera vez.
        public void ReiniciarJuego()
        {
            // Detener temporizador y limpiar estado temporal
            try { DetenerTemporizador(); } catch { }
            // evitar que queden suscripciones antiguas: recrear el timer
            try
            {
                if (nivelTimer != null)
                {
                    try { nivelTimer.Tick -= NivelTimer_Tick; } catch { }
                    try { nivelTimer.Stop(); } catch { }
                    try { nivelTimer.Dispose(); } catch { }
                }
            }
            catch { }
            nivelTimer = new System.Windows.Forms.Timer();
            nivelTimer.Interval = 1000;
            nivelTimer.Tick += NivelTimer_Tick;

            // Quitar manejadores del tablero y eliminar controles en el tablero
            var controlesTablero = tablaTableroCartas.Controls.Cast<Control>().ToList();
            foreach (var c in controlesTablero)
            {
                try { DetachTableroMouseUp(c); } catch { }
                try { tablaTableroCartas.Controls.Remove(c); } catch { }
            }

            // Limpiar mano y controles asociados
            foreach (var c in mano.ToList())
            {
                try { panelMano.Controls.Remove(c); } catch { }
            }
            mano.Clear();
            originalY.Clear();
            cartasEnMano.Clear();

            // Resetear el control de información de carta para que no muestre la última carta de la partida anterior
            try
            {
                if (controlCarta1 != null)
                {
                    try { controlCarta1.Titulo = ""; } catch { }
                    try { controlCarta1.Descripcion = ""; } catch { }
                    try { controlCarta1.Imagen = null; } catch { }
                    try { controlCarta1.Refresh(); } catch { }
                }
            }
            catch { }

            // Reiniciar mazo y repartir cartas iniciales
            mazo = CrearMazoDesdeRecursos();
            mazo.Barajar();
            const int cartasIniciales = 3;
            for (int i = 0; i < cartasIniciales; i++)
            {
                var carta = mazo.Robar();
                if (carta == null) break;
                AgregarCartaAInterfaz(carta);
            }

            ActualizarMazoUI();

            // Resetear tiempo mostrado al valor previamente configurado (no recalcular desde UI)
            segundosRestantes = duracionNivelInicial;
            lbTiempo.Content = FormatoTiempo(segundosRestantes);

            // Nota: no reiniciamos los puntos de vida aquí para preservar el valor
            // entre partidas si el usuario pulsa "Jugar de nuevo". Los puntos de vida
            // sólo se reinician al cargar por primera vez el formulario o cuando se
            // desee explícitamente ResetearPuntosVida().

            // Estado de juego no iniciado: dejar que quien llama (por ejemplo, el botón "Jugar de nuevo")
            // inicie la partida llamando a IniciarJuego(). Esto evita duplicar el arranque del temporizador
            juegoIniciado = false;
            tablaTableroCartas.AllowDrop = false;
            pbMazo.Enabled = (mazo?.Cantidad > 0);

            // refrescar UI
            panelMano.Refresh();
            tablaTableroCartas.Refresh();
        }

        // Resetea el temporizador y estado relacionado para evitar que al navegar a otro formulario
        // se dispare el evento de tiempo agotado.
        private void ResetTimerAndState()
        {
            try { nivelTimer?.Stop(); } catch { }
            // restaurar segundos al valor configurado, pero no iniciar
            segundosRestantes = duracionNivelInicial;
            try { lbTiempo.Content = FormatoTiempo(segundosRestantes); } catch { }
            // marcar como no iniciado para bloquear arrastres
            juegoIniciado = false;
            try { tablaTableroCartas.AllowDrop = false; } catch { }
        }

        // Exponer información y control del temporizador al formulario de corrección
        public int ObtenerSegundosRestantes() => segundosRestantes;
        public int ObtenerDuracionNivelInicial() => duracionNivelInicial;
        public void PararTemporizador() => DetenerTemporizador();

        // --- Drag / Drop handlers ---

        private void ControlCarta_MouseDown(object? sender, MouseEventArgs e)
        {
            // Solo iniciar posible arrastre si la partida está iniciada
            if (sender is ControlCarta c && e.Button == MouseButtons.Left && juegoIniciado)
            {
                dragSource = c;
                dragStartPoint = e.Location;
            }
        }

        private void ControlCarta_MouseMove(object? sender, MouseEventArgs e)
        {
            // No permitir iniciar arrastre si la partida no ha comenzado
            if (!juegoIniciado) return;

            if (sender is ControlCarta c && dragSource == c && e.Button == MouseButtons.Left)
            {
                var delta = new Size(Math.Abs(e.X - dragStartPoint.X), Math.Abs(e.Y - dragStartPoint.Y));
                // usar SystemInformation.DragSize como umbral razonable
                if (delta.Width >= SystemInformation.DragSize.Width || delta.Height >= SystemInformation.DragSize.Height)
                {
                    // iniciar drag con la instancia del control (se pasa por referencia dentro del mismo proceso)
                    c.DoDragDrop(c, DragDropEffects.Move);
                    // una vez iniciado, limpiar estado local
                    dragSource = null;
                }
            }
        }

        private void ControlCarta_MouseUp(object? sender, MouseEventArgs e)
        {
            // limpiar estado de drag aunque no se haya iniciado el DoDragDrop
            dragSource = null;
        }

        private void TableroCartas_DragEnter(object? sender, DragEventArgs e)
        {
            // aceptamos si el objeto arrastrado es un ControlCarta
            if (e.Data.GetData(typeof(ControlCarta)) is ControlCarta)
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void TableroCartas_DragOver(object? sender, DragEventArgs e)
        {
            // mantener efecto si es un ControlCarta
            if (e.Data.GetData(typeof(ControlCarta)) is ControlCarta)
                e.Effect = DragDropEffects.Move;
            else
                e.Effect = DragDropEffects.None;
        }

        private void TableroCartas_DragDrop(object? sender, DragEventArgs e)
        {
            if (!(e.Data.GetData(typeof(ControlCarta)) is ControlCarta cartaControl)) return;
            // calcular celda destino a partir de la posición del cursor
            Point clientPoint = tablaTableroCartas.PointToClient(new Point(e.X, e.Y));
            var cell = GetCellFromPoint(tablaTableroCartas, clientPoint);
            if (cell.column < 0 || cell.row < 0) return;

            // si la celda ya contiene una carta, rechazar (o podrías intercambiar)
            var existente = tablaTableroCartas.GetControlFromPosition(cell.column, cell.row);
            if (existente != null)
            {
                MessageBox.Show("Casilla ocupada.", "No se puede soltar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // quitar desde su contenedor actual (probablemente panelMano)
            var indexEnMano = mano.IndexOf(cartaControl);
            if (indexEnMano >= 0)
            {
                mano.RemoveAt(indexEnMano);
                cartasEnMano.RemoveAt(Math.Min(indexEnMano, cartasEnMano.Count - 1));
            }
            else
            {
                // si no estaba en mano (por ejemplo, movida entre casillas del tablero), remover desde su padre antiguo
                if (cartaControl.Parent is TableLayoutPanel oldTbl)
                {
                    oldTbl.Controls.Remove(cartaControl);
                }
                else
                {
                    cartaControl.Parent?.Controls.Remove(cartaControl);
                }
            }

            // añadir la carta al tablero en la celda correspondiente
            tablaTableroCartas.Controls.Add(cartaControl, cell.column, cell.row);
            cartaControl.Dock = DockStyle.Fill;
            cartaControl.Margin = new Padding(2);
            cartaControl.BringToFront();

            // Suscribir un manejador para que al hacer click derecho sobre una carta en el tablero
            // esta vuelva a la mano del jugador. Se adjunta al control y a sus hijos para
            // que clicar sobre la imagen/etiqueta también funcione.
            AttachTableroMouseUp(cartaControl);

            // Si el usuario suelta la carta sobre el PictureBox del cementerio, no debería llegar aquí.
            // El manejo específico para pbCementerio será mediante eventos DragEnter/DragDrop del PictureBox.

            // recalcular la mano (posiciones)
            DistribuirMano();

            // Comprobar condición de victoria: si todas las cartas correctas están en el tablero
            try { CheckWinCondition(); } catch { }
        }

        // Devuelve columna/filas aproximadas para la posición en el TableLayoutPanel
        private (int column, int row) GetCellFromPoint(TableLayoutPanel table, Point pt)
        {
            if (table.ColumnCount == 0 || table.RowCount == 0) return (-1, -1);
            // calcular anchuras/alturas por celda (aproximado)
            int colWidth = table.ClientSize.Width / table.ColumnCount;
            int rowHeight = table.ClientSize.Height / table.RowCount;
            int col = Math.Min(table.ColumnCount - 1, Math.Max(0, pt.X / Math.Max(1, colWidth)));
            int row = Math.Min(table.RowCount - 1, Math.Max(0, pt.Y / Math.Max(1, rowHeight)));
            return (col, row);
        }

        // Manejador que se asigna cuando una carta está en el tablero. Al hacer click
        // sobre la carta se devuelve a la mano del jugador.
        private void TableroCarta_Click(object? sender, EventArgs e)
        {
            if (sender is ControlCarta cartaControl)
            {
                MoverCartaDeTableroAMano(cartaControl);
            }
        }

        // Maneja el drop de una carta sobre el PictureBox del cementerio
        private void PbCementerio_DragDrop(object? sender, DragEventArgs e)
        {
            if (!(e.Data.GetData(typeof(ControlCarta)) is ControlCarta cartaControl)) return;

            // Quitar la carta de su contenedor actual (mano o tablero)
            try
            {
                if (mano.Contains(cartaControl))
                {
                    int idx = mano.IndexOf(cartaControl);
                    mano.RemoveAt(idx);
                    if (idx < cartasEnMano.Count) cartasEnMano.RemoveAt(idx);
                }
                else
                {
                    cartaControl.Parent?.Controls.Remove(cartaControl);
                }
            }
            catch { }

            // Si la carta tiene modelo, añadirlo al mazo cementerio
            try
            {
                if (cartaControl.Modelo != null)
                {
                    cementerioMazo.Agregar(cartaControl.Modelo);

                    // Si la carta era correcta para el escenario, penalizar vida según nivel
                    try
                    {
                        if (EsCartaCorrectaParaEscenario(cartaControl.Modelo))
                        {
                            // Penalizaciones balanceadas considerando 100 puntos de vida
                            int penalizacion = NivelSeleccionado switch
                            {
                                0 => 5,  // fácil
                                1 => 10, // intermedio
                                2 => 15, // difícil
                                _ => 5
                            };
                            // construir razón amigable que incluya el título de la carta cuando esté disponible
                            string nombreCarta = cartaControl.Modelo != null ? cartaControl.Modelo.Nombre : (cartaControl.Titulo ?? "Carta enviada al cementerio");
                            string razon = $"Carta: {nombreCarta}";
                            // Mostrar detalle temporal en labelPuntosPerdidos y el nombre en labelPuntosPerdidosCarta
                            RestarPuntosVida(penalizacion, razon);
                            try
                            {
                                if (labelPuntosPerdidosCarta != null)
                                {
                                    labelPuntosPerdidosCarta.Content = $"Por mandar al cementerio a: {nombreCarta}";
                                    labelPuntosPerdidosCarta.Visible = true;
                                }
                            }
                            catch { }
                        }
                    }
                    catch { }
                }
            }
            catch { }

            // Remover manejadores asociados y control visual
            try { DetachTableroMouseUp(cartaControl); } catch { }
            try { cartaControl.Dispose(); } catch { }

            // Recalcular mano
            try { DistribuirMano(); } catch { }
        }

        // Adjunta manejadores MouseUp (para botón derecho) a un control y a todos sus hijos
        // y guarda el delegado para poder eliminarlo cuando la carta vuelva a la mano.
        private void AttachTableroMouseUp(Control root)
        {
            if (root == null) return;
            // si ya tiene manejador, no volver a adjuntar
            if (tableroMouseUpHandlers.ContainsKey(root)) return;

            MouseEventHandler onMouseUp = null!;
            onMouseUp = (s, me) =>
            {
                if (me.Button == MouseButtons.Right)
                {
                    // comprobar permiso por la configuración establecida
                    if (!permitirRegresoEnTablero)
                        return;

                    // si el emisor es el propio ControlCarta
                    if (s is ControlCarta cc)
                        MoverCartaDeTableroAMano(cc);
                    else if (s is Control ctrl && ctrl.Parent is ControlCarta parentCarta)
                        MoverCartaDeTableroAMano(parentCarta);
                }
            };

            tableroMouseUpHandlers[root] = onMouseUp;
            // Attach to root and all children (non-recursive stack to avoid deep recursion)
            var stack = new Stack<Control>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var c = stack.Pop();
                c.MouseUp += onMouseUp;
                foreach (Control child in c.Controls)
                {
                    stack.Push(child);
                }
            }
        }

        // Elimina los manejadores adjuntados por AttachTableroMouseUp para el control raíz
        private void DetachTableroMouseUp(Control root)
        {
            if (root == null) return;
            if (!tableroMouseUpHandlers.TryGetValue(root, out var handler)) return;

            // Remover de root y todos sus hijos
            var stack = new Stack<Control>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var c = stack.Pop();
                try { c.MouseUp -= handler; } catch { }
                foreach (Control child in c.Controls)
                {
                    stack.Push(child);
                }
            }

            tableroMouseUpHandlers.Remove(root);
        }

        // Mueve la carta desde el TableLayoutPanel del tablero hacia el panelMano y
        // actualiza las estructuras internas (mano y cartasEnMano).
        private void MoverCartaDeTableroAMano(ControlCarta cartaControl)
        {
            if (cartaControl == null) return;

            // Remover del tablero si está contenido en él
            if (tablaTableroCartas.Controls.Contains(cartaControl))
            {
                tablaTableroCartas.Controls.Remove(cartaControl);
            }
            else
            {
                cartaControl.Parent?.Controls.Remove(cartaControl);
            }

            // Restaurar propiedades visuales para la mano
            cartaControl.Dock = DockStyle.None;
            cartaControl.Margin = new Padding(0);
            cartaControl.Size = new Size(140, 200);

            // Añadir al panel de la mano y a las listas de seguimiento
            // Quitar manejadores del tablero (MouseUp) antes de reusar el control
            DetachTableroMouseUp(cartaControl);

            // Añadir al panel de la mano y a las listas de seguimiento usando suspensión de layout
            panelMano.SuspendLayout();
            try
            {
                panelMano.Controls.Add(cartaControl);
                cartaControl.Visible = true;
                mano.Add(cartaControl);
                if (cartaControl.Modelo != null)
                    cartasEnMano.Add(cartaControl.Modelo);

                // Recalcular la disposición de la mano
                DistribuirMano();
            }
            finally
            {
                panelMano.ResumeLayout();
                panelMano.Refresh();
            }
        }

        private void fmJuegoCartasEmergencias_Load_1(object sender, EventArgs e)
        {

        }

        private void tablaGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tablaVentana_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tablaCementerio_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
