using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace AlberSoft.mapaInteractivo
{
    public partial class fmPichincha : Form
    {
        public fmPichincha()
        {
            InitializeComponent();
        }

        private void lbText1_Load(object sender, EventArgs e)
        {

        }

        private void tablaGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbPinUbicacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Enlace de Google Maps para la provincia (busqueda por nombre)
                var url = "https://maps.google.com/?q=C%C3%A1ritas+Quito�";
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


