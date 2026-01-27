namespace AlberSoft.menuPrincipal
{
    partial class fmBienvenida
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
            bienvenida = new CuoreUI.Controls.cuiLabel();
            tablaGeneral = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tablaGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bienvenida
            // 
            bienvenida.Content = "Test!";
            bienvenida.Dock = DockStyle.Fill;
            bienvenida.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bienvenida.HorizontalAlignment = StringAlignment.Center;
            bienvenida.Location = new Point(4, 611);
            bienvenida.Margin = new Padding(4, 3, 4, 3);
            bienvenida.Name = "bienvenida";
            bienvenida.Size = new Size(1074, 147);
            bienvenida.TabIndex = 0;
            bienvenida.VerticalAlignment = StringAlignment.Near;
            // 
            // tablaGeneral
            // 
            tablaGeneral.ColumnCount = 1;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tablaGeneral.Controls.Add(bienvenida, 0, 1);
            tablaGeneral.Controls.Add(pictureBox1, 0, 0);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 2;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tablaGeneral.Size = new Size(1082, 761);
            tablaGeneral.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1076, 602);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // fmBienvenida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 761);
            Controls.Add(tablaGeneral);
            Name = "fmBienvenida";
            Text = "fmBienvenida";
            tablaGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel bienvenida;
        private TableLayoutPanel tablaGeneral;
        private PictureBox pictureBox1;
    }
}

