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
    public partial class fmHuertoComunitario : Form
    {
        public fmHuertoComunitario()
        {
            InitializeComponent();
        }

        #region Cargar por defecto un formulario dentro de un panel
        private void CargarFormularioPorDefecto_Load(object sender, EventArgs e)
        {
            try
            {
                abrirFormularioHijo(new fmLogoHuerto());
            }
            catch { }
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

        #region Funciones para cada botón
        private void btnOregano_Click(object sender, EventArgs e)
        {
            try
            {
                abrirFormularioHijo(new fmplanta1());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnSabila_Click(object sender, EventArgs e)
        {
            try
            {
                abrirFormularioHijo(new fmplanta2());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnHierbaBuena_Click(object sender, EventArgs e)
        {
            try
            {
                abrirFormularioHijo(new fmplanta3());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        private void btnAlbahaca_Click(object sender, EventArgs e)
        {
            try
            {
                abrirFormularioHijo(new fmplanta4());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir la receta: " + ex.Message);
            }
        }

        #endregion
    }
}
