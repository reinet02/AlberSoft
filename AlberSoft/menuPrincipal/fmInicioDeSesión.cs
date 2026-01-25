namespace AlberSoft
{
    public partial class fmInicioDeSesión : Form
    {
        #region Inicialización
        // Qué: Este método se ejecuta cuando creas la ventana de registro (login).
        // Por qué: InitializeComponent() carga los controles (botones, cajas de texto, etiquetas) creados en el diseñador.
        // Cómo: No eliminar InitializeComponent(); si lo quitas, los controles no existirán y el formulario fallará.
        public fmInicioDeSesión()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos de carga
        // Evento que ocurre cuando el formulario se carga por primera vez
        // Qué: ejecutar acciones iniciales (inicializar variables, cargar datos)
        // Por qué: preparar la ventana antes de que el usuario interactúe
        // Cómo: escribe aquí el código que quieras ejecutar al iniciar
        private void AlCargarFormulario(object sender, EventArgs e)
        {
            // Ejemplo: cargar opciones, ajustar valores por defecto
        }
        #endregion

        #region Wrappers del diseñador
        // Wrapper para el evento ligado en el diseñador (mantener compatibilidad)
        // Qué: el diseñador puede estar ligado a Form1_Load; este método llama a AlCargarFormulario
        // Por qué: mantener el nombre del diseñador y centralizar la lógica en AlCargarFormulario
        private void Form1_Load(object sender, EventArgs e)
        {
            AlCargarFormulario(sender, e);
        }
        #endregion

        #region Validaciones
        // Botón de Ingresar: valida campos y abre el menú principal
        // Qué: comprueba que usuario y contraseña no estén vacíos y abre fmMenu
        // Por qué: evitar ingresar sin datos y pasar a la siguiente pantalla
        // Cómo: el diseñador asocia este método al evento Click del botón "Ingresar"
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Nota: algunos controles personalizados (CuoreUI) usan la propiedad .Content en lugar de .Text

            // 1) Validar usuario
            if (string.IsNullOrWhiteSpace(usuario.Content))
            {
                // Mostrar mensaje y detener la ejecución del método
                MessageBox.Show("Por favor ingrese su usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2) Validar contraseña
            if (string.IsNullOrWhiteSpace(contrasena.Content))
            {
                MessageBox.Show("Por favor ingrese su contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3) Si ambas validaciones pasan, guardar usuario y abrir el menú principal
            // Qué: guardamos en una variable global para poder mostrar el nombre en fmMenu
            variablesGlobales.usuario1 = usuario.Content;

            // Abrir el formulario principal
            var menu = new fmMenu();
            menu.Show();

            // Ocultar este formulario de registro (no cerrarlo para que puedas volver si lo deseas)
            Hide();
        }
        #endregion

        #region Logo y wrappers
        // Clic en el logo
        // Qué: manejador vacío por defecto. Puedes abrir una web o mostrar información adicional.
        private void Logo_Clic(object sender, EventArgs e)
        {
            // Ejemplo: Process.Start("https://ejemplo.com"); // requiere manejo de excepciones y permisos
        }

        // Wrapper para mantener compatibilidad con el diseñador
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Logo_Clic(sender, e);
        }
        #endregion

        #region Etiquetas
        // Evento Load para alguna etiqueta personalizada (si se requiere)
        private void Etiqueta_Cargar(object sender, EventArgs e)
        {
            // Inicializar etiqueta si es necesario
        }

        // Wrapper para el evento ligado en el diseñador
        private void cuiLabel1_Load(object sender, EventArgs e)
        {
            Etiqueta_Cargar(sender, e);
        }
        #endregion
    }
}
