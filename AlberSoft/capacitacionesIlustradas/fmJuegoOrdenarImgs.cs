using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlberSoft.capacitacionesIlustradas
{
    public partial class fmJuegoOrdenarImgs : Form
    {
        // Diccionario con el orden correcto por escenario (claves de recursos)
        private readonly Dictionary<string, string[]> ordenCorrecta = new Dictionary<string, string[]>
        {
            // Escenario "ABCDE": 5 imágenes que se deben ordenar A -> B -> C -> D -> E
            { "ABCDE", new[] { "primerosAuxiliosA", "primerosAuxiliosB", "primerosAuxiliosC", "primerosAuxiliosD", "primerosAuxiliosE" } }
        };

        // Variables en español
        private string escenarioActual = null;
        private int puntuacion = 0;
        private readonly Random generador = new Random();

        // --- Nuevas variables para dificultad y temporizador ---
        private System.Windows.Forms.Timer gameTimer;
        private int tiempoRestante;
        private readonly Dictionary<string, int> tiemposPorDificultad = new Dictionary<string, int>
        {
            { "Fácil", 120 },
            { "Medio", 60 },
            { "Difícil", 30 }
        };
        // -------------------------------------------------------

        public fmJuegoOrdenarImgs()
        {
            InitializeComponent();
            InicializarEscenarios();
            InicializarDificultadYTemporizador();
        }

        // Inicializa la lista de escenarios y prepara el primero
        private void InicializarEscenarios()
        {
            try
            {
                // Si el control cbEscenario (personalizado) permite asignar Items como array
                cbEscenario.Items = ordenCorrecta.Keys.ToArray();
            }
            catch
            {
                // Si falla, puede que el control personalizado gestione los ítems en el Diseñador;
                // no es crítico en este punto.
            }

            escenarioActual = ordenCorrecta.Keys.First();
            PrepararEscenario(escenarioActual);
        }

        // Inicializa UI y temporizador de dificultad
        private void InicializarDificultadYTemporizador()
        {
            try
            {
                // llenar combo de dificultad (si existe)
                cbDificultad.Items.Clear();
                cbDificultad.Items.AddRange(new object[] { "Fácil", "Medio", "Difícil" });
                cbDificultad.SelectedIndex = 1; // por defecto Medio
            }
            catch
            {
                // Si el control no existe o es personalizado, evitar fallo silencioso
            }

            gameTimer = new System.Windows.Forms.Timer { Interval = 1000 };
            gameTimer.Tick += GameTimer_Tick;

            // Mostrar tiempo inicial
            ActualizarLabelTiempoPreview();
        }

        private void cbEscenario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEscenario.SelectedItem == null) return;
            escenarioActual = cbEscenario.SelectedItem.ToString();
            PrepararEscenario(escenarioActual);
        }

        private void cbDificultad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarLabelTiempoPreview();
        }

        private void ActualizarLabelTiempoPreview()
        {
            if (lblTiempo == null) return;
            var clave = cbDificultad?.SelectedItem as string ?? "Medio";
            if (!tiemposPorDificultad.TryGetValue(clave, out var t)) t = 60;
            lblTiempo.Text = $"Tiempo: {t}s";
        }

        // Crear los huecos (targets) y llenar la pool con las imágenes mezcladas
        private void PrepararEscenario(string escenario)
        {
            lblMensaje.Text = $"Escenario: {escenario}";
            tlpTargets.Controls.Clear();

            var claves = ordenCorrecta[escenario];
            int n = claves.Length;

            // Configurar columnas del TableLayoutPanel
            tlpTargets.ColumnStyles.Clear();
            tlpTargets.RowStyles.Clear();
            tlpTargets.ColumnCount = n;
            tlpTargets.RowCount = 1;
            for (int i = 0; i < n; i++)
                tlpTargets.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / n));
            tlpTargets.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            for (int i = 0; i < n; i++)
            {
                var pb = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = SystemColors.ControlLight,
                    Tag = null // vacío hasta que se coloque una imagen
                };
                pb.Click += Hueco_Click;
                tlpTargets.Controls.Add(pb, i, 0);
            }

            CargarPoolConEscenario(escenario);
        }

        // Carga las imágenes desde Resources y las mezcla en flpPool
        private void CargarPoolConEscenario(string escenario)
        {
            flpPool.Controls.Clear();
            var claves = ordenCorrecta[escenario];

            var items = claves.Select(k => new { Clave = k, Imagen = IntentarCargarImagenRecurso(k) }).ToList();
            items = items.OrderBy(x => generador.Next()).ToList();

            foreach (var item in items)
            {
                var pb = new PictureBox
                {
                    Width = 120,
                    Height = 90,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = item.Imagen ?? ImagenPlaceholder(),
                    Tag = item.Clave,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(6)
                };
                pb.Click += ImagenPool_Click;
                flpPool.Controls.Add(pb);
            }
        }

        // Intenta cargar la imagen desde Properties.Resources por nombre
        private Image IntentarCargarImagenRecurso(string nombreRecurso)
        {
            try
            {
                var obj = Properties.Resources.ResourceManager.GetObject(nombreRecurso);
                return obj as Image;
            }
            catch
            {
                return null;
            }
        }

        // Imagen placeholder cuando falta el recurso
        private Image ImagenPlaceholder()
        {
            Bitmap bmp = new Bitmap(120, 90);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                using (var f = new Font("Segoe UI", 9))
                using (var sb = new SolidBrush(Color.Black))
                {
                    g.DrawString("Imagen\nno\nen Resources", f, sb, new RectangleF(4, 4, 112, 82));
                }
            }
            return bmp;
        }

        // Clic en miniatura de la pool: coloca en el primer hueco vacío
        private void ImagenPool_Click(object sender, EventArgs e)
        {
            var pbPool = sender as PictureBox;
            if (pbPool == null) return;

            PictureBox primerHueco = null;
            foreach (Control c in tlpTargets.Controls)
            {
                if (c is PictureBox t && t.Tag == null)
                {
                    primerHueco = t;
                    break;
                }
            }

            if (primerHueco == null)
            {
                lblMensaje.Text = "No hay huecos vacíos. Devuelve alguna imagen al pool antes.";
                return;
            }

            primerHueco.Image = pbPool.Image;
            primerHueco.Tag = pbPool.Tag;

            flpPool.Controls.Remove(pbPool);
            pbPool.Click -= ImagenPool_Click;
            pbPool.Dispose();

            lblMensaje.Text = "Imagen colocada. Sigue completando los pasos.";
        }

        // Clic en hueco: devuelve su imagen a la pool
        private void Hueco_Click(object sender, EventArgs e)
        {
            var pbHueco = sender as PictureBox;
            if (pbHueco == null) return;
            if (pbHueco.Tag == null) return;

            var clave = pbHueco.Tag as string;
            var img = pbHueco.Image;

            pbHueco.Image = null;
            pbHueco.Tag = null;
            pbHueco.BackColor = SystemColors.ControlLight;

            var nuevoPb = new PictureBox
            {
                Width = 120,
                Height = 90,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = img,
                Tag = clave,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(6)
            };
            nuevoPb.Click += ImagenPool_Click;
            flpPool.Controls.Add(nuevoPb);

            lblMensaje.Text = "Imagen devuelta a la pool.";
        }

        private void btnMezclar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(escenarioActual))
            {
                lblMensaje.Text = "Selecciona un escenario primero.";
                return;
            }
            PrepararEscenario(escenarioActual);
            lblMensaje.Text = "Imágenes mezcladas. Clic en una imagen para colocarla.";

            // Reiniciar contador y arrancar temporizador según dificultad seleccionada
            IniciarTemporizadorSegunDificultad();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(escenarioActual))
            {
                lblMensaje.Text = "Selecciona un escenario primero.";
                return;
            }

            var esperado = ordenCorrecta[escenarioActual];
            bool todasColocadas = true;
            bool correcto = true;
            int indice = 0;
            foreach (Control c in tlpTargets.Controls)
            {
                var pb = c as PictureBox;
                var tag = pb?.Tag as string;
                if (string.IsNullOrEmpty(tag))
                {
                    todasColocadas = false;
                    correcto = false;
                }
                else
                {
                    if (indice < esperado.Length && tag != esperado[indice])
                        correcto = false;
                }
                indice++;
            }

            if (!todasColocadas)
            {
                lblMensaje.Text = "Coloca todas las imágenes antes de comprobar.";
                return;
            }

            if (correcto)
            {
                puntuacion++;
                lblPuntuacion.Text = $"Puntuación: {puntuacion}";
                lblMensaje.Text = "¡Correcto! Has ordenado bien los pasos.";
                foreach (Control c in tlpTargets.Controls)
                {
                    if (c is PictureBox pb) pb.BackColor = Color.LightGreen;
                }
                // Detener temporizador al ganar
                DetenerTemporizador();
            }
            else
            {
                lblMensaje.Text = "Orden incorrecto. Intenta de nuevo.";
                foreach (Control c in tlpTargets.Controls)
                {
                    if (c is PictureBox pb) pb.BackColor = Color.MistyRose;
                }
            }
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(escenarioActual))
                return;
            puntuacion = 0;
            lblPuntuacion.Text = $"Puntuación: {puntuacion}";
            PrepararEscenario(escenarioActual);
            lblMensaje.Text = "Reiniciado.";

            DetenerTemporizador();
            ActualizarLabelTiempoPreview();
        }

        // Temporizador: tick cada segundo
        private void GameTimer_Tick(object? sender, EventArgs e)
        {
            tiempoRestante--;
            lblTiempo.Text = $"Tiempo: {tiempoRestante}s";

            if (tiempoRestante <= 0)
            {
                DetenerTemporizador();
                // Deshabilitar interacción
                tlpTargets.Enabled = false;
                flpPool.Enabled = false;

                MessageBox.Show("Se acabó el tiempo.", "Fin de la partida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void IniciarTemporizadorSegunDificultad()
        {
            var clave = cbDificultad?.SelectedItem as string ?? "Medio";
            if (!tiemposPorDificultad.TryGetValue(clave, out var t)) t = 60;
            tiempoRestante = t;
            lblTiempo.Text = $"Tiempo: {tiempoRestante}s";

            // Habilitar interacción y arrancar
            tlpTargets.Enabled = true;
            flpPool.Enabled = true;

            gameTimer?.Start();
        }

        private void DetenerTemporizador()
        {
            gameTimer?.Stop();
        }
    }
}


