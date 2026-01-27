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
            text1 = new CuoreUI.Controls.cuiLabel();
            pbImg = new PictureBox();
            tablaGeneral = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pbImg).BeginInit();
            tablaGeneral.SuspendLayout();
            SuspendLayout();
            // 
            // text1
            // 
            text1.Content = "Your\\ text\\ here!";
            text1.Dock = DockStyle.Fill;
            text1.HorizontalAlignment = StringAlignment.Center;
            text1.Location = new Point(205, 3);
            text1.Margin = new Padding(4, 3, 4, 3);
            text1.Name = "text1";
            text1.Size = new Size(352, 298);
            text1.TabIndex = 0;
            text1.VerticalAlignment = StringAlignment.Near;
            // 
            // pbImg
            // 
            pbImg.Dock = DockStyle.Fill;
            pbImg.Location = new Point(3, 3);
            pbImg.Name = "pbImg";
            pbImg.Size = new Size(195, 298);
            pbImg.TabIndex = 1;
            pbImg.TabStop = false;
            // 
            // tablaGeneral
            // 
            tablaGeneral.ColumnCount = 2;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.9026375F));
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 64.09737F));
            tablaGeneral.Controls.Add(pbImg, 0, 0);
            tablaGeneral.Controls.Add(text1, 1, 0);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 1;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaGeneral.Size = new Size(561, 304);
            tablaGeneral.TabIndex = 2;
            // 
            // fmLosRíos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 304);
            Controls.Add(tablaGeneral);
            Name = "fmLosRíos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fmLosRios";
            ((System.ComponentModel.ISupportInitialize)pbImg).EndInit();
            tablaGeneral.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel text1;
        private PictureBox pbImg;
        private TableLayoutPanel tablaGeneral;
    }
}

