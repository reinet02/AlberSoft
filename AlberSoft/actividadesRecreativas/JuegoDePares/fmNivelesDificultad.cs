using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlberSoft.activadesRecreativas
{
    public partial class fmNivelesDificultad : Form
    {
        public fmNivelesDificultad()
        {
            InitializeComponent();
            // Registrar manejador para cambiar de formulario según la selección de nivel
            try
            {
                seleccionadorDeNivel.SelectedIndexChanged += seleccionadorDeNivel_SelectedIndexChanged;
            }
            catch
            {
                // Ignorar si el control no está disponible en tiempo de diseño
            }
        }

        #region Cargar por defecto un formulario en el panel de contenido

        private void fmNivelesDeDificultad_Load(object sender, EventArgs e)
        {
            try
            {
                abrirFormularioHijo(new fmLogoJuegoDePares());
            }
            catch { }
        }
        #endregion

        // Al cambiar la selección del combo, cargamos el formulario asociado
        private void seleccionadorDeNivel_SelectedIndexChanged(object? sender, EventArgs e)
        {
            try
            {
                // Usar el texto seleccionado en lugar del índice, porque el combo puede ordenar
                var seleccionado = seleccionadorDeNivel?.SelectedItem?.ToString() ?? string.Empty;

                switch (seleccionado)
                {
                    case "Fácil":
                        abrirFormularioHijo(new fmJuegoDeParesReciclaje()); // asigna el formulario que corresponda a "Fácil"
                        break;
                    case "Intermedio": // admitir ambos textos en caso que el diseñador muestre otro
                        abrirFormularioHijo(new fmJuegoDeParesCocina());
                        break;
                    case "Difícil":
                        abrirFormularioHijo(new fmJuegoDeParesHuerto());
                        break;
                    default:
                        // Si no hay selección válida, mostrar logo por defecto
                        abrirFormularioHijo(new fmLogoJuegoDePares());
                        break;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo cargar el formulario seleccionado.");
            }
        }

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
    }
}
