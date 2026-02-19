namespace AlberSoft.mapaInteractivo
{
    partial class fmMapaEcuador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tablaGeneral = new TableLayoutPanel();
            tablaGeneralF2Botones = new TableLayoutPanel();
            regresar = new PictureBox();
            btnReferencias = new PictureBox();
            vistaWeb = new Microsoft.Web.WebView2.WinForms.WebView2();
            tablaGeneral.SuspendLayout();
            tablaGeneralF2Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)regresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReferencias).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vistaWeb).BeginInit();
            SuspendLayout();
            // 
            // tablaGeneral
            // 
            tablaGeneral.BackColor = Color.White;
            tablaGeneral.ColumnCount = 1;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaGeneral.Controls.Add(tablaGeneralF2Botones, 0, 1);
            tablaGeneral.Controls.Add(vistaWeb, 0, 0);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Margin = new Padding(3, 4, 3, 4);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 2;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tablaGeneral.Size = new Size(914, 715);
            tablaGeneral.TabIndex = 0;
            // 
            // tablaGeneralF2Botones
            // 
            tablaGeneralF2Botones.BackColor = Color.White;
            tablaGeneralF2Botones.ColumnCount = 3;
            tablaGeneralF2Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.3232536F));
            tablaGeneralF2Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.67675F));
            tablaGeneralF2Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tablaGeneralF2Botones.Controls.Add(regresar, 2, 0);
            tablaGeneralF2Botones.Controls.Add(btnReferencias, 0, 0);
            tablaGeneralF2Botones.Dock = DockStyle.Fill;
            tablaGeneralF2Botones.Location = new Point(3, 647);
            tablaGeneralF2Botones.Margin = new Padding(3, 4, 3, 4);
            tablaGeneralF2Botones.Name = "tablaGeneralF2Botones";
            tablaGeneralF2Botones.RowCount = 1;
            tablaGeneralF2Botones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaGeneralF2Botones.Size = new Size(908, 64);
            tablaGeneralF2Botones.TabIndex = 2;
            // 
            // regresar
            // 
            regresar.BackColor = Color.Transparent;
            regresar.Dock = DockStyle.Fill;
            regresar.Image = Properties.Resources.regresar;
            regresar.Location = new Point(784, 4);
            regresar.Margin = new Padding(3, 4, 3, 4);
            regresar.Name = "regresar";
            regresar.Size = new Size(121, 56);
            regresar.SizeMode = PictureBoxSizeMode.Zoom;
            regresar.TabIndex = 10;
            regresar.TabStop = false;
            regresar.Click += regresar_Click;
            // 
            // btnReferencias
            // 
            btnReferencias.Dock = DockStyle.Fill;
            btnReferencias.Image = Properties.Resources.bibliografia;
            btnReferencias.Location = new Point(3, 4);
            btnReferencias.Margin = new Padding(3, 4, 3, 4);
            btnReferencias.Name = "btnReferencias";
            btnReferencias.Size = new Size(74, 56);
            btnReferencias.SizeMode = PictureBoxSizeMode.Zoom;
            btnReferencias.TabIndex = 11;
            btnReferencias.TabStop = false;
            btnReferencias.Click += btnReferencias_Click;
            // 
            // vistaWeb
            // 
            vistaWeb.AllowExternalDrop = true;
            vistaWeb.BackColor = Color.White;
            vistaWeb.CreationProperties = null;
            vistaWeb.DefaultBackgroundColor = Color.White;
            vistaWeb.Dock = DockStyle.Fill;
            vistaWeb.Location = new Point(3, 4);
            vistaWeb.Margin = new Padding(3, 4, 3, 4);
            vistaWeb.Name = "vistaWeb";
            vistaWeb.Size = new Size(908, 635);
            vistaWeb.TabIndex = 1;
            vistaWeb.ZoomFactor = 1D;
            // 
            // fmMapaEcuador
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 715);
            Controls.Add(tablaGeneral);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fmMapaEcuador";
            Text = "fmMapaEcuador";
            tablaGeneral.ResumeLayout(false);
            tablaGeneralF2Botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)regresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReferencias).EndInit();
            ((System.ComponentModel.ISupportInitialize)vistaWeb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablaGeneral;
        private Microsoft.Web.WebView2.WinForms.WebView2 vistaWeb;
        private TableLayoutPanel tablaGeneralF2Botones;
        private PictureBox regresar;
        private PictureBox btnReferencias;
    }
}

