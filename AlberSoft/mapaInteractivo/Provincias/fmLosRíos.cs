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
    public partial class fmLosRíos : Form
    {
        public fmLosRíos()
        {
            InitializeComponent();
        }

        private void lbText1_Load(object sender, EventArgs e)
        {

        }

        private void tablaGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tablaTexto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cuiLabel1_Load(object sender, EventArgs e)
        {

        }

        private void tablaTexto_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tablaTexto_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void ubimapa_Click(object sender, EventArgs e)
        {
            try
            {
                // Enlace de Google Maps para la provincia (busqueda por nombre)
                var url = "https://www.google.com/maps/place/DIOCESIS+DE+BABAHOYO/@-1.8000729,-79.5364133,17z/data=!3m1!4b1!4m6!3m5!1s0x902cd759ecda3bc1:0xb3b00784fe5ad23d!8m2!3d-1.8000783!4d-79.5338384!16s%2Fg%2F11jj49l74p?entry=ttu&g_ep=EgoyMDI2MDIxNi4wIKXMDSoASAFQAw%3D%3D";
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


