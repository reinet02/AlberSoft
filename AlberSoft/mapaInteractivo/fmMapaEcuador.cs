using System;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AlberSoft.mapaInteractivo
{
    public partial class fmMapaEcuador : Form
    {
        public fmMapaEcuador()
        {
            InitializeComponent();
            // Iniciar la carga del mapa de forma asíncrona.
            _ = InicializarYMostrarMapaAsync();
        }

        #region Función para regresar (mostar a otro formulario)
        // Botón "volver" — cerrar este formulario y mostrar otro
        private void regresar_Click(object sender, EventArgs e)
        {
            // Si este formulario está embebido dentro de un Panel (por ejemplo panel2 en fmMenu),
            // reemplazamos su contenido por el formulario fmBienvenida
            var parentPanel = this.Parent as Panel;
            try
            {
                parentPanel.Controls.Clear();

                var bienvenida = new menuPrincipal.fmBienvenida();
                bienvenida.TopLevel = false;
                bienvenida.FormBorderStyle = FormBorderStyle.None;
                bienvenida.Dock = DockStyle.Fill;

                parentPanel.Controls.Add(bienvenida);
                bienvenida.Show();
            }
            catch
            {
                // Fallback: abrir como ventana independiente
                var bienvenida = new menuPrincipal.fmBienvenida();
                bienvenida.Show();
            }

        }

        private void tableroGeneralTab1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiLabel2_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private async Task InicializarYMostrarMapaAsync()
        {
            try
            {
                await vistaWeb.EnsureCoreWebView2Async();
                // Registrar el handler para recibir mensajes desde JavaScript
                vistaWeb.CoreWebView2.WebMessageReceived += ManejarMensajeWeb;

                // Construir la ruta conocida en la carpeta de salida donde siempre colocas los archivos
                var carpetaSalida = Path.Combine(AppContext.BaseDirectory, "mapaInteractivo");
                var htmlPath = Path.Combine(carpetaSalida, "map.html");
                if (!File.Exists(htmlPath))
                {
                    MessageBox.Show($"No se encuentra map.html en: {htmlPath}\n" +
                                    "Asegúrate de marcar map.html como Content y Copy to Output Directory = Always.",
                                    "Archivo faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Navegar al archivo HTML local (usamos file:// URI)
                vistaWeb.CoreWebView2.Navigate(new Uri(htmlPath).AbsoluteUri);

                // Registrar un handler con nombre para cuando la navegación termine.
                // Usamos un método separado (más sencillo de leer que una lambda larga).
                vistaWeb.CoreWebView2.NavigationCompleted += ManejarNavegacionCompletadaAsync;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inicializando WebView2: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Handler separado para NavigationCompleted. Es async porque ejecuta un script en la página.
        private async void ManejarNavegacionCompletadaAsync(object? sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            try
            {
                // Buscar el SVG en la carpeta fija mapaInteractivo dentro de la salida
                var carpetaSalida = Path.Combine(AppContext.BaseDirectory, "mapaInteractivo");
                var svgPath = Path.Combine(carpetaSalida, "mapaEcuador.svg");
                if (File.Exists(svgPath))
                {
                    // Leer el SVG como texto y pasarlo al HTML usando una función JS llamada receiveSvg
                    var svgText = File.ReadAllText(svgPath);
                    var json = JsonSerializer.Serialize(svgText);
                    // Llamar a la función expuesta en el HTML
                    await vistaWeb.CoreWebView2.ExecuteScriptAsync($"window.recibirSvg({json});");
                }
                else
                {
                    Debug.WriteLine($"No se encontró mapaEcuador.svg en: {svgPath}. Revisar propiedades de archivo.");
                }
            }
            catch (Exception ex)
            {
                // No detendremos la aplicación por este error; lo registramos para depuración
                Debug.WriteLine("Error al enviar SVG al WebView2: " + ex.Message);
            }
        }


        // Clase para deserializar mensajes simples desde JavaScript.
        // Usamos los nombres originales que envía JS: name, screenX, screenY
        private class MensajeDesdeJs
        {
            // ? indica que su valor será null si no se proporciona un valor específico
            [JsonPropertyName("name")]
            public string? nombre { get; set; }

            [JsonPropertyName("screenX")]
            public int pantallaX { get; set; } = -1;

            [JsonPropertyName("screenY")]
            public int pantallaY { get; set; } = -1;
        }

        #region Comunicación de JS con C#
        private void ManejarMensajeWeb(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            string raw = e.TryGetWebMessageAsString();

            // Intentar deserializar un objeto simple { name, screenX, screenY }
            string nombre = raw;
            int pantallaX = -1, pantallaY = -1;
            try
            {
                if (!string.IsNullOrWhiteSpace(raw) && raw.TrimStart().StartsWith("{"))
                {
                    var msg = JsonSerializer.Deserialize<MensajeDesdeJs>(raw);
                    if (msg != null)
                    {
                        nombre = msg.nombre ?? nombre;
                        pantallaX = msg.pantallaX;
                        pantallaY = msg.pantallaY;
                    }
                }
            }
            catch (Exception ex)
            {
                // Registrar el error simple para depuración.
                Debug.WriteLine("Error al parsear mensaje JSON desde JS: " + ex.Message);
            }

            try
            {
                // Usar el nombre tal cual (preservando tildes), solo quitar espacios/guiones/guiones bajos
                var nombreFormulario = (nombre ?? "").Trim();
                nombreFormulario = nombreFormulario.Replace(" ", "").Replace("-", "").Replace("_", "");
                var nombreTipo = typeof(fmMapaEcuador).Namespace + ".fm" + nombreFormulario;
                var ensamblado = typeof(fmMapaEcuador).Assembly;
                var tipo = ensamblado.GetType(nombreTipo);
                if (tipo != null && typeof(Form).IsAssignableFrom(tipo))
                {
                    var formulario = Activator.CreateInstance(tipo) as Form;
                    if (formulario != null)
                    {
                        if (pantallaX >= 0 && pantallaY >= 0)
                        {
                            formulario.StartPosition = FormStartPosition.Manual;
                            formulario.Location = new System.Drawing.Point(pantallaX, Math.Max(0, pantallaY - formulario.Height - 10));
                            formulario.Show(this);
                        }
                        else formulario.ShowDialog(this);
                        return;
                    }
                }

                MessageBox.Show($"No existe un formulario específico para la provincia: {nombre}", "Formulario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir el formulario de la provincia: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Limpieza
        // Dispose se gestiona en el archivo Designer parcial; si necesitas limpiar webView extra, puedes hacerlo aquí.
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            if (vistaWeb?.CoreWebView2 != null)
            {
                // Quitar los handlers registrados anteriormente
                vistaWeb.CoreWebView2.WebMessageReceived -= ManejarMensajeWeb;
                vistaWeb.CoreWebView2.NavigationCompleted -= ManejarNavegacionCompletadaAsync;
            }
            base.OnFormClosed(e);
        }
        #endregion
    }
}

