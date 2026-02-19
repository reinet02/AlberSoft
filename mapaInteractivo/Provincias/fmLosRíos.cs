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
                var url = "https://maps.google.com/?q=C%C3%A1ritas+Babahoyo";
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


