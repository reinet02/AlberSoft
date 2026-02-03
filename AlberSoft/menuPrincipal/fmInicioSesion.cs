using System.IO; // Para operaciones con archivos

namespace AlberSoft.menuPrincipal
{
    public partial class fmInicioSesion : Form
    {
        public fmInicioSesion()
        {
            InitializeComponent();
            // cuando se cierre este formulario, se terminará la ejecución del programa
            FormClosed += (s, e) => Application.Exit();

            // hacemos que por defecto la contraseña esté oculta
            tbContrasena.PasswordChar = true;
            pbOjo.Image = Properties.Resources.invisible;
        }

        private void pbOjo_Click(object? sender, EventArgs e)
        {
            if (tbContrasena.PasswordChar == false)
            {
                tbContrasena.PasswordChar = true;
                pbOjo.Image = Properties.Resources.invisible;
            }
            else
            {
                tbContrasena.PasswordChar = false;
                pbOjo.Image = Properties.Resources.visible;
            }
        }

        private void linkRegistrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Declaramos una variable de tipo Form
            // y le asignamos una nueva instancia del formulario "fmInicioSesion"
            Form registro = new fmRegistro();
            // Mostrar el formulario
            registro.Show();
            // Lo ocultamos en lugar de cerrarlo para evitar que la aplicación se cierre
            // ya que si este formulario es cerrado, se termina la ejecución del programa
            // debido a FormClosed declarado en el constructor de este formulario
            Hide();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            // Obtener valores de los controles (CuoreUI usa .Content)
            string usuario = tbUsuario.Content?.Trim() ?? string.Empty;
            string contrasena = tbContrasena.Content?.Trim() ?? string.Empty;

            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("¡Ingrese su usuario!", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("¡Ingrese su contraseña!", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ruta del archivo creado por fmRegistro
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "credenciales.txt");

            if (!File.Exists(ruta))
            {
                MessageBox.Show("¡No se encontraron usuarios registrados!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool encontrado = false;

            try
            {
                // Cada línea: fecha \t usuario \t contraseña
                foreach (string lineaOriginal in File.ReadLines(ruta))
                {
                    if (string.IsNullOrWhiteSpace(lineaOriginal))
                        continue;

                    string[] partes = lineaOriginal.Trim().Split('\t');
                    if (partes.Length >= 3)
                    {
                        string usuarioGuardado = partes[1].Trim();
                        string contrasenaGuardada = partes[2].Trim();

                        if (usuario == usuarioGuardado && contrasena == contrasenaGuardada)
                        {
                            encontrado = true;
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al leer el archivo de credenciales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (encontrado)
            {
                // variable global usada en tu código original
                variablesGlobales.usuario1 = usuario;
                MessageBox.Show("¡Inicio de sesión exitoso!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new fmMenu().Show();
                Hide(); // ocultar formulario de inicio de sesión
            }
            else
            {
                MessageBox.Show("¡Usuario o contraseña incorrectos!", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
