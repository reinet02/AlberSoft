using AlberSoft.actividadesRecreativas.JuegoDePares;
using System;
using System.Windows.Forms;

namespace AlberSoft.activadesRecreativas
{
    public partial class fmNivelesDificultad : Form
    {
        // Progreso en memoria: otros formularios pueden marcar niveles como completados
        public static bool NivelFacilCompletado { get; private set; } = false;
        public static bool NivelIntermedioCompletado { get; private set; } = false;

        // Método público para que otros formularios marquen un nivel como completado
        public static void MarcarNivelCompletado(string nivel)
        {
            if (string.IsNullOrWhiteSpace(nivel)) return;
            switch (nivel.Trim().ToLowerInvariant())
            {
                case "fácil":
                case "facil":
                    NivelFacilCompletado = true;
                    break;
                case "intermedio":
                    NivelIntermedioCompletado = true;
                    break;
            }
        }

        public fmNivelesDificultad()
        {
            InitializeComponent();
            // Registrar manejador para cambiar de formulario según la selección de nivel
            try
            {
                seleccionadorDeNivel.SelectedIndexChanged += seleccionadorDeNivel_SelectedIndexChanged;
            }
            catch
            {
                // Ignorar si el control no está disponible en tiempo de diseño
            }
        }

        #region Cargar por defecto un formulario en el panel de contenido

        private void fmNivelesDeDificultad_Load(object sender, EventArgs e)
        {
            try
            {
                abrirFormularioHijo(new fmIntruccionesPares());
            }
            catch { }
        }
        #endregion

        // Al cambiar la selección del combo, cargamos el formulario asociado
        private void seleccionadorDeNivel_SelectedIndexChanged(object? sender, EventArgs e)
        {
            try
            {
                // Usar el texto seleccionado en lugar del índice, porque el combo puede ordenar
                var seleccionado = seleccionadorDeNivel?.SelectedItem?.ToString() ?? string.Empty;

                switch (seleccionado)
                {
                    case "Fácil":
                        abrirFormularioHijo(new fmJuegoDeParesReciclaje()); // asigna el formulario que corresponda a "Fácil"
                        break;
                    case "Intermedio": // validar que se completó el fácil
                        if (!NivelFacilCompletado)
                        {
                            MessageBox.Show("Debes completar el nivel Fácil antes de acceder a Intermedio.", "Nivel bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            abrirFormularioHijo(new fmJuegoDeParesCocina());
                        }
                        break;
                    case "Difícil": // validar que se completó el intermedio
                        if (!NivelIntermedioCompletado)
                        {
                            MessageBox.Show("Debes completar el nivel Intermedio antes de acceder a Difícil.", "Nivel bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            abrirFormularioHijo(new fmJuegoDeParesHuerto());
                        }
                        break;
                    default:
                        // Si no hay selección válida, mostrar logo por defecto
                        abrirFormularioHijo(new fmLogoJuegoDePares());
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar el formulario seleccionado.");
            }
        }

        #region Función para cargar un formulario dentro de un panel
        // Carga un formulario dentro del panel "panel2"
        private void abrirFormularioHijo(Form frm)
        {
            try
            {
                // Limpiar controles existentes en el panel
                this.panel1.Controls.Clear();

                // Preparar el formulario para mostrarse embebido
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                // Añadir y mostrar
                this.panel1.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception)
            {
                // En caso de error, mostrar mensaje simple (se puede mejorar)
                MessageBox.Show("No se pudo cargar el formulario.");
            }
        }
        #endregion


        private void btnintrucionespares_Click(object sender, EventArgs e)
        {
            try
            {
                abrirFormularioHijo(new fmIntruccionesPares());
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abrir las instrucciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
