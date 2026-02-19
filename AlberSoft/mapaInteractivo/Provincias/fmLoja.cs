using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlberSoft.mapaInteractivo
{
    public partial class fmLoja : Form
    {
        public fmLoja()
        {
            InitializeComponent();
        }

        private void lbText1_Load(object sender, EventArgs e)
        {

        }

        private void tablaGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ubimapa2_Click(object sender, EventArgs e)
        {
            try
            {
                // Enlace de Google Maps para la provincia (busqueda por nombre)
                var url = "https://www.google.com/maps/place/PASTORAL+SOCIAL-CARITAS+LOJA/@-1.1862016,-79.5017216,13z/data=!3m1!4b1!4m6!3m5!1s0x91cb47fff6328c1d:0x45d0951f8e82bf48!8m2!3d-3.9976435!4d-79.199104!16s%2Fg%2F11g6vkdqzy?entry=ttu&g_ep=EgoyMDI2MDIxNi4wIKXMDSoASAFQAw%3D%3D";
                var psi = new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo abrir el enlace: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}


