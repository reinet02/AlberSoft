using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.Web.WebView2.Core;
using AlberSoft.capacitacionesIlustradas;

namespace AlberSoft
{
    public partial class fmCasosEmergencia : Form
    {
        private readonly List<(string clave, string titulo, string descripcion, Image imagen)> escenarios;
        private int indiceActual = 0;

        public fmCasosEmergencia()
        {
            InitializeComponent();

            escenarios = new List<(string, string, string, Image)>
            {
                ("incendio", "Incendio", "En caso de incendio: Mantén la calma, evacúa siguiendo rutas seguras, usa extintor solo si es seguro y avisa a servicios de emergencia.", Properties.Resources.incendio),
                ("inundacion", "Inundación", "En caso de inundación: busca zonas altas, evita el contacto con corriente de agua, corta electricidad si es seguro y protege documentos importantes.", Properties.Resources.inundacion),
                ("sismo", "Sismo", "En caso de sismo: agáchate, cubre y sujétate; aléjate de ventanas y objetos que puedan caer; después reunirse en puntos seguros.", Properties.Resources.sismo)
            };

            // Cargar datos visuales
            ActualizarVista();

            // Cargar el HTML externo en webViewCarrusel al mostrar el formulario
            Load += fmCasosEmergencia_Load;
        }

        private async void fmCasosEmergencia_Load(object? sender, EventArgs e)
        {
            if (webViewCarrusel == null) return;

            // Buscar carrusel.html en varias rutas posibles (output, base dir, carpetas relativas al proyecto)
            var candidates = new List<string>
            {
                Path.Combine(Application.StartupPath, "capacitacionesIlustradas", "webViewCarrusel", "carrusel.html"),
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "capacitacionesIlustradas", "webViewCarrusel", "carrusel.html"),
                Path.Combine(Directory.GetCurrentDirectory(), "capacitacionesIlustradas", "webViewCarrusel", "carrusel.html")
            };

            // Intentar también rutas relativas a la carpeta del ensamblado (útil al ejecutar desde IDE)
            try
            {
                var asmDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? string.Empty;
                candidates.Add(Path.Combine(asmDir, "..", "..", "capacitacionesIlustradas", "webViewCarrusel", "carrusel.html"));
                candidates.Add(Path.Combine(asmDir, "..", "capacitacionesIlustradas", "webViewCarrusel", "carrusel.html"));
            }
            catch { }

            string rutaLocal = null;
            try { rutaLocal = candidates.Select(p => Path.GetFullPath(p)).FirstOrDefault(File.Exists); } catch { }

            // Intentar inicializar WebView2 (no detener la app si falla, pero registrar para debug)
            try
            {
                await webViewCarrusel.EnsureCoreWebView2Async();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"EnsureCoreWebView2Async falló: {ex.Message}");
            }

