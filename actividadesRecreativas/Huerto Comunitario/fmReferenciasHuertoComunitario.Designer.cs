namespace AlberSoft.actividadesRecreativas.HuertoComunitario
{
    partial class fmReferenciasHuertoComunitario
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
            texto1 = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // texto1
            // 
            texto1.Content = "PictureThis,\\ “ENCILOPEDIA\\ DE\\ PLANTAS”,\\ \\[En\\ línea]\\.\\ Disponible:\\ https://www\\.picturethisai\\.com/es/wiki";
            texto1.Dock = DockStyle.Fill;
            texto1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texto1.HorizontalAlignment = StringAlignment.Center;
            texto1.Location = new Point(0, 0);
            texto1.Margin = new Padding(4, 3, 4, 3);
            texto1.Name = "texto1";
            texto1.Size = new Size(512, 460);
            texto1.TabIndex = 0;
            texto1.VerticalAlignment = StringAlignment.Center;
            texto1.Load += texto1_Load;
            // 
            // fmReferenciasHuertoComunitario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 460);
            Controls.Add(texto1);
            Name = "fmReferenciasHuertoComunitario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Referencias de Huerto Comunitario";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel texto1;
    }
}