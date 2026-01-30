namespace AlberSoft.mapaInteractivo
{
    partial class fmLosRíos
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
            pbImg = new PictureBox();
            tablaGeneral = new TableLayoutPanel();
            lbText1 = new CuoreUI.Controls.cuiLabel();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            tablaGeneral.SuspendLayout();
            SuspendLayout();
            // 
            // pbImg
            // 
            pbImg.Dock = DockStyle.Fill;
            pbImg.Image = Properties.Resources.visible;
            pbImg.Location = new Point(3, 3);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(370, 501);
            pbImg.SizeMode = PictureBoxSizeMode.Zoom;
            pbImg.TabIndex = 1;
            pbImg.TabStop = false;
            // 
            // tablaGeneral
            // 
            tablaGeneral.ColumnCount = 2;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.9026375F));
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.09737F));
            tablaGeneral.Controls.Add(pbImg, 0, 0);
            tablaGeneral.Controls.Add(lbText1, 1, 0);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 1;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaGeneral.Size = new Size(1049, 507);
            tablaGeneral.TabIndex = 2;
            // 
            // lbText1
            // 
            lbText1.Content = "Info";
            lbText1.Dock = DockStyle.Fill;
            lbText1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbText1.HorizontalAlignment = StringAlignment.Center;
            lbText1.Location = new Point(380, 3);
            lbText1.Margin = new Padding(4, 3, 4, 3);
            lbText1.Name = "lbText1";
            lbText1.Size = new Size(665, 501);
            lbText1.TabIndex = 0;
            lbText1.VerticalAlignment = StringAlignment.Near;
            lbText1.Load += lbText1_Load;
            // 
            // fmLosRíos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 507);
            Controls.Add(tablaGeneral);
            Name = "fmLosRíos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fmLosRios";
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            tablaGeneral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pbImg;
        private TableLayoutPanel tablaGeneral;
        private CuoreUI.Controls.cuiLabel lbText1;
    }
}

