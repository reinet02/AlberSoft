using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AlberSoft.alojamientoEInventario
{
    public partial class fmInventarioRopa : Form
    {
        public fmInventarioRopa()
        {
            InitializeComponent();
            CargarDatos();
            ConfigurarDataGridView();
        }
        #region Configuracion manual de la tabla de datos
        private void ConfigurarDataGridView()
        {
            // Deshabilitar estilos visuales para usar colores personalizados
            dtgInventarioRopa.EnableHeadersVisualStyles = false;

            // Encabezados de columnas
            dtgInventarioRopa.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(254, 100, 11); // Gris oscuro
            dtgInventarioRopa.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dtgInventarioRopa.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dtgInventarioRopa.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Altura de encabezados
            dtgInventarioRopa.ColumnHeadersHeight = 35;

            // Estilo de las filas alternadas
            dtgInventarioRopa.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.LightGray;

            // Estilo de las filas normales
            dtgInventarioRopa.RowsDefaultCellStyle.BackColor = System.Drawing.Color.White;
            dtgInventarioRopa.RowsDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dtgInventarioRopa.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dtgInventarioRopa.RowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
        }
        #endregion
        #region Obtener la ruta del archivo del texto
        private string ObtenerRutaArchivo()
        {
            // Obtiene la carpeta donde está el .txt
            string carpetaApp = Application.StartupPath;
            return Path.Combine(carpetaApp, "inventario_ropa.txt");
        }
        #endregion
        #region Guardar datos de la tabla
        private void GuardarDatos()
        {
            try
            {
                string rutaArchivo = ObtenerRutaArchivo(); // Ruta dinámica
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    foreach (DataGridViewRow fila in dtgInventarioRopa.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            string linea = string.Join("|",
                                fila.Cells[0].Value?.ToString() ?? "",
                                fila.Cells[1].Value?.ToString() ?? "",
                                fila.Cells[2].Value?.ToString() ?? "",
                                fila.Cells[3].Value?.ToString() ?? ""
                            );
                            sw.WriteLine(linea);
                        }
                    }
                }
                MessageBox.Show("Datos guardados correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Cargar los datos guardados
        private void CargarDatos()
        {
            try
            {
                string rutaArchivo = ObtenerRutaArchivo(); // Ruta dinámica

                if (File.Exists(rutaArchivo))
                {
                    dtgInventarioRopa.Rows.Clear();

                    using (StreamReader sr = new StreamReader(rutaArchivo))
                    {
                        string linea;
                        while ((linea = sr.ReadLine()) != null)
                        {
                            string[] datos = linea.Split('|');
                            if (datos.Length == 4)
                            {
                                dtgInventarioRopa.Rows.Add(
                                    datos[0],
                                    datos[1],
                                    datos[2],
                                    datos[3]
                                );
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void cuibtnAgregarRopa_Click(object sender, EventArgs e)
        {
            if (cuicmbTipo.SelectedIndex == -1 || cuicmbTalla.SelectedIndex == -1 || cuicmbColor.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un Tipo de prende, su talla y color.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Si todas las validaciones pasaron, agregar la fila
            dtgInventarioRopa.Rows.Add(
                cuicmbTipo.SelectedItem?.ToString() ?? "",
                cuicmbTalla.SelectedItem?.ToString() ?? "",
                cuicmbColor.SelectedItem?.ToString() ?? "",
                nudCantidad.Value);

            var result = MessageBox.Show(
    "Registro agregado correctamente.",
    "Éxito",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                // limpiar los campos después de agregar
                cuicmbTipo.SelectedIndex = -1;
                cuicmbTalla.SelectedIndex = -1;
                cuicmbColor.SelectedIndex = -1;
                nudCantidad.Value = 1;
            }
        }

        private void cuibtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de realizar esta acción?",
                "Confirmar Salida",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.OK)
            {
                if (dtgInventarioRopa.SelectedRows.Count > 0)
                {
                    dtgInventarioRopa.Rows.Remove(dtgInventarioRopa.SelectedRows[0]);
                }
            }
        }

        private void frmInventarioDeRopa_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarDatos();
        }

        private void cuibtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }
    }
}
