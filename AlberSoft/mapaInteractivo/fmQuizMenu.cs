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
            // Mostrar primero las instrucciones para el nivel seleccionado.
            using var instrucciones = new fmInstruccionesQuiz(nivel);
            var resultado = instrucciones.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                // El usuario presionó "Jugar": abrir el quiz y arrancar su temporizador
                using var quiz = new fmQuiz(nivel);
                quiz.IniciarTemporizador();
                quiz.ShowDialog();
            }
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


