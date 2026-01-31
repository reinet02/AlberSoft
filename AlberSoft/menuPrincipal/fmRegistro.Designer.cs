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
            tablaGeneral = new TableLayoutPanel();
            tablaContienPanel = new TableLayoutPanel();
            panel1 = new CuoreUI.Controls.cuiPanel();
            tablaElementosPanel = new TableLayoutPanel();
            enlaceInicarSesion = new LinkLabel();
            lbTitulo = new CuoreUI.Controls.cuiLabel();
            tablaUsuario = new TableLayoutPanel();
            lbAsterisco1 = new CuoreUI.Controls.cuiLabel();
            lbUsuario = new CuoreUI.Controls.cuiLabel();
            tbUsuario = new CuoreUI.Controls.cuiTextBox();
            tablaContrasena = new TableLayoutPanel();
            lbAsterisco2 = new CuoreUI.Controls.cuiLabel();
            lbContrasena = new CuoreUI.Controls.cuiLabel();
            tbContrasena = new CuoreUI.Controls.cuiTextBox();
            btnCrearCuenta = new CuoreUI.Controls.cuiButton();
            tablaGeneral.SuspendLayout();
            tablaContienPanel.SuspendLayout();
            panel1.SuspendLayout();
            tablaElementosPanel.SuspendLayout();
            tablaUsuario.SuspendLayout();
            tablaContrasena.SuspendLayout();
            SuspendLayout();
            // 
            // tablaGeneral
            // 
            tablaGeneral.BackColor = Color.White;
            tablaGeneral.ColumnCount = 3;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tablaGeneral.Controls.Add(tablaContienPanel, 1, 0);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 1;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaGeneral.Size = new Size(1684, 791);
            tablaGeneral.TabIndex = 0;
            // 
            // tablaContienPanel
            // 
            tablaContienPanel.ColumnCount = 1;
            tablaContienPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaContienPanel.Controls.Add(panel1, 0, 1);
            tablaContienPanel.Dock = DockStyle.Fill;
            tablaContienPanel.Location = new Point(592, 3);
            tablaContienPanel.Name = "tablaContienPanel";
            tablaContienPanel.RowCount = 3;
            tablaContienPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            tablaContienPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 98F));
            tablaContienPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 1F));
            tablaContienPanel.Size = new Size(499, 785);
            tablaContienPanel.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(tablaElementosPanel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 10);
            panel1.Name = "panel1";
            panel1.OutlineThickness = 1F;
            panel1.PanelColor = Color.FromArgb(108, 112, 134);
            panel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            panel1.Rounding = new Padding(8);
            panel1.Size = new Size(493, 763);
            panel1.TabIndex = 0;
            // 
            // tablaElementosPanel
            // 
            tablaElementosPanel.ColumnCount = 3;
            tablaElementosPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tablaElementosPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 90F));
            tablaElementosPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tablaElementosPanel.Controls.Add(enlaceInicarSesion, 1, 9);
            tablaElementosPanel.Controls.Add(lbTitulo, 1, 1);
            tablaElementosPanel.Controls.Add(tablaUsuario, 1, 2);
            tablaElementosPanel.Controls.Add(tbUsuario, 1, 3);
            tablaElementosPanel.Controls.Add(tablaContrasena, 1, 4);
            tablaElementosPanel.Controls.Add(tbContrasena, 1, 5);
            tablaElementosPanel.Controls.Add(btnCrearCuenta, 1, 7);
            tablaElementosPanel.Dock = DockStyle.Fill;
            tablaElementosPanel.Location = new Point(0, 0);
            tablaElementosPanel.Name = "tablaElementosPanel";
            tablaElementosPanel.RowCount = 11;
            tablaElementosPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 3.09382081F));
            tablaElementosPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.32826948F));
            tablaElementosPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5.696272F));
            tablaElementosPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.391321F));
            tablaElementosPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5.56064558F));
            tablaElementosPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 6.5217557F));
            tablaElementosPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5652885F));
            tablaElementosPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 7.190383F));
            tablaElementosPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 2.86957216F));
            tablaElementosPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 4.30435848F));
            tablaElementosPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23.4783173F));
            tablaElementosPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tablaElementosPanel.Size = new Size(493, 763);
            tablaElementosPanel.TabIndex = 0;
            tablaElementosPanel.Paint += tablaElementosPanel_Paint;
            // 
            // enlaceInicarSesion
            // 
            enlaceInicarSesion.AutoSize = true;
            enlaceInicarSesion.Dock = DockStyle.Fill;
            enlaceInicarSesion.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enlaceInicarSesion.LinkColor = Color.FromArgb(180, 190, 254);
            enlaceInicarSesion.Location = new Point(27, 545);
            enlaceInicarSesion.Name = "enlaceInicarSesion";
            enlaceInicarSesion.Size = new Size(437, 32);
            enlaceInicarSesion.TabIndex = 0;
            enlaceInicarSesion.TabStop = true;
            enlaceInicarSesion.Text = "¿Ya tienes una cuenta? Inicia sesión";
            enlaceInicarSesion.TextAlign = ContentAlignment.MiddleLeft;
            enlaceInicarSesion.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lbTitulo
            // 
            lbTitulo.Content = "Crear\\ una\\ cuenta";
            lbTitulo.Dock = DockStyle.Fill;
            lbTitulo.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.White;
            lbTitulo.HorizontalAlignment = StringAlignment.Center;
            lbTitulo.Location = new Point(28, 26);
            lbTitulo.Margin = new Padding(4, 3, 4, 3);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(435, 42);
            lbTitulo.TabIndex = 0;
            lbTitulo.VerticalAlignment = StringAlignment.Center;
            // 
            // tablaUsuario
            // 
            tablaUsuario.ColumnCount = 3;
            tablaUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.8421059F));
            tablaUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.949657F));
            tablaUsuario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.2082367F));
            tablaUsuario.Controls.Add(lbAsterisco1, 1, 0);
            tablaUsuario.Controls.Add(lbUsuario, 0, 0);
            tablaUsuario.Dock = DockStyle.Fill;
            tablaUsuario.Location = new Point(27, 74);
            tablaUsuario.Name = "tablaUsuario";
            tablaUsuario.RowCount = 1;
            tablaUsuario.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaUsuario.Size = new Size(437, 37);
            tablaUsuario.TabIndex = 1;
            // 
            // lbAsterisco1
            // 
            lbAsterisco1.Content = "*";
            lbAsterisco1.Dock = DockStyle.Fill;
            lbAsterisco1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAsterisco1.ForeColor = Color.FromArgb(243, 139, 168);
            lbAsterisco1.HorizontalAlignment = StringAlignment.Center;
            lbAsterisco1.Location = new Point(165, 3);
            lbAsterisco1.Margin = new Padding(4, 3, 4, 3);
            lbAsterisco1.Name = "lbAsterisco1";
            lbAsterisco1.Size = new Size(18, 31);
            lbAsterisco1.TabIndex = 2;
            lbAsterisco1.VerticalAlignment = StringAlignment.Far;
            // 
            // lbUsuario
            // 
            lbUsuario.Content = "Nombre\\ de\\ usuario";
            lbUsuario.Dock = DockStyle.Fill;
            lbUsuario.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lbUsuario.ForeColor = Color.White;
            lbUsuario.HorizontalAlignment = StringAlignment.Near;
            lbUsuario.Location = new Point(4, 3);
            lbUsuario.Margin = new Padding(4, 3, 4, 3);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(153, 31);
            lbUsuario.TabIndex = 1;
            lbUsuario.VerticalAlignment = StringAlignment.Far;
            // 
            // tbUsuario
            // 
            tbUsuario.BackgroundColor = Color.White;
            tbUsuario.Content = "";
            tbUsuario.Dock = DockStyle.Fill;
            tbUsuario.FocusBackgroundColor = Color.White;
            tbUsuario.FocusImageTint = Color.White;
            tbUsuario.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            tbUsuario.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbUsuario.ForeColor = Color.Gray;
            tbUsuario.Image = null;
            tbUsuario.ImageExpand = new Point(0, 0);
            tbUsuario.ImageOffset = new Point(0, 0);
            tbUsuario.Location = new Point(28, 118);
            tbUsuario.Margin = new Padding(4);
            tbUsuario.Multiline = false;
            tbUsuario.Name = "tbUsuario";
            tbUsuario.NormalImageTint = Color.White;
            tbUsuario.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            tbUsuario.Padding = new Padding(16, 12, 16, 0);
            tbUsuario.PasswordChar = false;
            tbUsuario.PlaceholderColor = Color.LightGray;
            tbUsuario.PlaceholderText = "";
            tbUsuario.Rounding = new Padding(8);
            tbUsuario.Size = new Size(435, 40);
            tbUsuario.TabIndex = 3;
            tbUsuario.TextOffset = new Size(0, 0);
            tbUsuario.UnderlinedStyle = true;
            tbUsuario.ContentChanged += tbUsuario_ContentChanged;
            // 
            // tablaContrasena
            // 
            tablaContrasena.ColumnCount = 3;
            tablaContrasena.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.7139587F));
            tablaContrasena.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5.949657F));
            tablaContrasena.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.33639F));
            tablaContrasena.Controls.Add(lbAsterisco2, 1, 0);
            tablaContrasena.Controls.Add(lbContrasena, 0, 0);
            tablaContrasena.Dock = DockStyle.Fill;
            tablaContrasena.Location = new Point(27, 165);
            tablaContrasena.Name = "tablaContrasena";
            tablaContrasena.RowCount = 1;
            tablaContrasena.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaContrasena.Size = new Size(437, 36);
            tablaContrasena.TabIndex = 2;
            // 
            // lbAsterisco2
            // 
            lbAsterisco2.Content = "*";
            lbAsterisco2.Dock = DockStyle.Fill;
            lbAsterisco2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAsterisco2.ForeColor = Color.FromArgb(243, 139, 168);
            lbAsterisco2.HorizontalAlignment = StringAlignment.Center;
            lbAsterisco2.Location = new Point(112, 3);
            lbAsterisco2.Margin = new Padding(4, 3, 4, 3);
            lbAsterisco2.Name = "lbAsterisco2";
            lbAsterisco2.Size = new Size(18, 30);
            lbAsterisco2.TabIndex = 3;
            lbAsterisco2.VerticalAlignment = StringAlignment.Far;
            // 
            // lbContrasena
            // 
            lbContrasena.Content = "Contraseña";
            lbContrasena.Dock = DockStyle.Fill;
            lbContrasena.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            lbContrasena.ForeColor = Color.White;
            lbContrasena.HorizontalAlignment = StringAlignment.Near;
            lbContrasena.Location = new Point(4, 3);
            lbContrasena.Margin = new Padding(4, 3, 4, 3);
            lbContrasena.Name = "lbContrasena";
            lbContrasena.Size = new Size(100, 30);
            lbContrasena.TabIndex = 2;
            lbContrasena.VerticalAlignment = StringAlignment.Far;
            // 
            // tbContrasena
            // 
            tbContrasena.BackgroundColor = Color.White;
            tbContrasena.Content = "";
            tbContrasena.Dock = DockStyle.Fill;
            tbContrasena.FocusBackgroundColor = Color.White;
            tbContrasena.FocusImageTint = Color.White;
            tbContrasena.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            tbContrasena.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbContrasena.ForeColor = Color.White;
            tbContrasena.Image = null;
            tbContrasena.ImageExpand = new Point(0, 0);
            tbContrasena.ImageOffset = new Point(0, 0);
            tbContrasena.Location = new Point(28, 208);
            tbContrasena.Margin = new Padding(4);
            tbContrasena.Multiline = false;
            tbContrasena.Name = "tbContrasena";
            tbContrasena.NormalImageTint = Color.White;
            tbContrasena.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            tbContrasena.Padding = new Padding(16, 12, 16, 0);
            tbContrasena.PasswordChar = false;
            tbContrasena.PlaceholderColor = Color.LightGray;
            tbContrasena.PlaceholderText = "";
            tbContrasena.Rounding = new Padding(8);
            tbContrasena.Size = new Size(435, 41);
            tbContrasena.TabIndex = 4;
            tbContrasena.TextOffset = new Size(0, 0);
            tbContrasena.UnderlinedStyle = true;
            // 
            // btnCrearCuenta
            // 
            btnCrearCuenta.CheckButton = false;
            btnCrearCuenta.Checked = false;
            btnCrearCuenta.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnCrearCuenta.CheckedForeColor = Color.White;
            btnCrearCuenta.CheckedImageTint = Color.White;
            btnCrearCuenta.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnCrearCuenta.Content = "Crear una cuenta";
            btnCrearCuenta.DialogResult = DialogResult.None;
            btnCrearCuenta.Dock = DockStyle.Fill;
            btnCrearCuenta.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearCuenta.ForeColor = Color.White;
            btnCrearCuenta.HoverBackground = Color.White;
            btnCrearCuenta.HoverForeColor = Color.Black;
            btnCrearCuenta.HoverImageTint = Color.White;
            btnCrearCuenta.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnCrearCuenta.Image = null;
            btnCrearCuenta.ImageAutoCenter = true;
            btnCrearCuenta.ImageExpand = new Point(0, 0);
            btnCrearCuenta.ImageOffset = new Point(0, 0);
            btnCrearCuenta.Location = new Point(27, 473);
            btnCrearCuenta.Name = "btnCrearCuenta";
            btnCrearCuenta.NormalBackground = Color.FromArgb(180, 190, 254);
            btnCrearCuenta.NormalForeColor = Color.White;
            btnCrearCuenta.NormalImageTint = Color.White;
            btnCrearCuenta.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnCrearCuenta.OutlineThickness = 1F;
            btnCrearCuenta.PressedBackground = Color.WhiteSmoke;
            btnCrearCuenta.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCrearCuenta.PressedImageTint = Color.White;
            btnCrearCuenta.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCrearCuenta.Rounding = new Padding(8);
            btnCrearCuenta.Size = new Size(437, 48);
            btnCrearCuenta.TabIndex = 0;
            btnCrearCuenta.TextAlignment = StringAlignment.Center;
            btnCrearCuenta.TextOffset = new Point(0, 0);
            // 
            // fmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 791);
            Controls.Add(tablaGeneral);
            Name = "fmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fmRegistro";
            tablaGeneral.ResumeLayout(false);
            tablaContienPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tablaElementosPanel.ResumeLayout(false);
            tablaElementosPanel.PerformLayout();
            tablaUsuario.ResumeLayout(false);
            tablaContrasena.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablaGeneral;
        private CuoreUI.Controls.cuiPanel panel1;
        private TableLayoutPanel tablaElementosPanel;
        private TableLayoutPanel tablaContrasena;
        private CuoreUI.Controls.cuiLabel lbAsterisco2;
        private CuoreUI.Controls.cuiLabel lbContrasena;
        private CuoreUI.Controls.cuiTextBox tbUsuario;
        private CuoreUI.Controls.cuiTextBox tbContrasena;
        private CuoreUI.Controls.cuiButton btnCrearCuenta;
        private LinkLabel enlaceInicarSesion;
        private CuoreUI.Controls.cuiLabel lbTitulo;
        private TableLayoutPanel tablaUsuario;
        private CuoreUI.Controls.cuiLabel lbAsterisco1;
        private CuoreUI.Controls.cuiLabel lbUsuario;
        private TableLayoutPanel tablaContienPanel;
    }
}