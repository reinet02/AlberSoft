namespace AlberSoft.mapaInteractivo
{
    partial class fmReferenciasPreguntasQuiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmReferenciasPreguntasQuiz));
            texto01 = new CuoreUI.Controls.cuiLabel();
            SuspendLayout();
            // 
            // texto01
            // 
            texto01.Content = resources.GetString("texto01.Content");
            texto01.Dock = DockStyle.Fill;
            texto01.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            texto01.HorizontalAlignment = StringAlignment.Center;
            texto01.Location = new Point(0, 0);
            texto01.Margin = new Padding(5, 4, 5, 4);
            texto01.Name = "texto01";
            texto01.Size = new Size(800, 450);
            texto01.TabIndex = 1;
            texto01.VerticalAlignment = StringAlignment.Center;
            // 
            // fmReferenciasPreguntasQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(texto01);
            Name = "fmReferenciasPreguntasQuiz";
            Text = "fmReferenciasPreguntasQuiz";
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel texto01;
    }
}