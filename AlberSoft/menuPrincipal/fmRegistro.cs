using System.IO; // Para operaciones con archivos
using System.Text; // Para codificación de texto

namespace AlberSoft.menuPrincipal
{
    public partial class fmRegistro : Form
    {
        public fmRegistro()
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

        private void linkIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Declaramos una variable de tipo Form
            // y le asignamos una nueva instancia del formulario "fmInicioSesion"
            Form inicioSesion = new fmInicioSesion();
            // Mostrar el formulario
            inicioSesion.Show();
            // Lo ocultamos en lugar de cerrarlo para evitar que la aplicación se cierre
            // ya que si este formulario es cerrado, se termina la ejecución del programa
            // debido a FormClosed declarado en el constructor de este formulario
            Hide();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            #region Obtener valores de los campos (la propiedad en este control de CuoreUI es "Content")
            // ?? es el operador null-coalescing (coalescencia nula)
            // devuelve el operando de la izquierda si no es nulo
            // en caso contrario devuelve el operando de la derecha

            // ? llama a Trim solo cuando Content no es nulo
            string usuario = tbUsuario.Content?.Trim() ?? string.Empty;
            string contrasena = tbContrasena.Content?.Trim() ?? string.Empty;
            #endregion

            // si usuario o contraseña están vacíos o tienen solo espacios en blanco entonces
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor, complete los campos de usuario y contraseña.", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // crear un archivo llamado "credenciales.txt" en la carpeta de la aplicación
                string carpeta = AppDomain.CurrentDomain.BaseDirectory;
                string ruta = Path.Combine(carpeta, "credenciales.txt");

                // Formato: fecha \t usuario \t contraseña
                // \t es un tabular
                string linea = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}\t{usuario}\t{contrasena}{Environment.NewLine}";

                File.AppendAllText(ruta, linea, Encoding.UTF8);

                MessageBox.Show("Credenciales guardadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar campos después de guardar
                tbUsuario.Content = string.Empty;
                tbContrasena.Content = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar credenciales: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}