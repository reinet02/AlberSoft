namespace AlberSoft
{
    partial class fmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMenu));
            panel1 = new CuoreUI.Controls.cuiPanelGradient();
            op4 = new CuoreUI.Controls.cuiLabel();
            icon4 = new PictureBox();
            op1 = new CuoreUI.Controls.cuiLabel();
            op2 = new CuoreUI.Controls.cuiLabel();
            op3 = new CuoreUI.Controls.cuiLabel();
            icon1 = new PictureBox();
            icon2 = new PictureBox();
            icon3 = new PictureBox();
            bienvenida = new CuoreUI.Controls.cuiLabel();
            logo = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(op4);
            panel1.Controls.Add(icon4);
            panel1.Controls.Add(op1);
            panel1.Controls.Add(op2);
            panel1.Controls.Add(op3);
            panel1.Controls.Add(icon1);
            panel1.Controls.Add(icon2);
            panel1.Controls.Add(icon3);
            panel1.GradientAngle = 0F;
            panel1.Location = new Point(-8, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.OutlineThickness = 1F;
            panel1.PanelColor1 = Color.FromArgb(203, 166, 247);
            panel1.PanelColor2 = Color.FromArgb(180, 190, 254);
            panel1.PanelOutlineColor1 = Color.FromArgb(180, 190, 254);
            panel1.PanelOutlineColor2 = Color.FromArgb(180, 190, 254);
            panel1.RightToLeft = RightToLeft.No;
            panel1.Rounding = new Padding(0);
            panel1.Size = new Size(531, 992);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // op4
            // 
            op4.BackColor = SystemColors.ActiveCaptionText;
            op4.Content = "Mapa\\ Interactivo";
            op4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            op4.ForeColor = SystemColors.Control;
            op4.HorizontalAlignment = StringAlignment.Near;
            op4.Location = new Point(160, 488);
            op4.Margin = new Padding(4, 5, 4, 5);
            op4.Name = "op4";
            op4.Size = new Size(350, 40);
            op4.TabIndex = 1;
            op4.VerticalAlignment = StringAlignment.Near;
            // 
            // icon4
            // 
            icon4.Image = (Image)resources.GetObject("icon4.Image");
            icon4.Location = new Point(48, 464);
            icon4.Margin = new Padding(4, 3, 4, 3);
            icon4.Name = "icon4";
            icon4.Size = new Size(88, 85);
            icon4.SizeMode = PictureBoxSizeMode.StretchImage;
            icon4.TabIndex = 0;
            icon4.TabStop = false;
            // 
            // op1
            // 
            op1.BackColor = SystemColors.ActiveCaptionText;
            op1.Content = "Alojamiento\\ e\\ Inventario";
            op1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            op1.ForeColor = SystemColors.Control;
            op1.HorizontalAlignment = StringAlignment.Near;
            op1.Location = new Point(160, 80);
            op1.Margin = new Padding(4, 5, 4, 5);
            op1.Name = "op1";
            op1.Size = new Size(350, 40);
            op1.TabIndex = 1;
            op1.VerticalAlignment = StringAlignment.Near;
            // 
            // op2
            // 
            op2.BackColor = SystemColors.ActiveCaptionText;
            op2.Content = "Capacitaciones\\ Ilustrativas";
            op2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            op2.ForeColor = SystemColors.Control;
            op2.HorizontalAlignment = StringAlignment.Near;
            op2.Location = new Point(160, 216);
            op2.Margin = new Padding(4, 5, 4, 5);
            op2.Name = "op2";
            op2.Size = new Size(350, 40);
            op2.TabIndex = 1;
            op2.VerticalAlignment = StringAlignment.Near;
            // 
            // op3
            // 
            op3.BackColor = SystemColors.ActiveCaptionText;
            op3.Content = "Actividades\\ Recreativas";
            op3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            op3.ForeColor = SystemColors.Control;
            op3.HorizontalAlignment = StringAlignment.Near;
            op3.Location = new Point(160, 352);
            op3.Margin = new Padding(4, 5, 4, 5);
            op3.Name = "op3";
            op3.Size = new Size(350, 40);
            op3.TabIndex = 1;
            op3.VerticalAlignment = StringAlignment.Near;
            // 
            // icon1
            // 
            icon1.Image = (Image)resources.GetObject("icon1.Image");
            icon1.Location = new Point(40, 48);
            icon1.Margin = new Padding(4, 3, 4, 3);
            icon1.Name = "icon1";
            icon1.Size = new Size(103, 104);
            icon1.SizeMode = PictureBoxSizeMode.StretchImage;
            icon1.TabIndex = 0;
            icon1.TabStop = false;
            icon1.MouseClick += icon1_MouseClick;
            // 
            // icon2
            // 
            icon2.Image = Properties.Resources.capacitacionesIlustrativas_icon;
            icon2.Location = new Point(40, 192);
            icon2.Margin = new Padding(4, 3, 4, 3);
            icon2.Name = "icon2";
            icon2.Size = new Size(103, 85);
            icon2.SizeMode = PictureBoxSizeMode.StretchImage;
            icon2.TabIndex = 0;
            icon2.TabStop = false;
            icon2.MouseClick += icon2_MouseClick;
            // 
            // icon3
            // 
            icon3.Image = (Image)resources.GetObject("icon3.Image");
            icon3.Location = new Point(40, 328);
            icon3.Margin = new Padding(4, 3, 4, 3);
            icon3.Name = "icon3";
            icon3.Size = new Size(96, 85);
            icon3.SizeMode = PictureBoxSizeMode.StretchImage;
            icon3.TabIndex = 0;
            icon3.TabStop = false;
            // 
            // bienvenida
            // 
            bienvenida.Content = "Testy";
            bienvenida.Font = new Font("Microsoft Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bienvenida.ForeColor = SystemColors.ActiveCaptionText;
            bienvenida.HorizontalAlignment = StringAlignment.Center;
            bienvenida.Location = new Point(544, 752);
            bienvenida.Margin = new Padding(4, 3, 4, 3);
            bienvenida.Name = "bienvenida";
            bienvenida.Size = new Size(1296, 104);
            bienvenida.TabIndex = 3;
            bienvenida.VerticalAlignment = StringAlignment.Near;
            bienvenida.Load += cuiLabel1_Load;
            // 
            // logo
            // 
            logo.BackColor = Color.Transparent;
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(768, 48);
            logo.Margin = new Padding(4, 3, 4, 3);
            logo.Name = "logo";
            logo.Size = new Size(816, 672);
            logo.TabIndex = 4;
            logo.TabStop = false;
            // 
            // fmMenu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1862, 989);
            Controls.Add(logo);
            Controls.Add(bienvenida);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(5);
            Name = "fmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon4).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon2).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon3).EndInit();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            ResumeLayout(false);
        }

        private void logo_Click(object sender, EventArgs e)
        {
            // Aquí puedes agregar la lógica que desees ejecutar al hacer clic en el logo.
        }

        // Agrega este método al archivo para manejar el evento Load de los cuiLabel
        private void cuiLabel2_Load(object sender, EventArgs e)
        {
            // Puedes dejarlo vacío o agregar lógica específica si lo necesitas.
        }
        #endregion

        private CuoreUI.Controls.cuiPanelGradient panel1;
        private CuoreUI.Controls.cuiLabel bienvenida;
        private PictureBox logo;
        private PictureBox icon2;
        private CuoreUI.Controls.cuiLabel op2;
        private CuoreUI.Controls.cuiLabel op4;
        private PictureBox icon4;
        private CuoreUI.Controls.cuiLabel op1;
        private CuoreUI.Controls.cuiLabel op3;
        private PictureBox icon1;
        private PictureBox icon3;
    }
}