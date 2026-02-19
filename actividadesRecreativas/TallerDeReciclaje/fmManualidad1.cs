using AlberSoft.actividadesRecreativas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlberSoft.activadesRecreativas.Cocina_Comunitaria
{
    public partial class fmManualidad1 : Form
    {
        public fmManualidad1()
        {
            InitializeComponent();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            // Si este formulario está embebido dentro de un Panel (por ejemplo panel2 en fmMenu),
            // reemplazamos su contenido por el formulario indicado
            var parentPanel = this.Parent as Panel;
            try
            {
                parentPanel.Controls.Clear();

                var bienvenida = new fmLogoTaller();
                bienvenida.TopLevel = false;
                bienvenida.FormBorderStyle = FormBorderStyle.None;
                bienvenida.Dock = DockStyle.Fill;

                parentPanel.Controls.Add(bienvenida);
                bienvenida.Show();
            }
            catch
            {
                // Fallback: abrir como ventana independiente
                var bienvenida = new fmLogoTaller();
                bienvenida.Show();
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
