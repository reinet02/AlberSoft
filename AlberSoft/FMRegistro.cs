namespace AlberSoft
{
    public partial class FMRegistro : Form
    {
        public FMRegistro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(entrada.Text))
            {
                MessageBox.Show($"¡Bienvenido, {entrada.Text}!", "AlberSoft", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
