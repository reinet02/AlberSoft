namespace AlberSoft.mapaInteractivo
{
    partial class fmPichincha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmPichincha));
            pbImg = new PictureBox();
            tablaGeneral = new TableLayoutPanel();
            tablaTexto = new TableLayoutPanel();
            lbTitulo = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            tablaGoogleMaps = new TableLayoutPanel();
            pbPinUbicacion = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            tablaGeneral.SuspendLayout();
            tablaTexto.SuspendLayout();
            tablaGoogleMaps.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPinUbicacion).BeginInit();
            SuspendLayout();
            // 
            // pbImg
            // 
            pbImg.BackColor = Color.White;
            pbImg.Dock = DockStyle.Fill;
            pbImg.Image = Properties.Resources.Pichincha;
            pbImg.Location = new Point(3, 4);
            pbImg.Margin = new Padding(3, 4, 3, 4);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(424, 779);
            pbImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbImg.TabIndex = 1;
            pbImg.TabStop = false;
            // 
            // tablaGeneral
            // 
            tablaGeneral.BackColor = Color.White;
            tablaGeneral.ColumnCount = 2;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.9026375F));
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.09737F));
            tablaGeneral.Controls.Add(pbImg, 0, 0);
            tablaGeneral.Controls.Add(tablaTexto, 1, 0);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Margin = new Padding(3, 4, 3, 4);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 1;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaGeneral.Size = new Size(1199, 787);
            tablaGeneral.TabIndex = 2;
            tablaGeneral.Paint += tablaGeneral_Paint;
            // 
            // tablaTexto
            // 
            tablaTexto.ColumnCount = 1;
            tablaTexto.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaTexto.Controls.Add(lbTitulo, 0, 0);
            tablaTexto.Controls.Add(cuiLabel1, 0, 1);
            tablaTexto.Controls.Add(tablaGoogleMaps, 0, 2);
            tablaTexto.Dock = DockStyle.Fill;
            tablaTexto.Location = new Point(433, 4);
            tablaTexto.Margin = new Padding(3, 4, 3, 4);
            tablaTexto.Name = "tablaTexto";
            tablaTexto.RowCount = 3;
            tablaTexto.RowStyles.Add(new RowStyle(SizeType.Percent, 5.588822F));
            tablaTexto.RowStyles.Add(new RowStyle(SizeType.Percent, 75.68493F));
            tablaTexto.RowStyles.Add(new RowStyle(SizeType.Percent, 18.8356171F));
            tablaTexto.Size = new Size(763, 779);
            tablaTexto.TabIndex = 3;
            // 
            // lbTitulo
            // 
            lbTitulo.BackColor = Color.FromArgb(242, 205, 205);
            lbTitulo.Content = "Pichincha";
            lbTitulo.Dock = DockStyle.Fill;
            lbTitulo.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.White;
            lbTitulo.HorizontalAlignment = StringAlignment.Center;
            lbTitulo.Location = new Point(5, 4);
            lbTitulo.Margin = new Padding(5, 4, 5, 4);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(753, 35);
            lbTitulo.TabIndex = 0;
            lbTitulo.VerticalAlignment = StringAlignment.Near;
            lbTitulo.Load += lbText1_Load;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.White;
            cuiLabel1.Content = resources.GetString("cuiLabel1.Content");
            cuiLabel1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(5, 47);
            cuiLabel1.Margin = new Padding(5, 4, 5, 4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(753, 580);
            cuiLabel1.TabIndex = 1;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // tablaGoogleMaps
            // 
            tablaGoogleMaps.ColumnCount = 3;
            tablaGoogleMaps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tablaGoogleMaps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tablaGoogleMaps.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tablaGoogleMaps.Controls.Add(pbPinUbicacion, 1, 0);
            tablaGoogleMaps.Dock = DockStyle.Fill;
            tablaGoogleMaps.Location = new Point(3, 635);
            tablaGoogleMaps.Margin = new Padding(3, 4, 3, 4);
            tablaGoogleMaps.Name = "tablaGoogleMaps";
            tablaGoogleMaps.RowCount = 1;
            tablaGoogleMaps.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaGoogleMaps.Size = new Size(757, 140);
            tablaGoogleMaps.TabIndex = 2;
            // 
            // pbPinUbicacion
            // 
            pbPinUbicacion.Dock = DockStyle.Fill;
            pbPinUbicacion.Image = Properties.Resources.pinUbicacion;
            pbPinUbicacion.Location = new Point(255, 4);
            pbPinUbicacion.Margin = new Padding(3, 4, 3, 4);
            pbPinUbicacion.Name = "pbPinUbicacion";
            pbPinUbicacion.Size = new Size(246, 132);
            pbPinUbicacion.SizeMode = PictureBoxSizeMode.Zoom;
            pbPinUbicacion.TabIndex = 0;
            pbPinUbicacion.TabStop = false;
            pbPinUbicacion.Click += pbPinUbicacion_Click;
            // 
            // fmPichincha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1199, 787);
            Controls.Add(tablaGeneral);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fmPichincha";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fmPichincha";
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            tablaGeneral.ResumeLayout(false);
            tablaTexto.ResumeLayout(false);
            tablaGoogleMaps.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPinUbicacion).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbImg;
        private TableLayoutPanel tablaGeneral;
        private CuoreUI.Controls.cuiLabel lbTitulo;
        private TableLayoutPanel tablaTexto;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private TableLayoutPanel tablaGoogleMaps;
        private PictureBox pbPinUbicacion;
    }
}

