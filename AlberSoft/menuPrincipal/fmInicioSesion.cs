using AlberSoft.menuPrincipal;
using System.Linq;
using System.IO;

namespace AlberSoft
{
    public partial class fmInicioSesion : Form
    {
        public fmInicioSesion()
        {
            InitializeComponent();
        }

        #region Función que valida las credenciales ingresadas

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Nota: Algunos controles personalizados (CuoreUI) usan la propiedad .Content en lugar de .Text

            // Obtener los valores ingresados
            string Usuario = usuario.Content.Trim();
            string Contraseña = contrasena.Content.Trim();

            // Validar que no estén vacíos
            if (string.IsNullOrWhiteSpace(Usuario) || string.IsNullOrWhiteSpace(Contraseña))
            {
                MessageBox.Show("Ingrese usuario y contraseña.");
                return;
            }
            // Validar credenciales contra el archivo de datos
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "credenciales.txt");

            //  Verificar si el archivo existe
            if (!File.Exists(ruta))
            {
                MessageBox.Show("¡No se encontraron usuarios registrados!");
                return;
            }

            bool encontrado = false;

            // Leer el archivo línea por línea
            foreach (string linea in File.ReadAllLines(ruta))
            {
                string[] partes = linea.Split('|');

                if (partes.Length >= 2)
                {
                    string userGuardado = partes[0].Trim();
                    string passGuardado = partes[1].Trim();

                    if (Usuario == userGuardado && Contraseña == passGuardado)
                    {
                        encontrado = true;
                        break;
                    }
                }
            }

            if (encontrado)
            {
                // Guardar el usuario para que fmBienvenida lo lea
                variablesGlobales.usuario1 = Usuario;

                MessageBox.Show("¡Inicio de sesión exitoso!");

                // Abrir menú principal
                new fmMenu().Show();
                Hide(); // Ocultar el formulario de login
            }
            else
            {
                MessageBox.Show("¡Usuario o contraseña incorrectos!");
            }
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

        private void linkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abrir el formulario de registro
            Form registro = new fmRegistro();
            // Usar ShowDialog para que el usuario tenga que cerar el registro para poder volver al login
            registro.ShowDialog();
        }

        private void linkOlvidasteContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Abrir el formulario de registro
            Form registro = new fmRegistro();
            registro.ShowDialog();
        }
    }
}
