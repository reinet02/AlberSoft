namespace MapaInterc
{
    public partial class fmMapa : Form
    {
        public fmMapa()
        {
            InitializeComponent();
            //webViewmapa.Source = new Uri("https://www.google.com");
            
        }

        private void webViewmapa_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ruta = System.IO.Path.Combine(
        Application.StartupPath,
        "mapa.html"
    );
            //MessageBox.Show(ruta);

            webViewmapa.Source = new Uri(ruta);
        }
    }
}
