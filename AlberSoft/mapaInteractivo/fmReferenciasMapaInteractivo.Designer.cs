namespace AlberSoft.mapaInteractivo
{
    partial class fmReferenciasMapaInteractivo
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
            texto1.Content = "Cáritas\\ Ecuador,\\ “Cáritas\\ Ecuador”\\.\\ Consultado:\\ el\\ 21\\ de\\ noviembre\\ de\\ 2025\\.\\ \\[En\\ línea]\\.\\ Disponible\\ en:\\ https://www\\.caritasecuador\\.org/quienes-somos/caritas-en-ecuador/";
            texto1.Dock = DockStyle.Fill;
            texto1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texto1.HorizontalAlignment = StringAlignment.Center;
            texto1.Location = new Point(0, 0);
            texto1.Margin = new Padding(5, 4, 5, 4);
            texto1.Name = "texto1";
            texto1.Size = new Size(585, 613);
            texto1.TabIndex = 0;
            texto1.VerticalAlignment = StringAlignment.Center;
            texto1.Load += texto1_Load;
            // 
            // fmReferenciasMapaInteractivo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 613);
            Controls.Add(texto1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fmReferenciasMapaInteractivo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fmReferencias Mapa Interactivo";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel texto1;
    }
}