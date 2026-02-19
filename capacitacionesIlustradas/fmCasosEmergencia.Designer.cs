namespace AlberSoft
{
    partial class fmCasosEmergencia
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            rtbDescripcion = new CuoreUI.Controls.cuiLabel();
            tablaBotones = new TableLayoutPanel();
            btnReferencias = new PictureBox();
            regresar = new PictureBox();
            tablaGeneral = new TableLayoutPanel();
            webViewCarrusel = new Microsoft.Web.WebView2.WinForms.WebView2();
            tablaBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnReferencias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)regresar).BeginInit();
            tablaGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webViewCarrusel).BeginInit();
            SuspendLayout();
            // 
            // rtbDescripcion
            // 
            rtbDescripcion.Content = "";
            rtbDescripcion.Dock = DockStyle.Fill;
            rtbDescripcion.Font = new Font("Segoe UI", 10F);
            rtbDescripcion.HorizontalAlignment = StringAlignment.Near;
            rtbDescripcion.Location = new Point(0, 0);
            rtbDescripcion.Margin = new Padding(4, 3, 4, 3);
            rtbDescripcion.Name = "rtbDescripcion";
            rtbDescripcion.Size = new Size(245, 54);
            rtbDescripcion.TabIndex = 0;
            rtbDescripcion.VerticalAlignment = StringAlignment.Near;
            // 
            // tablaBotones
            // 
            tablaBotones.ColumnCount = 3;
            tablaBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tablaBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tablaBotones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tablaBotones.Controls.Add(regresar, 2, 0);
            tablaBotones.Controls.Add(btnReferencias, 0, 0);
            tablaBotones.Dock = DockStyle.Fill;
            tablaBotones.Location = new Point(3, 647);
            tablaBotones.Name = "tablaBotones";
            tablaBotones.RowCount = 1;
            tablaBotones.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaBotones.Size = new Size(894, 50);
            tablaBotones.TabIndex = 1;
            // 
            // btnReferencias
            // 
            btnReferencias.Dock = DockStyle.Fill;
            btnReferencias.Image = Properties.Resources.bibliografia;
            btnReferencias.Location = new Point(3, 3);
            btnReferencias.Name = "btnReferencias";
            btnReferencias.Size = new Size(83, 44);
            btnReferencias.SizeMode = PictureBoxSizeMode.Zoom;
            btnReferencias.TabIndex = 1;
            btnReferencias.TabStop = false;
            btnReferencias.Click += btnReferencias_Click;
            // 
            // regresar
            // 
            regresar.Dock = DockStyle.Fill;
            regresar.Image = Properties.Resources.regresar;
            regresar.Location = new Point(807, 3);
            regresar.Name = "regresar";
            regresar.Size = new Size(84, 44);
            regresar.SizeMode = PictureBoxSizeMode.Zoom;
            regresar.TabIndex = 0;
            regresar.TabStop = false;
            regresar.Click += regresar_Click;
            // 
            // tablaGeneral
            // 
            tablaGeneral.BackColor = Color.White;
            tablaGeneral.ColumnCount = 1;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaGeneral.Controls.Add(tablaBotones, 0, 1);
            tablaGeneral.Controls.Add(webViewCarrusel, 0, 0);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 2;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tablaGeneral.Size = new Size(900, 700);
            tablaGeneral.TabIndex = 0;
            // 
            // webViewCarrusel
            // 
            webViewCarrusel.AllowExternalDrop = true;
            webViewCarrusel.CreationProperties = null;
            webViewCarrusel.DefaultBackgroundColor = Color.White;
            webViewCarrusel.Dock = DockStyle.Fill;
            webViewCarrusel.Location = new Point(3, 3);
            webViewCarrusel.Name = "webViewCarrusel";
            webViewCarrusel.Size = new Size(894, 638);
            webViewCarrusel.TabIndex = 2;
            webViewCarrusel.ZoomFactor = 1D;
            // 
            // fmCasosEmergencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(900, 700);
            Controls.Add(tablaGeneral);
            Name = "fmCasosEmergencia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Casos de Emergencia";
            tablaBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnReferencias).EndInit();
            ((System.ComponentModel.ISupportInitialize)regresar).EndInit();
            tablaGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)webViewCarrusel).EndInit();
            ResumeLayout(false);
        }
        private CuoreUI.Controls.cuiLabel rtbDescripcion;
        private TableLayoutPanel tablaBotones;
        private PictureBox regresar;
        private PictureBox btnReferencias;
        private TableLayoutPanel tablaGeneral;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewCarrusel;
    }
}
