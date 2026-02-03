using AlberSoft.activadesRecreativas.Cocina_Comunitaria;
using AlberSoft.actividadesRecreativas.TallerDeReciclaje;

namespace AlberSoft.actividadesRecreativas
{
    public partial class fmTallerReciclaje : Form
    {
        public fmTallerReciclaje()
        {
            InitializeComponent();
        }

        #region Funciones para los botones
        // Manejador para el botón llamado "receta1" en el diseñador

        #endregion

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

        #region Cargar por defecto un formulario dentro de un panel
        private void CargarFormularioPorDefecto_Load(object sender, EventArgs e)
        {
            try
            {
                abrirFormularioHijo(new fmLogoTaller());
            }
            catch { }
        }
        #endregion

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
        #endregion

        private void btnReferencias_Click(object sender, EventArgs e)
        {
            Form referenciasForm = new fmReferenciasTachosReciclaje();
            referenciasForm.Show();
        }

        #region Funciones para los botones
        private void btnSemilleros_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmManualidad1());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnConejo_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmManualidad2());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnFamilia_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmManualidad3());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnCohete_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmManualidad4());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        #endregion
    }
}
