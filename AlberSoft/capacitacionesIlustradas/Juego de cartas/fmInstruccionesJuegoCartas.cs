using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlberSoft.capacitacionesIlustradas
{
    public class fmInstruccionesJuegoCartas : Form
    {
        private TableLayoutPanel tabla;
        private Label lblTitulo;
        private FlowLayoutPanel panelImagenes;
        private FlowLayoutPanel panelContenido;
        private Button btnAceptar;

        public fmInstruccionesJuegoCartas(int nivel)
        {
            InitializeComponent();
            CargarInstrucciones(nivel);
        }

        private void InitializeComponent()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.Size = new Size(820, 540);
            this.Text = "Instrucciones del Juego";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            tabla = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 3,
                Padding = new Padding(12),
            };
            tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tabla.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tabla.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tabla.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tabla.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

            lblTitulo = new Label
            {
                Text = "Instrucciones",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                AutoSize = false
            };

            panelImagenes = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                Padding = new Padding(6)
            };

            panelContenido = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                Padding = new Padding(8),
                WrapContents = false
            };

            btnAceptar = new Button
            {
                Text = "Aceptar",
                Dock = DockStyle.Right,
                Width = 100
            };
            btnAceptar.Click += (s, e) => this.Close();

            // Arrange controls
            tabla.Controls.Add(lblTitulo, 0, 0);
            tabla.SetColumnSpan(lblTitulo, 2);
            tabla.Controls.Add(panelContenido, 0, 1);
            tabla.Controls.Add(panelImagenes, 1, 1);
            var panelBotones = new Panel { Dock = DockStyle.Fill };
            panelBotones.Controls.Add(btnAceptar);
            tabla.Controls.Add(panelBotones, 0, 2);
            tabla.SetColumnSpan(panelBotones, 2);

            this.Controls.Add(tabla);
        }

        private void CargarInstrucciones(int nivel)
        {
            // Limpiar contenido previo
            panelContenido.Controls.Clear();

            // Texto base dividido en secciones para usar labels (mejor control de estilo)
            string objetivo = "Colocar en el tablero las acciones correctas para el escenario actual (incendio, inundación o sismo).";
            string comoJugar = "Pulsa el mazo para robar cartas.\nArrastra las cartas desde tu mano hasta una casilla del tablero.\nSi deseas descartar una carta, arrástrala al icono del cementerio.\nPulsa 'Validar Respuestas' cuando creas que las cartas colocadas son las correctas para el escenario.";

            // Detalle por nivel con penalizaciones y razones
            string detalleNivel;
            switch (nivel)
            {
                case 0: // fácil
                    detalleNivel = "Nivel: Fácil\n" +
                        "- Este modo es introductorio: recibirás más ayudas y las penalizaciones son menores.\n" +
                        "- Penalización por enviar una carta CORRECTA al cementerio: 5 puntos.\n" +
                        "  Por qué: estás eliminando una acción necesaria del tablero, pero en Fácil la pérdida es reducida para facilitar el aprendizaje.\n\n";
                    break;
                case 1: // intermedio
                    detalleNivel = "Nivel: Intermedio\n" +
                        "- Menos ayudas que en Fácil; presta atención al escenario.\n" +
                        "- Penalización por enviar una carta CORRECTA al cementerio: 10 puntos.\n" +
                        "  Por qué: eliminar una acción correcta dificulta la respuesta ante el evento; la penalización es moderada.\n\n";
                    break;
                case 2: // difícil
                    detalleNivel = "Nivel: Difícil\n" +
                        "- Modo con menor tolerancia y penalizaciones más severas.\n" +
                        "- Penalización por enviar una carta CORRECTA al cementerio: 15 puntos.\n" +
                        "  Por qué: en Difícil cada acción correcta es crítica; perderla supone un coste alto.\n\n";
                    break;
                default:
                    detalleNivel = "Nivel: (desconocido)\n\n";
                    break;
            }

            string consejos = "Usa el panel de información (lado izquierdo) para ver detalles de cada carta antes de colocarla.\nPrioriza acciones claramente útiles para el escenario (por ejemplo: extintor en incendios, buscar zonas altas en inundaciones, agacharse y cubrirse en sismos).\nEvita acciones marcadas como trampa (entrar en áreas con humo, usar ascensor durante sismo, intentar cruzar corrientes).";

            // helper para añadir secciones
            void AddSection(string titulo, string texto)
            {
                var lblTitulo = new Label
                {
                    Text = titulo,
                    Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                    AutoSize = false,
                    Width = 460,
                    Height = 22
                };

                var lblTexto = new Label
                {
                    Text = texto,
                    Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                    AutoSize = true,
                    MaximumSize = new Size(460, 0),
                    Padding = new Padding(0, 4, 0, 12)
                };

                panelContenido.Controls.Add(lblTitulo);
                panelContenido.Controls.Add(lblTexto);
            }

            AddSection("Objetivo", objetivo);
            AddSection("Cómo jugar", comoJugar);

            // Preparar imágenes y leyendas en el panel derecho
            panelImagenes.Controls.Clear();

            void AddIllustration(Image img, string titulo, string descripcion)
            {
                var p = new Panel { Width = 300, Height = 140, Margin = new Padding(6) };
                var pb = new PictureBox { Image = img, SizeMode = PictureBoxSizeMode.Zoom, Dock = DockStyle.Left, Width = 120 };
                var lbl = new Label { Text = titulo + "\n\n" + descripcion, Dock = DockStyle.Fill, AutoSize = false, Padding = new Padding(8), Font = new Font("Segoe UI", 9F) };
                p.Controls.Add(lbl);
                p.Controls.Add(pb);
                panelImagenes.Controls.Add(p);
            }

            try
            {
                // imagen del mazo
                Image imgMazo = null;
                try { imgMazo = Properties.Resources.parteTrasera; } catch { }
                AddIllustration(imgMazo ?? new Bitmap(1, 1), "Mazo (robar)", "Pulsa aquí para robar una carta y añadirla a tu mano.");

                // imagen del cementerio
                Image imgCementerio = null;
                try { imgCementerio = Properties.Resources.cartaCementerio; } catch { }
                AddIllustration(imgCementerio ?? new Bitmap(1, 1), "Cementerio (descartar)", "Arrastra cartas aquí para descartarlas. Ojo: si descartas una carta que era correcta para el escenario, recibirás una penalización según el nivel.");

                // ejemplo de carta (extintor)
                Image imgCarta = null;
                try { imgCarta = Properties.Resources.extintor; } catch { }
                AddIllustration(imgCarta ?? new Bitmap(1, 1), "Carta ejemplo", "Cada carta representa una acción. Usa el panel de información para ver el nombre y detalles antes de colocarla.");
            }
            catch { }
        }
    }
}
