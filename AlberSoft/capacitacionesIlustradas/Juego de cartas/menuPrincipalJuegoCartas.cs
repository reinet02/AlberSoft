using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AlberSoft.capacitacionesIlustradas;
using System.Linq;

namespace AlberSoft.capacitacionesIlustradas.Juego_de_cartas
{
    public partial class menuPrincipalJuegoCartas : Form
    {
        public menuPrincipalJuegoCartas()
        {
            InitializeComponent();

            // asegurar que los botones abran el formulario del juego
            if (btnFacil != null) btnFacil.Click += btnFacil_Click;
            if (btnIntermedio != null) btnIntermedio.Click += btnIntermedio_Click; // ya ligado en el diseñador, pero aseguramos
            if (btnDificil != null) btnDificil.Click += btnDificil_Click;
        }

        private void AbrirJuegoCartas(int indiceNivel)
        {
            var frm = new fmJuegoCartasEmergencias();

            // indicar al formulario el nivel seleccionado (0=fácil,1=intermedio,2=difícil)
            frm.NivelSeleccionado = indiceNivel;

            // Duración por nivel (segundos): 0 = fácil, 1 = intermedio, 2 = difícil
            int segundos = indiceNivel switch
            {
                0 => 360, // 6 minutos
                1 => 300, // 5 minutos
                2 => 240, // 4 minutos
                _ => 300
            };
            frm.ConfigurarDuracionNivel(segundos);
            // permitir que las cartas regresen del tablero (comportamiento por defecto)
            frm.ConfigurarPermitirRegreso(true);

            // Insertar el formulario dentro del panel del menú principal (como el resto de formularios)
            // Buscar el formulario principal para reusar su método de inserción `abrirFormularioHijo`
            try
            {
                // Buscar específicamente la instancia de fmMenu abierta y usar su método para embeder el formulario
                var main = Application.OpenForms.Cast<Form>().FirstOrDefault(f => f.GetType().Name == "fmMenu");
                if (main != null)
                {
                    var tipoMain = main.GetType();
                    var metodo = tipoMain.GetMethod("abrirFormularioHijo", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public);
                    if (metodo != null)
                    {
                        frm.ConfigurarDuracionNivel(segundos);
                        frm.ConfigurarPermitirRegreso(true);
                        metodo.Invoke(main, new object[] { frm });
                        frm.IniciarJuego();
                        return;
                    }
                }

                // Fallback a ShowDialog si no encontramos fmMenu o el método
                frm.StartPosition = FormStartPosition.CenterParent;
                this.Hide();
                try { frm.ShowDialog(this); } finally { this.Show(); }
            }
            catch
            {
                // En caso de error, fallback a modal
                frm.StartPosition = FormStartPosition.CenterParent;
                this.Hide();
                try { frm.ShowDialog(this); } finally { this.Show(); }
            }
        }

        private void btnFacil_Click(object? sender, EventArgs e)
        {
            AbrirJuegoCartas(0);
        }

        private void btnIntermedio_Click(object? sender, EventArgs e)
        {
            AbrirJuegoCartas(1);
        }

        private void btnDificil_Click(object? sender, EventArgs e)
        {
            AbrirJuegoCartas(2);
        }
    }
}
