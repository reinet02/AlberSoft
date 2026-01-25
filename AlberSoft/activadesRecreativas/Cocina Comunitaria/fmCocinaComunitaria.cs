using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AlberSoft.activadesRecreativas.Recetas;

namespace AlberSoft.activadesRecreativas
{
    public partial class fmCocinaComunitaria : Form
    {
        public fmCocinaComunitaria()
        {
            InitializeComponent();
        }

        #region Funciones para los botones de recetas
        // Manejador para el botón llamado "receta1" en el diseñador.
        private void btnReceta1_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmReceta1());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }
        #endregion

        #region Función para cargar un formulario dentro de un panel
        // Carga un formulario dentro del panel "panel2"
        private void abrirFormularioHijo(Form frm)
        {
            try
            {
                // Limpiar controles existentes en el panel
                this.panel1.Controls.Clear();

                // Preparar el formulario para mostrarse embebido
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                // Añadir y mostrar
                this.panel1.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception)
            {
                // En caso de error, mostrar mensaje simple (se puede mejorar)
                MessageBox.Show("No se pudo cargar el formulario.");
            }
        }
        #endregion

        #region Cargar por defecto un formulario dentro de un panel
        private void CargarFormularioPorDefecto_Load(object sender, EventArgs e)
        {
            try
            {
                abrirFormularioHijo(new fmLogoCocinaComunitaria());
            }
            catch { }
        }
        #endregion
    }
}
