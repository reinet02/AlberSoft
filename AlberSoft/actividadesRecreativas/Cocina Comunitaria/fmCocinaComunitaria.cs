using AlberSoft.activadesRecreativas.Cocina_Comunitaria;
using AlberSoft.actividadesRecreativas.Cocina_Comunitaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace AlberSoft.actividadesRecreativas
{
    public partial class fmCocinaComunitaria : Form
    {
        public fmCocinaComunitaria()
        {
            InitializeComponent();
        }

        #region Funciones para los botones de recetas
        // Manejador para el botón llamado "receta1" en el diseñador
        private void btnAvena_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo1(new fmDesayunoReceta1());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnTostadas_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo1(new fmDesayunoReceta2());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnParfait_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo1(new fmDesayunoReceta3());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnPanqueque_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel2
                abrirFormularioHijo1(new fmDesayunoReceta4());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnSalteado_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo2(new fmAlmuerzoReceta1());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnSopaPollo_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo2(new fmAlmuerzoReceta2());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnSopaTomate_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo2(new fmAlmuerzoReceta3());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnPasta_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo2(new fmAlmuerzoReceta4());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnCrema_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo3(new fmMeriendaReceta1());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnTortillas_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo3(new fmMeriendaReceta2());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnFajitas_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo3(new fmMeriendaReceta3());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnCazuela_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo3(new fmMeriendaReceta4());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnTarta_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo4(new fmPostresReceta1());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnBrownie_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo4(new fmPostresReceta2());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnHelado_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo4(new fmPostresReceta3());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnPudin_Click(object sender, EventArgs e)
        {
            try
            {
                // Llamar a la función que coloca el formulario dentro de panel1
                abrirFormularioHijo4(new fmPostresReceta4());
            }
            catch (Exception ex)
            {
                // Si ocurre algún error, mostrar un mensaje simple para el usuario
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        #endregion

        #region Función para cargar un formulario dentro de un panel
        private void abrirFormularioHijo1(Form frm)
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

        private void abrirFormularioHijo2(Form frm)
        {
            try
            {
                // Limpiar controles existentes en el panel
                this.panel2.Controls.Clear();

                // Preparar el formulario para mostrarse embebido
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                // Añadir y mostrar
                this.panel2.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception)
            {
                // En caso de error, mostrar mensaje simple (se puede mejorar)
                MessageBox.Show("No se pudo cargar el formulario.");
            }
        }

        private void abrirFormularioHijo3(Form frm)
        {
            try
            {
                // Limpiar controles existentes en el panel
                this.panel3.Controls.Clear();

                // Preparar el formulario para mostrarse embebido
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                // Añadir y mostrar
                this.panel3.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception)
            {
                // En caso de error, mostrar mensaje simple (se puede mejorar)
                MessageBox.Show("No se pudo cargar el formulario.");
            }
        }

        private void abrirFormularioHijo4(Form frm)
        {
            try
            {
                // Limpiar controles existentes en el panel
                this.panel4.Controls.Clear();

                // Preparar el formulario para mostrarse embebido
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                // Añadir y mostrar
                this.panel4.Controls.Add(frm);
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
                abrirFormularioHijo1(new fmLogoCocinaComunitaria());
            }
            catch { }
        }
        #endregion
    }
}
