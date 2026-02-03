namespace AlberSoft.mapaInteractivo
{
    partial class fmEsmeraldas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmEsmeraldas));
            pbImg = new PictureBox();
            tablaGeneral = new TableLayoutPanel();
            tablaTexto = new TableLayoutPanel();
            lbTitulo = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            tablaGeneral.SuspendLayout();
            tablaTexto.SuspendLayout();
            SuspendLayout();
            // 
            // pbImg
            // 
            pbImg.BackColor = Color.White;
            pbImg.Dock = DockStyle.Fill;
            pbImg.Image = Properties.Resources.Esmeraldas;
            pbImg.Location = new Point(3, 3);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(369, 501);
            pbImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbImg.TabIndex = 1;
            pbImg.TabStop = false;
            // 
            // tablaGeneral
            // 
            tablaGeneral.BackColor = Color.White;
            tablaGeneral.ColumnCount = 2;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.748333F));
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.25167F));
            tablaGeneral.Controls.Add(pbImg, 0, 0);
            tablaGeneral.Controls.Add(tablaTexto, 1, 0);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 1;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaGeneral.Size = new Size(1049, 507);
            tablaGeneral.TabIndex = 2;
            tablaGeneral.Paint += tablaGeneral_Paint;
            // 
            // tablaTexto
            // 
            tablaTexto.ColumnCount = 1;
            tablaTexto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaTexto.Controls.Add(lbTitulo, 0, 0);
            tablaTexto.Controls.Add(cuiLabel1, 0, 1);
            tablaTexto.Dock = DockStyle.Fill;
            tablaTexto.Location = new Point(378, 3);
            tablaTexto.Name = "tablaTexto";
            tablaTexto.RowCount = 2;
            tablaTexto.RowStyles.Add(new RowStyle(SizeType.Percent, 8.383233F));
            tablaTexto.RowStyles.Add(new RowStyle(SizeType.Percent, 91.61677F));
            tablaTexto.Size = new Size(668, 501);
            tablaTexto.TabIndex = 3;
            // 
            // lbTitulo
            // 
            lbTitulo.BackColor = Color.FromArgb(245, 194, 231);
            lbTitulo.Content = "\\ Esmeraldas";
            lbTitulo.Dock = DockStyle.Fill;
            lbTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.White;
            lbTitulo.HorizontalAlignment = StringAlignment.Center;
            lbTitulo.Location = new Point(4, 3);
            lbTitulo.Margin = new Padding(4, 3, 4, 3);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(660, 36);
            lbTitulo.TabIndex = 0;
            lbTitulo.VerticalAlignment = StringAlignment.Near;
            lbTitulo.Load += lbText1_Load;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.White;
            cuiLabel1.Content = resources.GetString("cuiLabel1.Content");
            cuiLabel1.Dock = DockStyle.Fill;
            cuiLabel1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(4, 45);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(660, 453);
            cuiLabel1.TabIndex = 1;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // fmEsmeraldas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 507);
            Controls.Add(tablaGeneral);
            Name = "fmEsmeraldas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fmEsmeraldas";
            Load += fmEsmeraldas_Load;
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            tablaGeneral.ResumeLayout(false);
            tablaTexto.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbImg;
        private TableLayoutPanel tablaGeneral;
        private CuoreUI.Controls.cuiLabel lbTitulo;
        private TableLayoutPanel tablaTexto;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
    }
}

