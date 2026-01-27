using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AlberSoft.menuPrincipal
{
    public partial class fmRegistro : Form
    {
        public fmRegistro()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }
        private void cuibtnRegistrarme_Click(object sender, EventArgs e)
        {
            // Obtiene los valores de los TextBox
            string nombre = tbUsuario.Content;
            string contraseña = tbContrasena1.Content;
            string confiContra = tbContrasena2.Content;

            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(contraseña) ||
                string.IsNullOrWhiteSpace(confiContra))
            {
                MessageBox.Show("Uno o varios de los campos están vacíos.");
                return;
            }
            // Validar que las contraseñas coincidan
            if (contraseña != confiContra)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            // Ruta del archivo
            string ruta = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "credenciales.txt");

            // Guarda las credenciales
            string linea = $"{nombre} | {contraseña}";
            File.AppendAllText(ruta, linea + Environment.NewLine);

            DialogResult resultado = MessageBox.Show(
                "Credenciales guardadas correctamente.",
                "Registro exitoso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            if (resultado == DialogResult.OK)
            {
                this.Close(); // Cierra el formulario si quieres
            }

            // Limpia los TextBox
            tbUsuario.Content = "";
            tbContrasena1.Content = "";
            tbContrasena2.Content = "";
        }

        private void cuibtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxMostrarContra_CheckedChanged(object sender, EventArgs e)
        {
            //cambia el estado del PasswordChar según el CheckBox
            tbContrasena1.PasswordChar = !cbxMostrarContra.Checked;
        }

        private void cbxMostrarCfmContra_CheckedChanged(object sender, EventArgs e)
        {
            //cambia el estado del PasswordChar según el CheckBox
            tbContrasena2.PasswordChar = !cbxMostrarCfmContra.Checked;
        }
    }
}
