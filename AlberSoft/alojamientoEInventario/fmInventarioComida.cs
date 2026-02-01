using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AlberSoft.Alojamiento_e_Inventario
{
    public partial class fmInventarioComida : Form
    {
        public fmInventarioComida()
        {
            InitializeComponent();
            CargarDatosComida();
            ConfigurarDataGridView();
        }
        #region Configuracion manual de la tabla de datos
        private void ConfigurarDataGridView()
        {
            // Deshabilitar estilos visuales para usar colores personalizados
            dtgInventarioComida.EnableHeadersVisualStyles = false;

            // Encabezados de columnas
            dtgInventarioComida.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 102, 245);
            dtgInventarioComida.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dtgInventarioComida.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dtgInventarioComida.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Altura de encabezados
            dtgInventarioComida.ColumnHeadersHeight = 35;

            // Estilo de las filas alternadas
            dtgInventarioComida.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Estilo de las filas normales
            dtgInventarioComida.RowsDefaultCellStyle.BackColor = Color.White;
            dtgInventarioComida.RowsDefaultCellStyle.ForeColor = Color.Black;
            dtgInventarioComida.RowsDefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dtgInventarioComida.RowsDefaultCellStyle.SelectionForeColor = Color.White;
        }
        #endregion

        #region Obtener la ruta del archivo del texto
        private string ObtenerRutaArchivoComida()
        {
            // Obtiene la carpeta donde está el .txt
            string carpetaApp = Application.StartupPath;
            return Path.Combine(carpetaApp, "inventario_comida.txt");
        }
        #endregion

        #region Guardar datos de la tabla
        private void GuardarDatosComida()
        {
            try
            {
                string rutaArchivo = ObtenerRutaArchivoComida();
                using (StreamWriter sw = new StreamWriter(rutaArchivo))
                {
                    foreach (DataGridViewRow fila in dtgInventarioComida.Rows)
                    {
                        if (!fila.IsNewRow)
                        {
                            string linea = string.Join("|",
                                fila.Cells[0].Value?.ToString() ?? "",
                                fila.Cells[1].Value?.ToString() ?? "",
                                fila.Cells[2].Value?.ToString() ?? "",
                                fila.Cells[3].Value?.ToString() ?? "",
                                fila.Cells[4].Value?.ToString() ?? "");
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
        private void CargarDatosComida()
        {
            try
            {
                string rutaArchivo = ObtenerRutaArchivoComida();

                if (File.Exists(rutaArchivo))
                {
                    dtgInventarioComida.Rows.Clear();

                    using (StreamReader sr = new StreamReader(rutaArchivo))
                    {
                        string linea;
                        while ((linea = sr.ReadLine()) != null)
                        {
                            string[] datos = linea.Split('|');
                            if (datos.Length == 5)
                            {
                                dtgInventarioComida.Rows.Add(
                                    datos[0],
                                    datos[1],
                                    datos[2],
                                    datos[3],
                                    datos[4]
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

        private void cuibtnAgregar_Click(object sender, EventArgs e)
        {

            // Validar que ID sea numérico
            if (!int.TryParse(cuitxtID.Content, out int id))
            {
                MessageBox.Show("El ID debe ser un número válido.",
                                "Error de validación",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                cuitxtID.Focus();
                return;
            }

            // Validar que los ComboBox tengan una selección
            if (cuicmbProducto.SelectedIndex == -1 || cuicmbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione un producto y una categoría.",
                                "Campos incompletos",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Si todas las validaciones pasaron, agregar la fila
            dtgInventarioComida.Rows.Add(
                cuitxtID.Content,
                cuicmbProducto.SelectedItem?.ToString() ?? "",
                cuicmbCategoria.SelectedItem?.ToString() ?? "",
                nudCantidadComi.Value,
                dtpFechaVencimiento.Value.ToString("dd/MM/yyyy"));

            var result = MessageBox.Show(
    "Registro agregado correctamente.",
    "Éxito",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                // limpiar los campos después de agregar
                cuicmbProducto.SelectedIndex = -1;
                cuicmbCategoria.SelectedIndex = -1;
                cuitxtID.Content = "";
                nudCantidadComi.Value = 1;
                dtpFechaVencimiento.Value = DateTime.Now;
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
                if (dtgInventarioComida.SelectedRows.Count > 0)
                {
                    dtgInventarioComida.Rows.Remove(dtgInventarioComida.SelectedRows[0]);
                }
            }
        }

        private void frmInventarioDeComida_FormClosing(object sender, FormClosingEventArgs e)
        {
            GuardarDatosComida();
        }

        private void cuibtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatosComida();
        }
    }
}
