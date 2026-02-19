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
    public partial class fmManabí : Form
    {
        public fmManabí()
        {
            InitializeComponent();
        }

        private void lbText1_Load(object sender, EventArgs e)
        {

        }

        private void tablaGeneral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pbGmaps_Click(object sender, EventArgs e)
        {
            try
            {
                // Enlace de Google Maps para la provincia (busqueda por nombre)
                var url = "https://www.google.com/maps/place/Arquidi%C3%B3sesis+de+Portoviejo/@-1.1862016,-79.5017216,13z/data=!3m1!4b1!4m6!3m5!1s0x902b8d52c505665f:0xa5d3bd9dd7777eee!8m2!3d-1.0518638!4d-80.4538223!16s%2Fg%2F11fzfcp2v5?entry=ttu&g_ep=EgoyMDI2MDIxNi4wIKXMDSoASAFQAw%3D%3D";
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


