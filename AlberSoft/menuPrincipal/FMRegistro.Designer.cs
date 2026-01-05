namespace AlberSoft
{
    partial class fmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmRegistro));
            logo = new PictureBox();
            usuario = new CuoreUI.Controls.cuiTextBox();
            contrasena = new CuoreUI.Controls.cuiTextBox();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            cuiButton1 = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // logo
            // 
            logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(570, 51);
            logo.Name = "logo";
            logo.Size = new Size(493, 378);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 5;
            logo.TabStop = false;
            logo.Click += pictureBox1_Click;
            // 
            // usuario
            // 
            usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usuario.BackgroundColor = Color.White;
            usuario.Content = "";
            usuario.FocusBackgroundColor = Color.White;
            usuario.FocusImageTint = Color.White;
            usuario.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            usuario.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usuario.ForeColor = Color.Gray;
            usuario.Image = null;
            usuario.ImageExpand = new Point(0, 0);
            usuario.ImageOffset = new Point(0, 0);
            usuario.Location = new Point(666, 439);
            usuario.Margin = new Padding(4);
            usuario.Multiline = false;
            usuario.Name = "usuario";
            usuario.NormalImageTint = Color.White;
            usuario.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            usuario.Padding = new Padding(16, 14, 16, 0);
            usuario.PasswordChar = false;
            usuario.PlaceholderColor = Color.LightGray;
            usuario.PlaceholderText = "Nombre de usuario";
            usuario.Rounding = new Padding(8);
            usuario.Size = new Size(297, 45);
            usuario.TabIndex = 7;
            usuario.TextOffset = new Size(0, 0);
            usuario.UnderlinedStyle = true;
            // 
            // contrasena
            // 
            contrasena.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contrasena.BackgroundColor = Color.White;
            contrasena.Content = "";
            contrasena.FocusBackgroundColor = Color.White;
            contrasena.FocusImageTint = Color.White;
            contrasena.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            contrasena.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contrasena.ForeColor = Color.Gray;
            contrasena.Image = null;
            contrasena.ImageExpand = new Point(0, 0);
            contrasena.ImageOffset = new Point(0, 0);
            contrasena.Location = new Point(666, 509);
            contrasena.Margin = new Padding(4);
            contrasena.Multiline = false;
            contrasena.Name = "contrasena";
            contrasena.NormalImageTint = Color.White;
            contrasena.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            contrasena.Padding = new Padding(16, 14, 16, 0);
            contrasena.PasswordChar = true;
            contrasena.PlaceholderColor = Color.LightGray;
            contrasena.PlaceholderText = "Contraseña";
            contrasena.Rounding = new Padding(8);
            contrasena.Size = new Size(297, 45);
            contrasena.TabIndex = 8;
            contrasena.TextOffset = new Size(0, 0);
            contrasena.UnderlinedStyle = true;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cuiLabel2.Content = "¿Necesitas\\ una\\ cuenta\\?";
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(666, 639);
            cuiLabel2.Margin = new Padding(4, 3, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(149, 23);
            cuiLabel2.TabIndex = 10;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(806, 639);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(64, 15);
            linkLabel1.TabIndex = 11;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Registrarse";
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(666, 558);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(159, 15);
            linkLabel2.TabIndex = 12;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "¿Has olvidado la contraseña?";
            // 
            // cuiButton1
            // 
            cuiButton1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cuiButton1.CheckButton = false;
            cuiButton1.Checked = false;
            cuiButton1.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuiButton1.CheckedForeColor = Color.White;
            cuiButton1.CheckedImageTint = Color.White;
            cuiButton1.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuiButton1.Content = "Iniciar sesión";
            cuiButton1.DialogResult = DialogResult.None;
            cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
            cuiButton1.ForeColor = Color.Black;
            cuiButton1.HoverBackground = Color.White;
            cuiButton1.HoverForeColor = Color.Black;
            cuiButton1.HoverImageTint = Color.White;
            cuiButton1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuiButton1.Image = null;
            cuiButton1.ImageAutoCenter = true;
            cuiButton1.ImageExpand = new Point(0, 0);
            cuiButton1.ImageOffset = new Point(0, 0);
            cuiButton1.Location = new Point(666, 589);
            cuiButton1.Name = "cuiButton1";
            cuiButton1.NormalBackground = Color.White;
            cuiButton1.NormalForeColor = Color.Black;
            cuiButton1.NormalImageTint = Color.White;
            cuiButton1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.OutlineThickness = 1F;
            cuiButton1.PressedBackground = Color.WhiteSmoke;
            cuiButton1.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuiButton1.PressedImageTint = Color.White;
            cuiButton1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuiButton1.Rounding = new Padding(8);
            cuiButton1.Size = new Size(297, 45);
            cuiButton1.TabIndex = 13;
            cuiButton1.TextAlignment = StringAlignment.Center;
            cuiButton1.TextOffset = new Point(0, 0);
            cuiButton1.Click += btnIngresar_Click;
            // 
            // fmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1490, 791);
            Controls.Add(logo);
            Controls.Add(cuiButton1);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(cuiLabel2);
            Controls.Add(contrasena);
            Controls.Add(usuario);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "fmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesión";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox logo;
        private CuoreUI.Controls.cuiTextBox usuario;
        private CuoreUI.Controls.cuiTextBox contrasena;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private CuoreUI.Controls.cuiButton cuiButton1;
    }
}
