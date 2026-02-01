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
            vistaWeb = new Microsoft.Web.WebView2.WinForms.WebView2();
            tablaGeneralF2Botones = new TableLayoutPanel();
            regresar = new PictureBox();
            tablaGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vistaWeb).BeginInit();
            tablaGeneralF2Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)regresar).BeginInit();
            SuspendLayout();
            // 
            // tablaGeneral
            // 
            tablaGeneral.BackColor = Color.White;
            tablaGeneral.ColumnCount = 1;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaGeneral.Controls.Add(vistaWeb, 0, 0);
            tablaGeneral.Controls.Add(tablaGeneralF2Botones, 0, 1);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 2;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 88.99254F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 11.0074625F));
            tablaGeneral.Size = new Size(800, 536);
            tablaGeneral.TabIndex = 0;
            // 
            // vistaWeb
            // 
            vistaWeb.AllowExternalDrop = true;
            vistaWeb.BackColor = Color.White;
            vistaWeb.CreationProperties = null;
            vistaWeb.DefaultBackgroundColor = Color.White;
            vistaWeb.Dock = DockStyle.Fill;
            vistaWeb.Location = new Point(3, 3);
            vistaWeb.Name = "vistaWeb";
            vistaWeb.Size = new Size(794, 471);
            vistaWeb.TabIndex = 1;
            vistaWeb.ZoomFactor = 1D;
            // 
            // tablaGeneralF2Botones
            // 
            tablaGeneralF2Botones.BackColor = Color.White;
            tablaGeneralF2Botones.ColumnCount = 3;
            tablaGeneralF2Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.50646F));
            tablaGeneralF2Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.49354F));
            tablaGeneralF2Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tablaGeneralF2Botones.Controls.Add(regresar, 2, 0);
            tablaGeneralF2Botones.Dock = DockStyle.Fill;
            tablaGeneralF2Botones.Location = new Point(3, 480);
            tablaGeneralF2Botones.Name = "tablaGeneralF2Botones";
            tablaGeneralF2Botones.RowCount = 1;
            tablaGeneralF2Botones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaGeneralF2Botones.Size = new Size(794, 53);
            tablaGeneralF2Botones.TabIndex = 2;
            // 
            // regresar
            // 
            regresar.BackColor = Color.Transparent;
            regresar.Dock = DockStyle.Fill;
            regresar.Image = Properties.Resources.regresar;
            regresar.Location = new Point(724, 3);
            regresar.Name = "regresar";
            regresar.Size = new Size(67, 47);
            regresar.SizeMode = PictureBoxSizeMode.Zoom;
            regresar.TabIndex = 11;
            regresar.TabStop = false;
            regresar.Click += regresar_Click;
            // 
            // fmMapaEcuador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 536);
            Controls.Add(tablaGeneral);
            Name = "fmMapaEcuador";
            Text = "fmMapaEcuador";
            tablaGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)vistaWeb).EndInit();
            tablaGeneralF2Botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)regresar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablaGeneral;
        private Microsoft.Web.WebView2.WinForms.WebView2 vistaWeb;
        private TableLayoutPanel tablaGeneralF2Botones;
        private PictureBox regresar;
    }
}

