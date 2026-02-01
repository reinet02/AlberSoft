using AlberSoft.activadesRecreativas.Cocina_Comunitaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace AlberSoft.actividadesRecreativas
{
    public partial class fmTallerReciclaje : Form
    {
        public fmTallerReciclaje()
        {
            InitializeComponent();
        }

        #region Funciones para los botones de recetas
        // Manejador para el botón llamado "receta1" en el diseñador
        private void btnReceta1_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmDesayunoReceta1());
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btntostadas_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmDesayunoReceta2());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void cuiPanel1_Paint(object sender, PaintEventArgs e)
        {
        
        
        }

        private void cuiButton9_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmDesayunoReceta3());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnpanqueque_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmDesayunoReceta4());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnsalteado_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmAlmuerzoReceta1());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnpollo_Click(object sender, EventArgs e)
        {

        }

        private void btnsopatomate_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmAlmuerzoReceta3());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnpasta_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmAlmuerzoReceta4());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btncrema_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmMeriendaReceta1());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btntortillas_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmMeriendaReceta2());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnfajitas_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmMeriendaReceta3());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btncazuela_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmMeriendaReceta4());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btntarta_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmPostresReceta1());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnbrownie_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmPostresReceta2());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnhelado_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmPostresReceta3());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnpudin_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo(new fmPostresReceta4());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }
    }
}
