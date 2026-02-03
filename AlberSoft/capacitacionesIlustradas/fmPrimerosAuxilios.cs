using AlberSoft.capacitacionesIlustradas;
using AlberSoft.menuPrincipal;
using System.Linq;

namespace AlberSoft
{
    // Versión simplificada y comentada para principiantes de C# (en español).
    // Propósito: que cualquier persona con conocimientos básicos de `if` pueda leer y modificar este formulario.

    public partial class fmPrimerosAuxilios : Form
    {

        public fmPrimerosAuxilios()
        {
            InitializeComponent();
        }

        #region Carga y paint
        // Evento que ocurre cuando el formulario carga
        private void primerosAuxilios_Load(object sender, EventArgs e)
        {
            // Ejemplo: cargar datos o inicializar componentes
        }

        // Evento Paint del TableLayoutPanel (puede quedar vacío)
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // No es necesario modificar para la funcionalidad básica
        }
        #endregion

        #region Clicks y botones

        private void label4_Click(object sender, EventArgs e)
        {
            // Ejemplo: otra acción al pulsar etiqueta
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            // Ejemplo: abrir otro formulario con más información
        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {
            // Inicializar etiqueta personalizada si lo necesitas
        }

        private void tituloD_Click(object sender, EventArgs e)
        {
            // Acciones que quieras al pulsar titulo D
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
            Form referenciasForm = new fmReferenciasPrimerosAuxilios();
            referenciasForm.Show();
        }
        
    }
}

