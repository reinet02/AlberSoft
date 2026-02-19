namespace AlberSoft.alojamientoEInventario
{
    partial class TutorialCrucigrama
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
            pctInformacion = new PictureBox();
            btnAtras = new Button();
            btnSiguiente = new Button();
            btnVolver = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)pctInformacion).BeginInit();
            SuspendLayout();
            // 
            // pctInformacion
            // 
            pctInformacion.Location = new Point(1, 2);
            pctInformacion.Name = "pctInformacion";
            pctInformacion.Size = new Size(915, 506);
            pctInformacion.SizeMode = PictureBoxSizeMode.StretchImage;
            pctInformacion.TabIndex = 0;
            pctInformacion.TabStop = false;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.FromArgb(33, 150, 243);
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAtras.ForeColor = Color.White;
            btnAtras.Location = new Point(12, 514);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(140, 42);
            btnAtras.TabIndex = 271;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.BackColor = Color.FromArgb(33, 150, 243);
            btnSiguiente.FlatStyle = FlatStyle.Flat;
            btnSiguiente.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSiguiente.ForeColor = Color.White;
            btnSiguiente.Location = new Point(187, 514);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(140, 42);
            btnSiguiente.TabIndex = 272;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = false;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnVolver
            // 
            btnVolver.AutoSize = true;
            btnVolver.BackColor = Color.Transparent;
            btnVolver.CheckButton = false;
            btnVolver.Checked = false;
            btnVolver.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnVolver.CheckedForeColor = Color.White;
            btnVolver.CheckedImageTint = Color.White;
            btnVolver.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnVolver.Content = "Volver";
            btnVolver.DialogResult = DialogResult.None;
            btnVolver.Font = new Font("Arial Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.White;
            btnVolver.HoverBackground = Color.FromArgb(200, 243, 139, 168);
            btnVolver.HoverForeColor = Color.WhiteSmoke;
            btnVolver.HoverImageTint = Color.White;
            btnVolver.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnVolver.Image = null;
            btnVolver.ImageAutoCenter = true;
            btnVolver.ImageExpand = new Point(0, 0);
            btnVolver.ImageOffset = new Point(0, 0);
            btnVolver.Location = new Point(767, 514);
            btnVolver.Name = "btnVolver";
            btnVolver.NormalBackground = Color.Red;
            btnVolver.NormalForeColor = Color.White;
            btnVolver.NormalImageTint = Color.White;
            btnVolver.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnVolver.OutlineThickness = 1F;
            btnVolver.PressedBackground = Color.FromArgb(243, 139, 168);
            btnVolver.PressedForeColor = Color.White;
            btnVolver.PressedImageTint = Color.White;
            btnVolver.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnVolver.Rounding = new Padding(8);
            btnVolver.Size = new Size(140, 42);
            btnVolver.TabIndex = 273;
            btnVolver.TextAlignment = StringAlignment.Center;
            btnVolver.TextOffset = new Point(0, 0);
            btnVolver.Click += btnVolver_Click;
            // 
            // TutorialCrucigrama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(159, 147, 140);
            ClientSize = new Size(919, 561);
            Controls.Add(btnVolver);
            Controls.Add(btnSiguiente);
            Controls.Add(btnAtras);
            Controls.Add(pctInformacion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TutorialCrucigrama";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TutorialCrucigrama";
            ((System.ComponentModel.ISupportInitialize)pctInformacion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pctInformacion;
        private Button btnAtras;
        private Button btnSiguiente;
        private CuoreUI.Controls.cuiButton btnVolver;
    }
}