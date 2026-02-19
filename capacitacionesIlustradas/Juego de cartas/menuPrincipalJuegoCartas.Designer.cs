namespace AlberSoft.capacitacionesIlustradas.Juego_de_cartas
{
    partial class menuPrincipalJuegoCartas
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
            labelBienvenida = new CuoreUI.Controls.cuiLabel();
            btnFacil = new CuoreUI.Controls.cuiButton();
            btnIntermedio = new CuoreUI.Controls.cuiButton();
            btnDificil = new CuoreUI.Controls.cuiButton();
            pbLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // labelBienvenida
            // 
            labelBienvenida.Content = "Cartas\\ de\\ Emergencia";
            labelBienvenida.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBienvenida.HorizontalAlignment = StringAlignment.Center;
            labelBienvenida.Location = new Point(216, 8);
            labelBienvenida.Margin = new Padding(4, 3, 4, 3);
            labelBienvenida.Name = "labelBienvenida";
            labelBienvenida.Size = new Size(864, 256);
            labelBienvenida.TabIndex = 0;
            labelBienvenida.VerticalAlignment = StringAlignment.Center;
            // 
            // btnFacil
            // 
            btnFacil.CheckButton = false;
            btnFacil.Checked = false;
            btnFacil.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnFacil.CheckedForeColor = Color.White;
            btnFacil.CheckedImageTint = Color.White;
            btnFacil.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnFacil.Content = "Nivel fácil";
            btnFacil.DialogResult = DialogResult.None;
            btnFacil.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFacil.ForeColor = Color.Black;
            btnFacil.HoverBackground = Color.White;
            btnFacil.HoverForeColor = Color.Black;
            btnFacil.HoverImageTint = Color.White;
            btnFacil.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnFacil.Image = null;
            btnFacil.ImageAutoCenter = true;
            btnFacil.ImageExpand = new Point(0, 0);
            btnFacil.ImageOffset = new Point(0, 0);
            btnFacil.Location = new Point(120, 488);
            btnFacil.Name = "btnFacil";
            btnFacil.NormalBackground = Color.White;
            btnFacil.NormalForeColor = Color.Black;
            btnFacil.NormalImageTint = Color.White;
            btnFacil.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnFacil.OutlineThickness = 1F;
            btnFacil.PressedBackground = Color.WhiteSmoke;
            btnFacil.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnFacil.PressedImageTint = Color.White;
            btnFacil.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnFacil.Rounding = new Padding(8);
            btnFacil.Size = new Size(1088, 96);
            btnFacil.TabIndex = 1;
            btnFacil.TextAlignment = StringAlignment.Center;
            btnFacil.TextOffset = new Point(0, 0);
            btnFacil.Click += btnFacil_Click;
            // 
            // btnIntermedio
            // 
            btnIntermedio.CheckButton = false;
            btnIntermedio.Checked = false;
            btnIntermedio.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnIntermedio.CheckedForeColor = Color.White;
            btnIntermedio.CheckedImageTint = Color.White;
            btnIntermedio.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnIntermedio.Content = "Nivel intermedio";
            btnIntermedio.DialogResult = DialogResult.None;
            btnIntermedio.Font = new Font("Microsoft Sans Serif", 51.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIntermedio.ForeColor = Color.Black;
            btnIntermedio.HoverBackground = Color.White;
            btnIntermedio.HoverForeColor = Color.Black;
            btnIntermedio.HoverImageTint = Color.White;
            btnIntermedio.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnIntermedio.Image = null;
            btnIntermedio.ImageAutoCenter = true;
            btnIntermedio.ImageExpand = new Point(0, 0);
            btnIntermedio.ImageOffset = new Point(0, 0);
            btnIntermedio.Location = new Point(120, 608);
            btnIntermedio.Name = "btnIntermedio";
            btnIntermedio.NormalBackground = Color.White;
            btnIntermedio.NormalForeColor = Color.Black;
            btnIntermedio.NormalImageTint = Color.White;
            btnIntermedio.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnIntermedio.OutlineThickness = 1F;
            btnIntermedio.PressedBackground = Color.WhiteSmoke;
            btnIntermedio.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnIntermedio.PressedImageTint = Color.White;
            btnIntermedio.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnIntermedio.Rounding = new Padding(8);
            btnIntermedio.Size = new Size(1088, 96);
            btnIntermedio.TabIndex = 2;
            btnIntermedio.TextAlignment = StringAlignment.Center;
            btnIntermedio.TextOffset = new Point(0, 0);
            btnIntermedio.Click += btnIntermedio_Click;
            // 
            // btnDificil
            // 
            btnDificil.CheckButton = false;
            btnDificil.Checked = false;
            btnDificil.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnDificil.CheckedForeColor = Color.White;
            btnDificil.CheckedImageTint = Color.White;
            btnDificil.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnDificil.Content = "Nivel difícil";
            btnDificil.DialogResult = DialogResult.None;
            btnDificil.Font = new Font("Microsoft Sans Serif", 51.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDificil.ForeColor = Color.Black;
            btnDificil.HoverBackground = Color.White;
            btnDificil.HoverForeColor = Color.Black;
            btnDificil.HoverImageTint = Color.White;
            btnDificil.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnDificil.Image = null;
            btnDificil.ImageAutoCenter = true;
            btnDificil.ImageExpand = new Point(0, 0);
            btnDificil.ImageOffset = new Point(0, 0);
            btnDificil.Location = new Point(120, 720);
            btnDificil.Name = "btnDificil";
            btnDificil.NormalBackground = Color.White;
            btnDificil.NormalForeColor = Color.Black;
            btnDificil.NormalImageTint = Color.White;
            btnDificil.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnDificil.OutlineThickness = 1F;
            btnDificil.PressedBackground = Color.WhiteSmoke;
            btnDificil.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnDificil.PressedImageTint = Color.White;
            btnDificil.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnDificil.Rounding = new Padding(8);
            btnDificil.Size = new Size(1088, 96);
            btnDificil.TabIndex = 3;
            btnDificil.TextAlignment = StringAlignment.Center;
            btnDificil.TextOffset = new Point(0, 0);
            btnDificil.Click += btnDificil_Click;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.logoJuegoCartas;
            pbLogo.Location = new Point(560, 280);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(216, 184);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 4;
            pbLogo.TabStop = false;
            // 
            // menuPrincipalJuegoCartas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 856);
            Controls.Add(pbLogo);
            Controls.Add(btnDificil);
            Controls.Add(btnIntermedio);
            Controls.Add(btnFacil);
            Controls.Add(labelBienvenida);
            Name = "menuPrincipalJuegoCartas";
            Text = "Menú de Inicio";
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiLabel labelBienvenida;
        private CuoreUI.Controls.cuiButton btnFacil;
        private CuoreUI.Controls.cuiButton btnIntermedio;
        private CuoreUI.Controls.cuiButton btnDificil;
        private PictureBox pbLogo;
    }
}