namespace AlberSoft
{
    partial class fmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmInicioSesion));
            logo = new PictureBox();
            usuario = new CuoreUI.Controls.cuiTextBox();
            contrasena = new CuoreUI.Controls.cuiTextBox();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            linkRegistrar = new LinkLabel();
            linkOlvidasteContra = new LinkLabel();
            btnIniciarSesion = new CuoreUI.Controls.cuiButton();
            tableMain = new TableLayoutPanel();
            tableRight = new TableLayoutPanel();
            flowRegister = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            tableMain.SuspendLayout();
            tableRight.SuspendLayout();
            flowRegister.SuspendLayout();
            SuspendLayout();
            // 
            // logo
            // 
            logo.BackgroundImageLayout = ImageLayout.Stretch;
            logo.Dock = DockStyle.Fill;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(3, 3);
            logo.Name = "logo";
            logo.Size = new Size(1004, 785);
            logo.SizeMode = PictureBoxSizeMode.Zoom;
            logo.TabIndex = 5;
            logo.TabStop = false;
            // 
            // usuario
            // 
            usuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
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
            usuario.Location = new Point(28, 103);
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
            usuario.Size = new Size(612, 45);
            usuario.TabIndex = 7;
            usuario.TextOffset = new Size(0, 0);
            usuario.UnderlinedStyle = true;
            // 
            // contrasena
            // 
            contrasena.BackgroundColor = Color.White;
            contrasena.Content = "";
            contrasena.Dock = DockStyle.Fill;
            contrasena.FocusBackgroundColor = Color.White;
            contrasena.FocusImageTint = Color.White;
            contrasena.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            contrasena.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contrasena.ForeColor = Color.Gray;
            contrasena.Image = null;
            contrasena.ImageExpand = new Point(0, 0);
            contrasena.ImageOffset = new Point(0, 0);
            contrasena.Location = new Point(28, 156);
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
            contrasena.Size = new Size(612, 45);
            contrasena.TabIndex = 8;
            contrasena.TextOffset = new Size(0, 0);
            contrasena.UnderlinedStyle = true;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Anchor = AnchorStyles.Left;
            cuiLabel2.Content = "¿Necesitas\\ una\\ cuenta\\?";
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(4, 12);
            cuiLabel2.Margin = new Padding(4, 12, 4, 3);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(140, 23);
            cuiLabel2.TabIndex = 10;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // linkRegistrar
            // 
            linkRegistrar.AutoSize = true;
            linkRegistrar.Location = new Point(152, 12);
            linkRegistrar.Margin = new Padding(4, 12, 4, 3);
            linkRegistrar.Name = "linkRegistrar";
            linkRegistrar.Size = new Size(64, 15);
            linkRegistrar.TabIndex = 11;
            linkRegistrar.TabStop = true;
            linkRegistrar.Text = "Registrarse";
            linkRegistrar.LinkClicked += linkRegistrar_LinkClicked;
            // 
            // linkOlvidasteContra
            // 
            linkOlvidasteContra.Anchor = AnchorStyles.Left;
            linkOlvidasteContra.AutoSize = true;
            linkOlvidasteContra.Location = new Point(28, 213);
            linkOlvidasteContra.Margin = new Padding(4, 8, 4, 8);
            linkOlvidasteContra.Name = "linkOlvidasteContra";
            linkOlvidasteContra.Size = new Size(159, 15);
            linkOlvidasteContra.TabIndex = 12;
            linkOlvidasteContra.TabStop = true;
            linkOlvidasteContra.Text = "¿Has olvidado la contraseña?";
            linkOlvidasteContra.LinkClicked += linkOlvidasteContra_LinkClicked;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.CheckButton = false;
            btnIniciarSesion.Checked = false;
            btnIniciarSesion.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnIniciarSesion.CheckedForeColor = Color.White;
            btnIniciarSesion.CheckedImageTint = Color.White;
            btnIniciarSesion.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnIniciarSesion.Content = "Iniciar sesión";
            btnIniciarSesion.DialogResult = DialogResult.None;
            btnIniciarSesion.Dock = DockStyle.Fill;
            btnIniciarSesion.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnIniciarSesion.ForeColor = Color.Black;
            btnIniciarSesion.HoverBackground = Color.White;
            btnIniciarSesion.HoverForeColor = Color.Black;
            btnIniciarSesion.HoverImageTint = Color.White;
            btnIniciarSesion.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnIniciarSesion.Image = null;
            btnIniciarSesion.ImageAutoCenter = true;
            btnIniciarSesion.ImageExpand = new Point(0, 0);
            btnIniciarSesion.ImageOffset = new Point(0, 0);
            btnIniciarSesion.Location = new Point(27, 239);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.NormalBackground = Color.White;
            btnIniciarSesion.NormalForeColor = Color.Black;
            btnIniciarSesion.NormalImageTint = Color.White;
            btnIniciarSesion.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnIniciarSesion.OutlineThickness = 1F;
            btnIniciarSesion.PressedBackground = Color.WhiteSmoke;
            btnIniciarSesion.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnIniciarSesion.PressedImageTint = Color.White;
            btnIniciarSesion.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnIniciarSesion.Rounding = new Padding(8);
            btnIniciarSesion.Size = new Size(614, 45);
            btnIniciarSesion.TabIndex = 13;
            btnIniciarSesion.TextAlignment = StringAlignment.Center;
            btnIniciarSesion.TextOffset = new Point(0, 0);
            btnIniciarSesion.Click += btnIngresar_Click;
            // 
            // tableMain
            // 
            tableMain.ColumnCount = 2;
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableMain.Controls.Add(tableRight, 1, 0);
            tableMain.Controls.Add(logo, 0, 0);
            tableMain.Dock = DockStyle.Fill;
            tableMain.Location = new Point(0, 0);
            tableMain.Name = "tableMain";
            tableMain.RowCount = 1;
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableMain.Size = new Size(1684, 791);
            tableMain.TabIndex = 0;
            // 
            // tableRight
            // 
            tableRight.ColumnCount = 1;
            tableRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableRight.Controls.Add(usuario, 0, 1);
            tableRight.Controls.Add(contrasena, 0, 2);
            tableRight.Controls.Add(linkOlvidasteContra, 0, 3);
            tableRight.Controls.Add(btnIniciarSesion, 0, 4);
            tableRight.Controls.Add(flowRegister, 0, 5);
            tableRight.Dock = DockStyle.Fill;
            tableRight.Location = new Point(1013, 3);
            tableRight.Name = "tableRight";
            tableRight.Padding = new Padding(24);
            tableRight.RowCount = 7;
            tableRight.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableRight.RowStyles.Add(new RowStyle());
            tableRight.RowStyles.Add(new RowStyle());
            tableRight.RowStyles.Add(new RowStyle());
            tableRight.RowStyles.Add(new RowStyle());
            tableRight.RowStyles.Add(new RowStyle());
            tableRight.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableRight.Size = new Size(668, 785);
            tableRight.TabIndex = 0;
            // 
            // flowRegister
            // 
            flowRegister.AutoSize = true;
            flowRegister.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowRegister.Controls.Add(cuiLabel2);
            flowRegister.Controls.Add(linkRegistrar);
            flowRegister.Dock = DockStyle.Fill;
            flowRegister.Location = new Point(27, 290);
            flowRegister.Name = "flowRegister";
            flowRegister.Size = new Size(614, 38);
            flowRegister.TabIndex = 14;
            // 
            // fmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1684, 791);
            Controls.Add(tableMain);
            Name = "fmInicioSesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de sesión";
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            tableMain.ResumeLayout(false);
            tableRight.ResumeLayout(false);
            tableRight.PerformLayout();
            flowRegister.ResumeLayout(false);
            flowRegister.PerformLayout();
            ResumeLayout(false);
            #endregion
        }

        private PictureBox logo;
        private CuoreUI.Controls.cuiTextBox usuario;
        private CuoreUI.Controls.cuiTextBox contrasena;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private LinkLabel linkRegistrar;
        private LinkLabel linkOlvidasteContra;
        private CuoreUI.Controls.cuiButton btnIniciarSesion;

        // New container fields for responsive layout
        private TableLayoutPanel tableMain;
        private TableLayoutPanel tableRight;
        private FlowLayoutPanel flowRegister;
    }
}
