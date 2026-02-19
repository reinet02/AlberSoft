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
    public partial class fmDesayunoReceta1 : Form
    {
        public fmDesayunoReceta1()
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

                var bienvenida = new fmLogoCocinaComunitaria();
                bienvenida.TopLevel = false;
                bienvenida.FormBorderStyle = FormBorderStyle.None;
                bienvenida.Dock = DockStyle.Fill;

                parentPanel.Controls.Add(bienvenida);
                bienvenida.Show();
            }
            catch
            {
                // Fallback: abrir como ventana independiente
                var bienvenida = new fmLogoCocinaComunitaria();
                bienvenida.Show();
            }

        }


        private void panelgeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void tablaPasosDePreparación_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
