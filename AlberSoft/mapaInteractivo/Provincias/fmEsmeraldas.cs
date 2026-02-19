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
    public partial class fmEsmeraldas : Form
    {
        public fmEsmeraldas()
        {
            InitializeComponent();
        }

        private void lbText1_Load(object sender, EventArgs e)
        {

        }

        private void tablaGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void fmEsmeraldas_Load(object sender, EventArgs e)
        {

        }

        private void ubimapa3_Click(object sender, EventArgs e)
        {

            try
            {
                // Enlace de Google Maps para la provincia (busqueda por nombre)
                var url = "https://www.google.com/maps/place/TRABAJO+SOCIAL+CARITAS+ESMERALDAS/@0.9681045,-79.6542738,17z/data=!3m1!4b1!4m6!3m5!1s0x8fd4bdb581262d11:0x913e23064dd19ba8!8m2!3d0.9680991!4d-79.6516989!16s%2Fg%2F11t2cmzt4_?entry=ttu&g_ep=EgoyMDI2MDIxNi4wIKXMDSoASAFQAw%3D%3D";
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


