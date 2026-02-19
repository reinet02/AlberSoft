namespace AlberSoft.capacitacionesIlustradas.Juego_de_cartas
{
    partial class ControlCarta
    {
        private System.ComponentModel.IContainer componentes = null;

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            etiquetaTitulo = new Label();
            imagenPrincipal = new PictureBox();
            textoDescripcion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)imagenPrincipal).BeginInit();
            SuspendLayout();
            // 
            // etiquetaTitulo
            // 
            etiquetaTitulo.AutoEllipsis = true;
            etiquetaTitulo.BackColor = Color.FromArgb(250, 250, 250);
            etiquetaTitulo.Dock = DockStyle.Top;
            etiquetaTitulo.Font = new Font("Yu Gothic", 11F, FontStyle.Bold);
            etiquetaTitulo.Location = new Point(6, 6);
            etiquetaTitulo.Name = "etiquetaTitulo";
            etiquetaTitulo.Padding = new Padding(6);
            etiquetaTitulo.Size = new Size(388, 90);
            etiquetaTitulo.TabIndex = 2;
            etiquetaTitulo.Text = "Titulo";
            etiquetaTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // imagenPrincipal
            // 
            imagenPrincipal.BackColor = Color.LightGray;
            imagenPrincipal.Dock = DockStyle.Top;
            imagenPrincipal.Location = new Point(6, 96);
            imagenPrincipal.Margin = new Padding(6);
            imagenPrincipal.Name = "imagenPrincipal";
            imagenPrincipal.Size = new Size(388, 392);
            imagenPrincipal.SizeMode = PictureBoxSizeMode.Zoom;
            imagenPrincipal.TabIndex = 1;
            imagenPrincipal.TabStop = false;
            // 
            // textoDescripcion
            // 
            textoDescripcion.BackColor = Color.White;
            textoDescripcion.BorderStyle = BorderStyle.None;
            textoDescripcion.Dock = DockStyle.Fill;
            textoDescripcion.Font = new Font("Segoe UI", 9F);
            textoDescripcion.Location = new Point(6, 488);
            textoDescripcion.Margin = new Padding(6);
            textoDescripcion.Multiline = true;
            textoDescripcion.Name = "textoDescripcion";
            textoDescripcion.ReadOnly = true;
            textoDescripcion.ScrollBars = ScrollBars.Vertical;
            textoDescripcion.Size = new Size(388, 106);
            textoDescripcion.TabIndex = 0;
            // 
            // ControlCarta
            // 
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(textoDescripcion);
            Controls.Add(imagenPrincipal);
            Controls.Add(etiquetaTitulo);
            Name = "ControlCarta";
            Padding = new Padding(6);
            Size = new Size(400, 600);
            ((System.ComponentModel.ISupportInitialize)imagenPrincipal).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label etiquetaTitulo;
        private PictureBox imagenPrincipal;
        private TextBox textoDescripcion;
    }
}
