using System.Linq;

namespace AlberSoft
{
    // Versión simplificada y comentada para principiantes de C# (en español).
    // Propósito: que cualquier persona con conocimientos básicos de `if` pueda leer y modificar este formulario.

    public partial class fmPrimerosAuxilios : Form
    {
        #region CONSTRUCTOR
        #region Inicialización
        // Qué: este método se ejecuta cuando creas una nueva ventana de Primeros Auxilios.
        // Por qué: InitializeComponent() carga todos los controles (botones, imágenes, etiquetas) creados en el diseñador.
        // Cómo usar: no borres InitializeComponent(); si lo quitas el formulario no tendrá controles.
        public fmPrimerosAuxilios()
        {
            InitializeComponent();
        }
        #endregion
        #endregion

        #region EVENTOS DE CONTROLES
        #region Carga y paint
        // Evento que ocurre cuando el formulario carga
        // Qué: se ejecuta una vez, cuando el formulario aparece por primera vez.
        // Por qué: aquí puedes preparar datos, cargar imágenes o iniciar timers.
        // Cómo usar: añade código dentro para ejecutar acciones al iniciar.
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
        // Click en etiquetas (ejemplos vacíos)
        private void label1_Click_1(object sender, EventArgs e)
        {
            // Ejemplo: MessageBox.Show("Has pulsado la etiqueta 1");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Ejemplo: otra acción al pulsar etiqueta
        }

        private void infoC_Click(object sender, EventArgs e)
        {
            // Ejemplo: mostrar detalles adicionales
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
        #endregion

        #region NAVEGACIÓN Y CIERRE
        #region Botón volver
        // Botón "volver" (imagen back) — mostrar el menú principal y cerrar este formulario
        // Qué: este método busca si ya está abierta la ventana principal y la muestra; si no, crea una nueva.
        // Por qué: evitar crear múltiples instancias del menú principal y regresar a la pantalla anterior.
        // Cómo usar: el diseñador asocia este método al evento Click del PictureBox `back`.
        private void back_Click(object sender, EventArgs e)
        {
            // 1) Buscar en la colección de ventanas abiertas si ya existe una de tipo fmMenu
            var menuExistente = Application.OpenForms.OfType<fmMenu>().FirstOrDefault();

            // 2) Si no existe, crear una nueva instancia del menú principal
            if (menuExistente == null)
            {
                menuExistente = new fmMenu();
            }

            // 3) Mostrar el menú (si ya estaba abierto lo traemos al frente)
            menuExistente.Show();

            // 4) Cerrar este formulario actual para volver al menú
            Close();
        }
        #endregion
        #endregion

        #region NOTAS
        // Nota para principiantes: este archivo contiene la lógica del formulario; los controles visuales y los nombres
        // (como `pictureBox`, `tituloA`, `cuiButton1`) están definidos en el archivo `fmPrimerosAuxilios.Designer.cs`.
        // Si necesitas cambiar nombres visibles, edita el diseñador o usa propiedades públicas para exponer valores.
        #endregion
    }
}
