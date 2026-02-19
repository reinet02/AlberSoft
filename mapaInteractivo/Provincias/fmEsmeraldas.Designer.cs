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
            tableLayoutPanel1 = new TableLayoutPanel();
            ubimapa3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            tablaGeneral.SuspendLayout();
            tablaTexto.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ubimapa3).BeginInit();
            SuspendLayout();
            // 
            // pbImg
            // 
            pbImg.BackColor = Color.White;
            pbImg.Dock = DockStyle.Fill;
            pbImg.Image = Properties.Resources.Esmeraldas;
            pbImg.Location = new Point(3, 4);
            pbImg.Margin = new Padding(3, 4, 3, 4);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(426, 727);
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
            tablaGeneral.Margin = new Padding(3, 4, 3, 4);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 1;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaGeneral.Size = new Size(1210, 735);
            tablaGeneral.TabIndex = 2;
            tablaGeneral.Paint += tablaGeneral_Paint;
            // 
            // tablaTexto
            // 
            tablaTexto.ColumnCount = 1;
            tablaTexto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaTexto.Controls.Add(lbTitulo, 0, 0);
            tablaTexto.Controls.Add(cuiLabel1, 0, 1);
            tablaTexto.Controls.Add(tableLayoutPanel1, 0, 2);
            tablaTexto.Dock = DockStyle.Fill;
            tablaTexto.Location = new Point(435, 4);
            tablaTexto.Margin = new Padding(3, 4, 3, 4);
            tablaTexto.Name = "tablaTexto";
            tablaTexto.RowCount = 3;
            tablaTexto.RowStyles.Add(new RowStyle(SizeType.Percent, 6.46492434F));
            tablaTexto.RowStyles.Add(new RowStyle(SizeType.Percent, 74.828064F));
            tablaTexto.RowStyles.Add(new RowStyle(SizeType.Percent, 18.8445663F));
            tablaTexto.Size = new Size(772, 727);
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
            lbTitulo.Location = new Point(5, 4);
            lbTitulo.Margin = new Padding(5, 4, 5, 4);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(762, 38);
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
            cuiLabel1.Location = new Point(5, 50);
            cuiLabel1.Margin = new Padding(5, 4, 5, 4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(762, 535);
            cuiLabel1.TabIndex = 1;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(ubimapa3, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 592);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(766, 132);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // ubimapa3
            // 
            ubimapa3.Dock = DockStyle.Fill;
            ubimapa3.Image = Properties.Resources.pinUbicacion;
            ubimapa3.Location = new Point(258, 3);
            ubimapa3.Name = "ubimapa3";
            ubimapa3.Size = new Size(249, 126);
            ubimapa3.SizeMode = PictureBoxSizeMode.Zoom;
            ubimapa3.TabIndex = 0;
            ubimapa3.TabStop = false;
            ubimapa3.Click += ubimapa3_Click;
            // 
            // fmEsmeraldas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 735);
            Controls.Add(tablaGeneral);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fmEsmeraldas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fmEsmeraldas";
            Load += fmEsmeraldas_Load;
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            tablaGeneral.ResumeLayout(false);
            tablaTexto.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ubimapa3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbImg;
        private TableLayoutPanel tablaGeneral;
        private CuoreUI.Controls.cuiLabel lbTitulo;
        private TableLayoutPanel tablaTexto;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox ubimapa3;
    }
}

