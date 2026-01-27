namespace AlberSoft.activadesRecreativas
{
    partial class fmLogoJuegoDePares
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
            tableroGeneral = new TableLayoutPanel();
            logoJuegoDePares = new PictureBox();
            tableroGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoJuegoDePares).BeginInit();
            SuspendLayout();
            // 
            // tableroGeneral
            // 
            tableroGeneral.ColumnCount = 1;
            tableroGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableroGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableroGeneral.Controls.Add(logoJuegoDePares, 0, 0);
            tableroGeneral.Dock = DockStyle.Fill;
            tableroGeneral.Location = new Point(0, 0);
            tableroGeneral.Name = "tableroGeneral";
            tableroGeneral.RowCount = 1;
            tableroGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableroGeneral.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableroGeneral.Size = new Size(974, 617);
            tableroGeneral.TabIndex = 0;
            // 
            // logoJuegoDePares
            // 
            logoJuegoDePares.BackColor = Color.FromArgb(253, 253, 253);
            logoJuegoDePares.Dock = DockStyle.Fill;
            logoJuegoDePares.Image = Properties.Resources.logoJuegoDePares;
            logoJuegoDePares.Location = new Point(3, 3);
            logoJuegoDePares.Name = "logoJuegoDePares";
            logoJuegoDePares.Size = new Size(968, 611);
            logoJuegoDePares.SizeMode = PictureBoxSizeMode.Zoom;
            logoJuegoDePares.TabIndex = 1;
            logoJuegoDePares.TabStop = false;
            // 
            // fmLogoJuegoDePares
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 617);
            Controls.Add(tableroGeneral);
            Name = "fmLogoJuegoDePares";
            Text = "fmLogoJuegoDePares";
            tableroGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logoJuegoDePares).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableroGeneral;
        private PictureBox logoJuegoDePares;
    }
}