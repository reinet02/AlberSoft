using System.Drawing.Drawing2D;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            tableroGeneral = new TableLayoutPanel();
            panel1 = new CuoreUI.Controls.cuiPanelGradient();
            tableroQueContieneAPanel1 = new TableLayoutPanel();
            op2 = new CuoreUI.Controls.cuiLabel();
            icon1 = new PictureBox();
            op4 = new CuoreUI.Controls.cuiLabel();
            op1 = new CuoreUI.Controls.cuiLabel();
            icon2 = new PictureBox();
            op3 = new CuoreUI.Controls.cuiLabel();
            icon3 = new PictureBox();
            icon4 = new PictureBox();
            panel2 = new Panel();
            tableroGeneral.SuspendLayout();
            panel1.SuspendLayout();
            tableroQueContieneAPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)icon1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)icon4).BeginInit();
            SuspendLayout();
            // 
            // tableroGeneral
            // 
            tableroGeneral.ColumnCount = 2;
            tableroGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableroGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableroGeneral.Controls.Add(panel1, 0, 0);
            tableroGeneral.Controls.Add(panel2, 1, 0);
            tableroGeneral.Dock = DockStyle.Fill;
            tableroGeneral.Location = new Point(0, 0);
            tableroGeneral.Name = "tableroGeneral";
            tableroGeneral.RowCount = 1;
            tableroGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableroGeneral.Size = new Size(1862, 951);
            tableroGeneral.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(tableroQueContieneAPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.GradientAngle = 0F;
            panel1.Location = new Point(4, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.OutlineThickness = 1F;
            panel1.PanelColor1 = Color.FromArgb(203, 166, 247);
            panel1.PanelColor2 = Color.FromArgb(180, 190, 254);
            panel1.PanelOutlineColor1 = Color.FromArgb(180, 190, 254);
            panel1.PanelOutlineColor2 = Color.FromArgb(180, 190, 254);
            panel1.RightToLeft = RightToLeft.No;
            panel1.Rounding = new Padding(0);
            panel1.Size = new Size(457, 945);
            panel1.TabIndex = 12;
            // 
            // tableroQueContieneAPanel1
            // 
            tableroQueContieneAPanel1.BackColor = Color.Transparent;
            tableroQueContieneAPanel1.ColumnCount = 2;
            tableroQueContieneAPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableroQueContieneAPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableroQueContieneAPanel1.Controls.Add(op2, 1, 1);
            tableroQueContieneAPanel1.Controls.Add(icon1, 0, 0);
            tableroQueContieneAPanel1.Controls.Add(op4, 1, 3);
            tableroQueContieneAPanel1.Controls.Add(op1, 1, 0);
            tableroQueContieneAPanel1.Controls.Add(icon2, 0, 1);
            tableroQueContieneAPanel1.Controls.Add(op3, 1, 2);
            tableroQueContieneAPanel1.Controls.Add(icon3, 0, 2);
            tableroQueContieneAPanel1.Controls.Add(icon4, 0, 3);
            tableroQueContieneAPanel1.Dock = DockStyle.Fill;
            tableroQueContieneAPanel1.Location = new Point(0, 0);
            tableroQueContieneAPanel1.Name = "tableroQueContieneAPanel1";
            tableroQueContieneAPanel1.RowCount = 5;
            tableroQueContieneAPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableroQueContieneAPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableroQueContieneAPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableroQueContieneAPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableroQueContieneAPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableroQueContieneAPanel1.Size = new Size(457, 945);
            tableroQueContieneAPanel1.TabIndex = 0;
            // 
            // op2
            // 
            op2.BackColor = Color.Transparent;
            op2.Content = "Capacitaciones\\ Ilustrativas";
            op2.Dock = DockStyle.Fill;
            op2.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            op2.ForeColor = SystemColors.Control;
            op2.HorizontalAlignment = StringAlignment.Near;
            op2.Location = new Point(95, 146);
            op2.Margin = new Padding(4, 5, 4, 5);
            op2.Name = "op2";
            op2.Size = new Size(358, 131);
            op2.TabIndex = 14;
            op2.VerticalAlignment = StringAlignment.Center;
            op2.Load += op2_Load;
            // 
            // icon1
            // 
            icon1.Dock = DockStyle.Fill;
            icon1.Image = (Image)resources.GetObject("icon1.Image");
            icon1.Location = new Point(4, 3);
            icon1.Margin = new Padding(4, 3, 4, 3);
            icon1.Name = "icon1";
            icon1.Size = new Size(83, 135);
            icon1.SizeMode = PictureBoxSizeMode.Zoom;
            icon1.TabIndex = 2;
            icon1.TabStop = false;
            icon1.MouseClick += icon1_MouseClick;
            // 
            // op4
            // 
            op4.BackColor = Color.Transparent;
            op4.Content = "Albergues\\ en\\ Ecuador";
            op4.Dock = DockStyle.Fill;
            op4.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            op4.ForeColor = SystemColors.Control;
            op4.HorizontalAlignment = StringAlignment.Near;
            op4.Location = new Point(95, 428);
            op4.Margin = new Padding(4, 5, 4, 5);
            op4.Name = "op4";
            op4.Size = new Size(358, 131);
            op4.TabIndex = 12;
            op4.VerticalAlignment = StringAlignment.Center;
            op4.Load += op4_Load;
            // 
            // op1
            // 
            op1.BackColor = Color.Transparent;
            op1.Content = "Alojamiento\\ e\\ Inventario";
            op1.Dock = DockStyle.Fill;
            op1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            op1.ForeColor = SystemColors.Control;
            op1.HorizontalAlignment = StringAlignment.Near;
            op1.Location = new Point(95, 5);
            op1.Margin = new Padding(4, 5, 4, 5);
            op1.Name = "op1";
            op1.Size = new Size(358, 131);
            op1.TabIndex = 13;
            op1.VerticalAlignment = StringAlignment.Center;
            // 
            // icon2
            // 
            icon2.Dock = DockStyle.Fill;
            icon2.Image = Properties.Resources.capacitacionesIlustrativas_icon;
            icon2.Location = new Point(4, 144);
            icon2.Margin = new Padding(4, 3, 4, 3);
            icon2.Name = "icon2";
            icon2.Size = new Size(83, 135);
            icon2.SizeMode = PictureBoxSizeMode.Zoom;
            icon2.TabIndex = 9;
            icon2.TabStop = false;
            icon2.MouseClick += icon2_MouseClick;
            // 
            // op3
            // 
            op3.BackColor = Color.Transparent;
            op3.Content = "Actividades\\ Recreativas";
            op3.Dock = DockStyle.Fill;
            op3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            op3.ForeColor = SystemColors.Control;
            op3.HorizontalAlignment = StringAlignment.Near;
            op3.Location = new Point(95, 287);
            op3.Margin = new Padding(4, 5, 4, 5);
            op3.Name = "op3";
            op3.Size = new Size(358, 131);
            op3.TabIndex = 15;
            op3.VerticalAlignment = StringAlignment.Center;
            // 
            // icon3
            // 
            icon3.Dock = DockStyle.Fill;
            icon3.Image = (Image)resources.GetObject("icon3.Image");
            icon3.Location = new Point(4, 285);
            icon3.Margin = new Padding(4, 3, 4, 3);
            icon3.Name = "icon3";
            icon3.Size = new Size(83, 135);
            icon3.SizeMode = PictureBoxSizeMode.Zoom;
            icon3.TabIndex = 10;
            icon3.TabStop = false;
            icon3.MouseClick += icon3_MouseClick;
            // 
            // icon4
            // 
            icon4.Dock = DockStyle.Fill;
            icon4.Image = (Image)resources.GetObject("icon4.Image");
            icon4.Location = new Point(4, 426);
            icon4.Margin = new Padding(4, 3, 4, 3);
            icon4.Name = "icon4";
            icon4.Size = new Size(83, 135);
            icon4.SizeMode = PictureBoxSizeMode.Zoom;
            icon4.TabIndex = 11;
            icon4.TabStop = false;
            icon4.MouseClick += icon4_MouseClick;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(468, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1391, 945);
            panel2.TabIndex = 13;
            panel2.Paint += panel2_Paint;
            // 
            // fmMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1862, 951);
            Controls.Add(tableroGeneral);
            Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "fmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += fmMenu_Load;
            tableroGeneral.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableroQueContieneAPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)icon1).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon2).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon3).EndInit();
            ((System.ComponentModel.ISupportInitialize)icon4).EndInit();
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

        private TableLayoutPanel tableroGeneral;
        private CuoreUI.Controls.cuiPanelGradient panel1;
        private TableLayoutPanel tableroQueContieneAPanel1;
        private PictureBox icon1;
        private PictureBox icon2;
        private PictureBox icon3;
        private PictureBox icon4;
        private CuoreUI.Controls.cuiLabel op2;
        private CuoreUI.Controls.cuiLabel op4;
        private CuoreUI.Controls.cuiLabel op1;
        private CuoreUI.Controls.cuiLabel op3;
        private Panel panel2;
    }
}