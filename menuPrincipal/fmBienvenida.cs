namespace AlberSoft.menuPrincipal
{
    public partial class fmBienvenida : Form
    {
        public fmBienvenida()
        {
            InitializeComponent();
            // Mostrar el nombre del usuario en la etiqueta "bienvenida"
            string usuario = variablesGlobales.usuario1;
            bienvenida.Content = "¡Bienvenido " + usuario + "!";
        }
    }
}