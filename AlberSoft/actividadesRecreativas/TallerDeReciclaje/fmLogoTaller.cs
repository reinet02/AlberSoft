using AlberSoft.actividadesRecreativas.TallerDeReciclaje;

namespace AlberSoft.actividadesRecreativas
{
    public partial class fmLogoTaller : Form
    {
        public fmLogoTaller()
        {
            InitializeComponent();
        }

        #region Función para regresar (mostar a otro formulario)
        // Botón "volver" — cerrar este formulario y mostrar otro
        private void regresar_Click(object sender, EventArgs e)
        {
            // 1) Intentar encontrar la instancia de fmMenu entre los formularios abiertos
            var menu = Application.OpenForms.OfType<fmMenu>().FirstOrDefault();
            if (menu != null)
            {
                // Buscar panel2 dentro de fmMenu (busca por nombre en toda la jerarquía de controles)
                var panel2 = menu.Controls.Find("panel2", true).FirstOrDefault() as Panel;
                if (panel2 != null)
                {
                    panel2.Controls.Clear();

                    var bienvenida = new menuPrincipal.fmBienvenida
                    {
                        TopLevel = false,
                        FormBorderStyle = FormBorderStyle.None,
                        Dock = DockStyle.Fill
                    };

                    panel2.Controls.Add(bienvenida);
                    bienvenida.Show();
                    return;
                }
            }

            // 2) Si no se encontró fmMenu.panel2, usar el panel padre inmediato (si existe)
            var parentPanel = this.Parent as Panel;
            if (parentPanel != null)
            {
                parentPanel.Controls.Clear();

                var bienvenida = new menuPrincipal.fmBienvenida
                {
                    TopLevel = false,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };

                parentPanel.Controls.Add(bienvenida);
                bienvenida.Show();
                return;
            }

            // 3) Fallback final: abrir como ventana independiente
            new menuPrincipal.fmBienvenida().Show();
        }
        #endregion

        private void btnReferencias_Click(object sender, EventArgs e)
        {
            Form referenciasForm = new fmReferenciasManualidades();
            referenciasForm.Show();
        }
    }
}
