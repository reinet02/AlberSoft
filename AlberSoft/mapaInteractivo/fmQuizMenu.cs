namespace AlberSoft.mapaInteractivo
{
    public partial class fmQuizMenu : Form
    {
        public fmQuizMenu()
        {
            InitializeComponent();
        }

        #region Función para abrir un formulario
        private void AbrirQuizSegunNivel(int nivel)
        {
            // Abrimos el formulario fmQuiz2 pasándole un nivel de dificultad (int)
            using var quiz = new fmQuiz(nivel);
            // Usamos un ShowDialog para comportarse como ventana modal
            // modal: es una ventana que bloquea la interacción
            // con otras ventanas hasta que esta se cierre 
            // En cambio Show permite interactuar con otras ventanas
            quiz.ShowDialog();
        }
        #endregion

        private void cuiLabel1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AbrirQuizSegunNivel(1);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AbrirQuizSegunNivel(2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AbrirQuizSegunNivel(3);
        }
    }
}


