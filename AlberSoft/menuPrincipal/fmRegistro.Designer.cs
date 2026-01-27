namespace AlberSoft.menuPrincipal
{
    partial class fmRegistro
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
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            tbUsuario = new CuoreUI.Controls.cuiTextBox();
            tbContrasena1 = new CuoreUI.Controls.cuiTextBox();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            tbContrasena2 = new CuoreUI.Controls.cuiTextBox();
            cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            btnRegistrar = new CuoreUI.Controls.cuiButton();
            panel1 = new Panel();
            btnCancelar = new CuoreUI.Controls.cuiButton();
            cbxMostrarContra = new CheckBox();
            cbxMostrarCfmContra = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Registro";
            cuiLabel1.Font = new Font("Arial Black", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(137, 0);
            cuiLabel1.Margin = new Padding(4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(249, 38);
            cuiLabel1.TabIndex = 0;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            cuiLabel2.Content = "Nombre\\ de\\ usuario:";
            cuiLabel2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(28, 85);
            cuiLabel2.Margin = new Padding(4);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(174, 28);
            cuiLabel2.TabIndex = 1;
            cuiLabel2.VerticalAlignment = StringAlignment.Near;
            // 
            // tbUsuario
            // 
            tbUsuario.BackgroundColor = Color.White;
            tbUsuario.Content = "";
            tbUsuario.FocusBackgroundColor = Color.White;
            tbUsuario.FocusImageTint = Color.White;
            tbUsuario.FocusOutlineColor = Color.FromArgb(30, 102, 245);
            tbUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsuario.ForeColor = Color.Black;
            tbUsuario.Image = null;
            tbUsuario.ImageExpand = new Point(0, 0);
            tbUsuario.ImageOffset = new Point(0, 0);
            tbUsuario.Location = new Point(28, 109);
            tbUsuario.Margin = new Padding(4, 3, 4, 3);
            tbUsuario.Multiline = false;
            tbUsuario.Name = "tbUsuario";
            tbUsuario.NormalImageTint = Color.White;
            tbUsuario.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            tbUsuario.Padding = new Padding(19, 12, 19, 0);
            tbUsuario.PasswordChar = false;
            tbUsuario.PlaceholderColor = Color.Gray;
            tbUsuario.PlaceholderText = "usuario";
            tbUsuario.Rounding = new Padding(8);
            tbUsuario.Size = new Size(290, 42);
            tbUsuario.TabIndex = 3;
            tbUsuario.TextOffset = new Size(0, 0);
            tbUsuario.UnderlinedStyle = true;
            // 
            // tbContrasena1
            // 
            tbContrasena1.BackgroundColor = Color.White;
            tbContrasena1.Content = "";
            tbContrasena1.FocusBackgroundColor = Color.White;
            tbContrasena1.FocusImageTint = Color.White;
            tbContrasena1.FocusOutlineColor = Color.FromArgb(30, 102, 245);
            tbContrasena1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbContrasena1.ForeColor = Color.Black;
            tbContrasena1.Image = null;
            tbContrasena1.ImageExpand = new Point(0, 0);
            tbContrasena1.ImageOffset = new Point(0, 0);
            tbContrasena1.Location = new Point(28, 182);
            tbContrasena1.Margin = new Padding(4, 3, 4, 3);
            tbContrasena1.Multiline = false;
            tbContrasena1.Name = "tbContrasena1";
            tbContrasena1.NormalImageTint = Color.White;
            tbContrasena1.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            tbContrasena1.Padding = new Padding(19, 12, 19, 0);
            tbContrasena1.PasswordChar = true;
            tbContrasena1.PlaceholderColor = Color.Gray;
            tbContrasena1.PlaceholderText = "contraseña";
            tbContrasena1.Rounding = new Padding(8);
            tbContrasena1.Size = new Size(290, 42);
            tbContrasena1.TabIndex = 5;
            tbContrasena1.TextOffset = new Size(0, 0);
            tbContrasena1.UnderlinedStyle = true;
            // 
            // cuiLabel4
            // 
            cuiLabel4.Content = "Contraseña:";
            cuiLabel4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(28, 158);
            cuiLabel4.Margin = new Padding(4);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(111, 28);
            cuiLabel4.TabIndex = 4;
            cuiLabel4.VerticalAlignment = StringAlignment.Near;
            // 
            // tbContrasena2
            // 
            tbContrasena2.BackgroundColor = Color.White;
            tbContrasena2.Content = "";
            tbContrasena2.FocusBackgroundColor = Color.White;
            tbContrasena2.FocusImageTint = Color.White;
            tbContrasena2.FocusOutlineColor = Color.FromArgb(30, 102, 245);
            tbContrasena2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbContrasena2.ForeColor = Color.Black;
            tbContrasena2.Image = null;
            tbContrasena2.ImageExpand = new Point(0, 0);
            tbContrasena2.ImageOffset = new Point(0, 0);
            tbContrasena2.Location = new Point(28, 254);
            tbContrasena2.Margin = new Padding(4, 3, 4, 3);
            tbContrasena2.Multiline = false;
            tbContrasena2.Name = "tbContrasena2";
            tbContrasena2.NormalImageTint = Color.White;
            tbContrasena2.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            tbContrasena2.Padding = new Padding(19, 12, 19, 0);
            tbContrasena2.PasswordChar = true;
            tbContrasena2.PlaceholderColor = Color.Gray;
            tbContrasena2.PlaceholderText = "repita su contraseña";
            tbContrasena2.Rounding = new Padding(8);
            tbContrasena2.Size = new Size(290, 42);
            tbContrasena2.TabIndex = 7;
            tbContrasena2.TextOffset = new Size(0, 0);
            tbContrasena2.UnderlinedStyle = true;
            // 
            // cuiLabel5
            // 
            cuiLabel5.Content = "Confirmar\\ contraseña:";
            cuiLabel5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel5.HorizontalAlignment = StringAlignment.Center;
            cuiLabel5.Location = new Point(28, 230);
            cuiLabel5.Margin = new Padding(4);
            cuiLabel5.Name = "cuiLabel5";
            cuiLabel5.Size = new Size(208, 28);
            cuiLabel5.TabIndex = 6;
            cuiLabel5.VerticalAlignment = StringAlignment.Near;
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.Transparent;
            btnRegistrar.CheckButton = false;
            btnRegistrar.Checked = false;
            btnRegistrar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnRegistrar.CheckedForeColor = Color.White;
            btnRegistrar.CheckedImageTint = Color.White;
            btnRegistrar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnRegistrar.Content = "Registrarme";
            btnRegistrar.DialogResult = DialogResult.None;
            btnRegistrar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.ForeColor = Color.Black;
            btnRegistrar.HoverBackground = Color.FromArgb(200, 140, 170, 238);
            btnRegistrar.HoverForeColor = Color.Black;
            btnRegistrar.HoverImageTint = Color.White;
            btnRegistrar.HoverOutline = Color.FromArgb(30, 102, 245);
            btnRegistrar.Image = null;
            btnRegistrar.ImageAutoCenter = true;
            btnRegistrar.ImageExpand = new Point(0, 0);
            btnRegistrar.ImageOffset = new Point(0, 0);
            btnRegistrar.Location = new Point(381, 182);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.NormalBackground = Color.FromArgb(140, 170, 238);
            btnRegistrar.NormalForeColor = Color.Black;
            btnRegistrar.NormalImageTint = Color.White;
            btnRegistrar.NormalOutline = Color.FromArgb(4, 165, 229);
            btnRegistrar.OutlineThickness = 1F;
            btnRegistrar.PressedBackground = Color.WhiteSmoke;
            btnRegistrar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnRegistrar.PressedImageTint = Color.White;
            btnRegistrar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnRegistrar.Rounding = new Padding(8);
            btnRegistrar.Size = new Size(167, 42);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.TextAlignment = StringAlignment.Center;
            btnRegistrar.TextOffset = new Point(0, 0);
            btnRegistrar.Click += cuibtnRegistrarme_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(186, 187, 241);
            panel1.Controls.Add(cuiLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 43);
            panel1.TabIndex = 9;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.CheckButton = false;
            btnCancelar.Checked = false;
            btnCancelar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCancelar.CheckedForeColor = Color.White;
            btnCancelar.CheckedImageTint = Color.White;
            btnCancelar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCancelar.Content = "Cancelar";
            btnCancelar.DialogResult = DialogResult.None;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.HoverBackground = Color.FromArgb(200, 231, 130, 132);
            btnCancelar.HoverForeColor = Color.Black;
            btnCancelar.HoverImageTint = Color.White;
            btnCancelar.HoverOutline = Color.FromArgb(210, 15, 57);
            btnCancelar.Image = null;
            btnCancelar.ImageAutoCenter = true;
            btnCancelar.ImageExpand = new Point(0, 0);
            btnCancelar.ImageOffset = new Point(0, 0);
            btnCancelar.Location = new Point(381, 254);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NormalBackground = Color.FromArgb(231, 130, 132);
            btnCancelar.NormalForeColor = Color.Black;
            btnCancelar.NormalImageTint = Color.White;
            btnCancelar.NormalOutline = Color.FromArgb(210, 15, 57);
            btnCancelar.OutlineThickness = 1F;
            btnCancelar.PressedBackground = Color.WhiteSmoke;
            btnCancelar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCancelar.PressedImageTint = Color.White;
            btnCancelar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCancelar.Rounding = new Padding(8);
            btnCancelar.Size = new Size(167, 42);
            btnCancelar.TabIndex = 10;
            btnCancelar.TextAlignment = StringAlignment.Center;
            btnCancelar.TextOffset = new Point(0, 0);
            btnCancelar.Click += cuibtnCancelar_Click;
            // 
            // cbxMostrarContra
            // 
            cbxMostrarContra.AutoSize = true;
            cbxMostrarContra.Location = new Point(337, 197);
            cbxMostrarContra.Margin = new Padding(3, 2, 3, 2);
            cbxMostrarContra.Name = "cbxMostrarContra";
            cbxMostrarContra.Size = new Size(15, 14);
            cbxMostrarContra.TabIndex = 11;
            cbxMostrarContra.UseVisualStyleBackColor = true;
            cbxMostrarContra.CheckedChanged += cbxMostrarContra_CheckedChanged;
            // 
            // cbxMostrarCfmContra
            // 
            cbxMostrarCfmContra.AutoSize = true;
            cbxMostrarCfmContra.Location = new Point(337, 267);
            cbxMostrarCfmContra.Margin = new Padding(3, 2, 3, 2);
            cbxMostrarCfmContra.Name = "cbxMostrarCfmContra";
            cbxMostrarCfmContra.Size = new Size(15, 14);
            cbxMostrarCfmContra.TabIndex = 12;
            cbxMostrarCfmContra.UseVisualStyleBackColor = true;
            cbxMostrarCfmContra.CheckedChanged += cbxMostrarCfmContra_CheckedChanged;
            // 
            // fmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 340);
            Controls.Add(cbxMostrarCfmContra);
            Controls.Add(cbxMostrarContra);
            Controls.Add(btnCancelar);
            Controls.Add(panel1);
            Controls.Add(btnRegistrar);
            Controls.Add(tbContrasena2);
            Controls.Add(cuiLabel5);
            Controls.Add(tbContrasena1);
            Controls.Add(cuiLabel4);
            Controls.Add(tbUsuario);
            Controls.Add(cuiLabel2);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fmRegistro";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiTextBox tbUsuario;
        private CuoreUI.Controls.cuiTextBox tbContrasena1;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiTextBox tbContrasena2;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiButton btnRegistrar;
        private Panel panel1;
        private CuoreUI.Controls.cuiButton btnCancelar;
        private CheckBox cbxMostrarContra;
        private CheckBox cbxMostrarCfmContra;
    }
}