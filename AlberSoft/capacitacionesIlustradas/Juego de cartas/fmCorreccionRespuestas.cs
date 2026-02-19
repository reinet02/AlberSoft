using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AlberSoft.capacitacionesIlustradas
{
    public partial class fmCorreccionRespuestas : Form
    {
        private readonly List<(string titulo, bool correcto)> resultados;
        private readonly fmJuegoCartasEmergencias padre;
        // permite que el padre marque este formulario como "vida agotada"
        public void MarcarComoVidaAgotada()
        {
            try
            {
                lblResultado.Content = "GAME OVER";
                lblResultado.ForeColor = Color.FromArgb(180, 0, 0);

                // Mostrar imagen de muerte en el panel de resultados
                try
                {
                    listViewResultados.Controls.Clear();

                    // PictureBox con la imagen de la muerte
                    var pbMuerte = new PictureBox()
                    {
                        Dock = DockStyle.Fill,
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Image = Properties.Resources.muerte,
                        BackColor = Color.Transparent
                    };

                    // Botón para ver las correcciones; al pulsarlo reemplaza la imagen por la lista
                    var btnVerCorrecciones = new Button()
                    {
                        Text = "Ver correcciones",
                        Dock = DockStyle.Bottom,
                        Height = 48,
                        Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                        BackColor = Color.White,
                        ForeColor = Color.Black
                    };

                    btnVerCorrecciones.Click += (s, e) =>
                    {
                        try
                        {
                            // Mostrar la lista de correcciones en lugar de la imagen
                            listViewResultados.Controls.Clear();
                            CargarResultados();
                        }
                        catch { }
                    };

                    listViewResultados.Controls.Add(pbMuerte);
                    listViewResultados.Controls.Add(btnVerCorrecciones);
                }
                catch { }
            }
            catch { }
        }

        // esPorVidaAgotada: cuando true indica que el formulario se abre porque la vida llegó a 0
        public fmCorreccionRespuestas(List<(string titulo, bool correcto)> resultados, fmJuegoCartasEmergencias padre, bool esPorVidaAgotada = false)
        {
            this.resultados = resultados ?? new List<(string, bool)>();
            this.padre = padre;
            InitializeComponent();
            // Detener temporizador del juego padre para cálculo de tiempo usado
            try { padre?.PararTemporizador(); } catch { }

            // Si el padre ya tiene 0 puntos de vida al crear este formulario,
            // mostrar inmediatamente el estado GAME OVER.
            try
            {
                if (padre != null && padre.ObtenerPuntosVida() == 0)
                {
                    try { MarcarComoVidaAgotada(); } catch { }
                }
            }
            catch { }

            // Mostrar tiempo usado: "Tiempo: {usado} de {total}"
            // esVictoria se declara aquí para que esté disponible después del bloque try
            bool esVictoria = false;
            try
            {
                int restantes = padre?.ObtenerSegundosRestantes() ?? 0;
                int total = padre?.ObtenerDuracionNivelInicial() ?? 0;
                int usados = Math.Max(0, total - restantes);

                string FormatoMmSs(int s)
                {
                    int m = s / 60;
                    int sec = s % 60;
                    return $"{m:D2}:{sec:D2}";
                }

                // Mostrar segundos y mm:ss para mayor claridad
                lblTiempoUsado.Content = $"Tiempo: {usados} seg ({FormatoMmSs(usados)}) de {total} seg ({FormatoMmSs(total)})";

                try
                {
                    var rec = Juego_de_cartas.RecordsManager.GetRecord(padre?.NivelSeleccionado ?? 0);
                    if (rec.HasValue)
                        lblRecord.Content = $"Récord: {rec.Value} seg ({FormatoMmSs(rec.Value)})";
                    else
                        lblRecord.Content = "Récord: -";
                }
                catch { lblRecord.Content = "Récord: -"; }

                // Determinar resultado: victoria solo si el usuario colocó TODAS las cartas correctas
                // Si este formulario se abrió por agotamiento de vida, forzamos derrota y
                // evitamos la comprobación normal.
                try
                {
                    if (esPorVidaAgotada)
                    {
                        esVictoria = false;
                    }
                    else
                    {
                        var requeridas = padre?.ObtenerNombresCorrectosActual() ?? new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                        if (requeridas.Count > 0)
                        {
                            esVictoria = requeridas.All(req => resultados.Any(r => r.correcto && string.Equals(r.titulo?.Trim(), req?.Trim(), StringComparison.OrdinalIgnoreCase)));
                        }
                        else
                        {
                            // si no hay requeridas definidas, caer atrás a la comprobación previa
                            esVictoria = resultados != null && resultados.Count > 0 && resultados.All(r => r.correcto);
                        }
                    }
                }
                catch { esVictoria = false; }

                if (esVictoria)
                {
                    // calcular tiempo usado (ya calculado anteriormente en 'usados') y actualizar récord si aplica
                    // la variable 'usados' fue calculada arriba
                    bool nuevoRecord = false;
                    try
                    {
                        nuevoRecord = Juego_de_cartas.RecordsManager.UpdateRecordIfBetter(padre?.NivelSeleccionado ?? 0, usados);
                    }
                    catch { nuevoRecord = false; }

                    if (nuevoRecord)
                    {
                        lblResultado.Content = $"¡Ganaste! Nuevo récord: {usados} seg ({FormatoMmSs(usados)})";
                    }
                    else
                    {
                        lblResultado.Content = "¡Ganaste!";
                    }
                    lblResultado.ForeColor = Color.FromArgb(0, 120, 0);
                }
                else
                {
                    if (esPorVidaAgotada)
                    {
                        // Mostrar mensaje claro de fin de juego y presentar un PictureBox
                        // con la imagen de la muerte (Resources.muerte).
                        lblResultado.Content = "GAME OVER";
                        lblResultado.ForeColor = Color.FromArgb(180, 0, 0);

                        try
                        {
                            // limpiar el panel de resultados y colocar una imagen grande
                            listViewResultados.Controls.Clear();
                            var pbMuerte = new PictureBox()
                            {
                                Dock = DockStyle.Fill,
                                SizeMode = PictureBoxSizeMode.Zoom,
                                Image = Properties.Resources.muerte,
                                BackColor = Color.Transparent
                            };
                            listViewResultados.Controls.Add(pbMuerte);
                        }
                        catch { }
                    }
                    else
                    {
                        // Construir mensaje contextual indicando en qué escenario se perdió
                        string escenario = "";
                        try { escenario = padre?.ObtenerNombreEscenarioActual() ?? ""; } catch { }
                        if (!string.IsNullOrWhiteSpace(escenario))
                            lblResultado.Content = $"Perdiste en el escenario: {escenario}";
                        else
                            lblResultado.Content = "Perdiste :(";

                        lblResultado.ForeColor = Color.FromArgb(180, 0, 0);

                        // Restar puntos de vida al jugador según el nivel (fácil=0, intermedio=1, difícil=2)
                        try
                        {
                            if (padre != null)
                            {
                                // Penalizaciones más balanceadas para un total de 100 puntos de vida
                                int deduccion = padre.NivelSeleccionado switch
                                {
                                    0 => 10, // fácil
                                    1 => 20, // intermedio
                                    2 => 30, // difícil (reducción desde 50 a 30 para equilibrio)
                                    _ => 10
                                };

                                // Construir una razón legible: indicar cuántas cartas faltaron o cuántas fueron incorrectas
                                string razon = "No colocaste todas las cartas correctas.";
                                try
                                {
                                    var requeridas = padre?.ObtenerNombresCorrectosActual() ?? new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                                    if (requeridas.Count > 0)
                                    {
                                        int matched = requeridas.Count(req => resultados.Any(r => r.correcto && string.Equals(r.titulo?.Trim(), req?.Trim(), StringComparison.OrdinalIgnoreCase)));
                                        int missing = Math.Max(0, requeridas.Count - matched);
                                        razon = missing == 1 ? "Falta 1 carta correcta." : $"Faltan {missing} cartas correctas.";
                                    }
                                    else
                                    {
                                        int incorrectas = resultados.Count(r => !r.correcto);
                                        razon = incorrectas == 1 ? "1 carta incorrecta." : $"{incorrectas} cartas incorrectas.";
                                    }
                                }
                                catch { }

                                // Mostrar en la pestaña "Resumen" la cantidad de vida perdida y la razón
                                try
                                {
                                    lblVidaPerdida.Content = $"-{deduccion} puntos. Razón: {razon}";
                                    lblVidaPerdida.ForeColor = Color.FromArgb(180, 0, 0);
                                }
                                catch { }

                                // Restar vida al padre sin mostrar el mensaje temporal en la UI del juego
                                // (el texto temporal en `labelPuntosPerdidos` sólo debe mostrarse
                                // cuando el usuario arrastre una carta correcta al cementerio)
                                try { padre.RestarPuntosVida(deduccion); } catch { }
                            }
                        }
                        catch { }
                    }
                }
            }
            catch { lblTiempoUsado.Content = "Tiempo: -"; lblRecord.Content = "Récord: -"; }

            // Mostrar el botón "Siguiente escenario" solo si el usuario ganó el escenario.
            try
            {
                btnSiguiente.Visible = esVictoria;
                btnSiguiente.Enabled = esVictoria;
            }
            catch { }

            CargarResultados();
        }

        private void CargarResultados()
        {
            // limpiar panel
            listViewResultados.Controls.Clear();

            int y = 6;
            foreach (var r in resultados)
            {
                string prefix = r.correcto ? "✅ " : "❌ ";
                var lbl = new CuoreUI.Controls.cuiLabel
                {
                    Content = prefix + r.titulo,
                    Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                    ForeColor = r.correcto ? Color.FromArgb(0, 100, 0) : Color.FromArgb(139, 0, 0),
                    Location = new Point(6, y),
                    AutoSize = true
                };
                listViewResultados.Controls.Add(lbl);
                y += lbl.Height + 8;
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            // pedir al padre avanzar escenario y actualizar pbEscenarios
            try { padre?.PararTemporizador(); } catch { }
            padre?.AvanzarASiguienteEscenario();
            this.Close();
        }

        private void btnJugarDeNuevo_Click(object sender, EventArgs e)
        {
            // Cerrar la ventana de corrección y reiniciar el juego desde el formulario padre
            try
            {
                // Si el jugador tiene 0 puntos de vida, al pulsar "Jugar de nuevo" debe recuperar 100
                try { if (padre != null && padre.ObtenerPuntosVida() == 0) padre.ResetearPuntosVida(); } catch { }

                // Reiniciar completamente el estado y empezar inmediatamente la partida
                padre?.ReiniciarJuego();
                padre?.IniciarJuego();
            }
            catch { }
            this.Close();
        }
    }
}
