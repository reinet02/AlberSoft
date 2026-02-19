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
    public partial class fmElOro : Form
    {
        public fmElOro()
        {
            InitializeComponent();
        }

        private void lbText1_Load(object sender, EventArgs e)
        {

        }

        private void tablaGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ubimapa4_Click(object sender, EventArgs e)
        {

            try
            {
                // Enlace de Google Maps para la provincia (busqueda por nombre)
                var url = "https://www.google.com/maps/place/Di%C3%B3cesis+de+Machala/@-3.2585908,-79.9626004,17z/data=!3m1!4b1!4m6!3m5!1s0x90330f004e8b11ab:0x637613a65571ecd7!8m2!3d-3.2585962!4d-79.9600255!16s%2Fg%2F11xvckcpnf?entry=ttu&g_ep=EgoyMDI2MDIxNi4wIKXMDSoASAFQAw%3D%3D";
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


