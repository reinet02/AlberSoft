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
            fmInstruccionesQuiz ins = new fmInstruccionesQuiz(1);

            if (ins.ShowDialog() == DialogResult.OK)
            {
                AbrirQuizSegunNivel(1);
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            fmInstruccionesQuiz ins = new fmInstruccionesQuiz(2);

            if (ins.ShowDialog() == DialogResult.OK)
            {
                AbrirQuizSegunNivel(2);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            fmInstruccionesQuiz ins = new fmInstruccionesQuiz(3);

            if (ins.ShowDialog() == DialogResult.OK)
            {
                AbrirQuizSegunNivel(3);
            }
        }

        private void regresar1_Click(object sender, EventArgs e)
        {
            var parentPanel = this.Parent as Panel;

            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();

                var menu = new menuPrincipal.fmBienvenida();
                menu.TopLevel = false;
                menu.FormBorderStyle = FormBorderStyle.None;
                menu.Dock = DockStyle.Fill;

                parentPanel.Controls.Add(menu);
                menu.Show();
            }
            else
            {
                var menu = new menuPrincipal.fmBienvenida();
                menu.Show();
                this.Close();
            }
        }

        private void btnReferencias1_Click(object sender, EventArgs e)
        {
            Form referenciasForm = new fmReferenciasPreguntasQuiz();
            referenciasForm.Show();
        }

        private void fmQuizMenu_Load(object sender, EventArgs e)
        {

        }
    }
}


