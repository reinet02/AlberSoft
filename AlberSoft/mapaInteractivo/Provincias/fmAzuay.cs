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
    public partial class fmAzuay : Form
    {
        public fmAzuay()
        {
            InitializeComponent();
        }

        private void lbText1_Load(object sender, EventArgs e)
        {

        }

        private void tablaGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ubimapa6_Click(object sender, EventArgs e)
        {
            try
            {
                // Enlace de Google Maps para la provincia (busqueda por nombre)
                var url = "https://www.google.com/maps/place/C%C3%A1ritas+Diocesana+De+Cuenca/@40.0714456,-2.1431939,17z/data=!3m1!4b1!4m6!3m5!1s0xd5d67638254bf6f:0x863c088fe134b721!8m2!3d40.0714415!4d-2.140619!16s%2Fg%2F1wk4fcxj?entry=ttu&g_ep=EgoyMDI2MDIxNi4wIKXMDSoASAFQAw%3D%3D";
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


