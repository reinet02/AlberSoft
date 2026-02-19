using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlberSoft.mapaInteractivo
{
    public partial class fmInstruccionesQuiz : Form
    {
        private int nivel;

        // Constructor que recibe el nivel
        public fmInstruccionesQuiz(int nivelSeleccionado)
        {
            InitializeComponent();
            nivel = nivelSeleccionado;
            MostrarInstrucciones();
        }

        private void MostrarInstrucciones()
        {
            if (nivel == 1)
            {
                label1.Text = "🟢 NIVEL FÁCIL\n\n" +
                              "Tiempo: 5 minutos\n" +
                              "Penalización por error: -5 segundos\n\n" +
                              "Debes responder TODAS correctas para ganar.";
            }
            else if (nivel == 2)
            {
                label1.Text = "🟡 NIVEL INTERMEDIO\n\n" +
                              "Tiempo: 3 minutos\n" +
                              "Penalización por error: -10 segundos\n\n" +
                              "Debes responder TODAS correctas para ganar.";
            }
            else if (nivel == 3)
            {
                label1.Text = "🔴 NIVEL DIFÍCIL\n\n" +
                              "Tiempo: 2 minutos\n" +
                              "Penalización por error: -15 segundos\n\n" +
                              "Debes responder TODAS correctas para ganar.";
            }
        }

        /*private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }*/

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /*private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }*/

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            // Indicar al llamador que el usuario quiere jugar y cerrar este formulario.
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
