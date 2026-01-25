using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlberSoft.menuPrincipal
{
    public partial class fmBienvenida : Form
    {
        public fmBienvenida()
        {
            InitializeComponent();
            // Mostrar el nombre del usuario en la etiqueta "bienvenida"
            string usuario = variablesGlobales.usuario1;
            bienvenida.Content = "¡Bienvenido " + usuario + "!";
        }

        private void bienvenida_Load(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
    }
}
