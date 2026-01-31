using AlberSoft.menuPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlberSoft.actividadesRecreativas
{
    public partial class fmLogoCocinaComunitaria : Form
    {
        public fmLogoCocinaComunitaria()
        {
            InitializeComponent();
        }

        private void regresar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el formulario contenedor inmediato (debería ser fmCocinaComunitaria)
                var contenedorInmediato = this.FindForm();

                // Obtener el formulario principal (top-level) q contiene todo (en este caso ese es fmMenu)
                var formPrincipal = contenedorInmediato?.TopLevelControl as Form;

                if (formPrincipal == null)
                {
                    // Si no se encuentra, cerramos el formulario inmediato
                    contenedorInmediato?.Close();
                    return;
                }

                // 3) Buscar el Panel llamado "panel2" dentro del formulario principal
                var panel2 = formPrincipal.Controls.Find("panel2", true).FirstOrDefault() as Panel;
                if (panel2 == null)
                {
                    // No existe panel2: cerramos el contenedor inmediato para evitar dejar UI bloqueada
                    contenedorInmediato?.Close();
                    return;
                }

                // 4) Limpiar y cargar fmBienvenida embebido en panel2
                panel2.Controls.Clear();
                var bienvenida = new fmBienvenida
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
                panel2.Controls.Add(bienvenida);
                bienvenida.Show();

                // 5) Cerrar el formulario contenedor (fmCocinaComunitaria)
                contenedorInmediato?.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo regresar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