            if (!string.IsNullOrEmpty(rutaLocal) && File.Exists(rutaLocal))
            {
                try
                {
                    var carpeta = Path.GetDirectoryName(rutaLocal) ?? Application.StartupPath;
                    try
                    {
                        // Preferir el mapping de carpeta para que los recursos locales (css/js/img) carguen con rutas relativas
                        webViewCarrusel.CoreWebView2.SetVirtualHostNameToFolderMapping("appassets", carpeta, CoreWebView2HostResourceAccessKind.Allow);
                        webViewCarrusel.CoreWebView2.Navigate("https://appassets/carrusel.html");
                    }
                    catch (Exception ex)
                    {
                        // Si falla el mapping, intentar navegar usando file:// (AbsoluteUri)
                        Console.WriteLine($"SetVirtualHostNameToFolderMapping falló: {ex.Message}");
                        try
                        {
                            if (webViewCarrusel.CoreWebView2 != null)
                                webViewCarrusel.CoreWebView2.Navigate(new Uri(rutaLocal).AbsoluteUri);
                            else
                                webViewCarrusel.Source = new Uri(rutaLocal);
                        }
                        catch (Exception ex2)
                        {
                            Console.WriteLine($"No se pudo navegar a carrusel.html: {ex2.Message}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error cargando carrusel.html: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("carrusel.html no encontrado. Rutas buscadas:\n" + string.Join("\n", candidates));
            }
        }

        private void ActualizarVista()
        {
            try
            {
                var e = escenarios[indiceActual];

                // Actualizar título del formulario
                try { this.Text = e.titulo; } catch { /* ignorar */ }

                // Construir texto combinado para mostrar en el control disponible `rtbDescripcion`
                var detalles = e.descripcion + "\n\n";

                if (e.clave == "incendio")
                {
                    detalles += "a) Evacuar de inmediato siguiendo rutas seguras\nTodo albergue debe tener rutas de evacuación predefinidas y señalizadas, y el personal debe conocerlas y aplicarlas sin demora.\n\n";
                    detalles += "b) Reunir a todas las personas en un punto seguro\nIdentificar un punto de reunión externo, alejado del edificio, y verificar que todas las personas estén presentes.\n\n";
                    detalles += "c) Mantener acceso a extintores y equipo básico\nLos equipos contra incendios deben estar operativos y el personal capacitado para usarlos.";
                }
                else if (e.clave == "inundacion")
                {
                    detalles += "a) Determinar si evacuar o refugiarse en el lugar\nEl personal debe saber cuándo evacuar según el nivel de amenaza y cuándo trasladar a las personas a pisos superiores si es más seguro permanecer.\n\n";
                    detalles += "b) Proteger áreas críticas y suministros\nElevar alimentos, medicinas y documentos; cortar energía si es seguro hacerlo.\n\n";
                    detalles += "c) Mantener agua potable y saneamiento seguro\nInundaciones incrementan el riesgo sanitario; garantizar agua segura y gestión correcta de residuos.";
                }
                else if (e.clave == "sismo")
                {
                    detalles += "a) Aplicar la regla 'agacharse, cubrirse y agarrarse'\nDurante el sismo, mantener a las personas alejadas de ventanas y objetos que puedan caer.\n\n";
                    detalles += "b) Evacuar solo después del movimiento\nMoverse a un área abierta y segura una vez que el sismo haya terminado, evitando zonas con cables, muros sueltos o estructuras colapsadas.\n\n";
                    detalles += "c) Revisar condiciones del albergue antes de reingresar\nEl personal debe evaluar daños estructurales visibles, riesgo eléctrico, fugas y estabilidad general antes de permitir el retorno.";
                }

                try
                {
                    // Asignar al control disponible (CuoreUI.Controls.cuiLabel tiene la propiedad Content)
                    rtbDescripcion.Content = detalles;
                }
                catch
                {
                    // Fallback: intentar asignar texto si existe la propiedad Text
                    try { rtbDescripcion.Text = detalles; } catch { }
                }

                // Si existe webViewCarrusel, no navegamos aquí (se hace en Load)
            }
            catch { }
        }

        private void btnPrev_Click(object? sender, EventArgs e)
        {
            if (escenarios.Count == 0) return;
            indiceActual = (indiceActual - 1 + escenarios.Count) % escenarios.Count;
            ActualizarVista();
        }

        private void btnNext_Click(object? sender, EventArgs e)
        {
            if (escenarios.Count == 0) return;
            indiceActual = (indiceActual + 1) % escenarios.Count;
            ActualizarVista();
        }

        // Reusar manejadores usados en otros formularios
        private void regresar_Click(object? sender, EventArgs e)
        {
            // Intentar volver al menú principal o cerrar
            try
            {
                var parentPanel = this.Parent as Panel;
                if (parentPanel != null)
                {
                    parentPanel.Controls.Clear();
                    var bienvenida = new menuPrincipal.fmBienvenida();
                    bienvenida.TopLevel = false;
                    bienvenida.FormBorderStyle = FormBorderStyle.None;
                    bienvenida.Dock = DockStyle.Fill;
                    parentPanel.Controls.Add(bienvenida);
                    bienvenida.Show();
                    return;
                }
            }
            catch { }

            try { this.Close(); } catch { }
        }

        private void btnReferencias_Click(object? sender, EventArgs e)
        {
            try
            {
                Form referenciasForm = new fmReferenciasPrimerosAuxilios();
                referenciasForm.Show();
            }
            catch { }
        }
    }
}
