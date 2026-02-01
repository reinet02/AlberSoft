using AlberSoft.menuPrincipal;
using System.IO; // System.IO es un espacio de nombres q contiene la clase File

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

            #region Verificar q los textbox no esten vacíos
            // Obtener los valores ingresados en los textbox llamados "usuario" y "contrasena"
            string usuario1 = usuario.Content.Trim();
            string contrasena1 = contrasena.Content.Trim();

            // si usuario1 está vacío o contiene solo espacios en blanco entonces
            if (string.IsNullOrWhiteSpace(usuario1))
            {
                MessageBox.Show("¡Ingrese su usuario!");
                return;
            }
            // también si contrasena1 está vacío o contiene solo espacios en blanco entonces
            else if (string.IsNullOrWhiteSpace(contrasena1))
            {
                MessageBox.Show("¡Ingrese su contraseña!");
                return;
            }
            else
            {
                
            }
            #endregion

            #region Validar las credenciales ingresadas con las credenciales ya registradas
            // AppDomain.CurrentDomain.BaseDirectory devuelve el directorio
            // q el cargador de ensamblados usa para buscar archivos y dependencias
            // (habitualmente la carpeta donde está el ejecutable de la aplicación, por ejemplo bin\Debug\net10\)
            // La ruta suele terminar con el separador de directorio: "\" 

            // Declaramos la variable "ruta" y le asignamos la ruta completa del archivo credenciales.txt
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "credenciales.txt"); //  Declaramos la ruta del archivo credenciales.txt

            // si el archivo credenciales.txt no existe entonces
            if (!File.Exists(ruta))
            {
                MessageBox.Show("¡No se encontraron usuarios registrados!");
                return;
            }

            #region Leer el archivo línea por línea
            // Usamos foreach para leer cada línea del archivo
            // Cada línea tiene el formato: usuario|contraseña
            // File.ReadAllLines lee todas las líneas del archivo

            // Declaramos la variable "encontradas" como falsa
            // debe estar fuera del bucle para mantener su valor después de recorrer todas las líneas del archivo con foreach
            bool encontradas = false;

            foreach (string linea in File.ReadAllLines(ruta))
            {
                // Creamos una lista llamada "partes" de tipo string
                // linea.Split('|') divide la línea en partes usando "|" como separador
                // de modo que los elementos de la lista serán las partes separadas por "|" 
                string[] partes = linea.Split('|');

                // si hay dos partes entonces
                if (partes.Length >= 2)
                {
                    // usuario será la primera parte
                    string usuarioGuardado = partes[0].Trim();
                    // contrasena será la segunda parte
                    string contrasenaGuardada = partes[1].Trim();

                    // si usuario1 == usuarioGuardado y contrasena1 == contrasenaGuardada entonces
                    if (usuario1 == usuarioGuardado && contrasena1 == contrasenaGuardada)
                    {
                        encontradas = true;
                        break;
                    }
                }
            }
            

            if (encontradas == true)
            {
                // Asiganamos a la variable global "usuario1" el valor de la variable local usuario1
                variablesGlobales.usuario1 = usuario1;

                MessageBox.Show("¡Inicio de sesión exitoso!");

                // Abrir menú principal
                new fmMenu().Show();
                Hide(); // Ocultar el formulario de inicio de sesión
            }
            else
            {
                MessageBox.Show("¡Usuario o contraseña incorrectos!"); // incorrectos o no encontrados
            }
            #endregion

            #endregion
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
