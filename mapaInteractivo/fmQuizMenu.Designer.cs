namespace AlberSoft.mapaInteractivo
{
    partial class fmQuizMenu
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label = new CuoreUI.Controls.cuiLabel();
            btn1 = new CuoreUI.Controls.cuiButton();
            btn2 = new CuoreUI.Controls.cuiButton();
            btn3 = new CuoreUI.Controls.cuiButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnReferencias1 = new PictureBox();
            regresar1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnReferencias1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)regresar1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label, 0, 0);
            tableLayoutPanel1.Controls.Add(btn1, 0, 1);
            tableLayoutPanel1.Controls.Add(btn2, 0, 2);
            tableLayoutPanel1.Controls.Add(btn3, 0, 3);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.0927582F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.8551464F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.6175346F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.6175346F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.6899614F));
            tableLayoutPanel1.Size = new Size(1382, 787);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label
            // 
            label.BackColor = Color.White;
            label.Content = "¡Bienvenido\\ al\\ Quiz!";
            label.Dock = DockStyle.Fill;
            label.Font = new Font("Microsoft Sans Serif", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.HorizontalAlignment = StringAlignment.Center;
            label.Location = new Point(5, 4);
            label.Margin = new Padding(5, 4, 5, 4);
            label.Name = "label";
            label.Size = new Size(1372, 158);
            label.TabIndex = 0;
            label.VerticalAlignment = StringAlignment.Near;
            label.Load += cuiLabel1_Load;
            // 
            // btn1
            // 
            btn1.Anchor = AnchorStyles.None;
            btn1.CheckButton = false;
            btn1.Checked = false;
            btn1.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn1.CheckedForeColor = Color.White;
            btn1.CheckedImageTint = Color.White;
            btn1.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn1.Content = "Nivel fácil";
            btn1.DialogResult = DialogResult.None;
            btn1.Font = new Font("Microsoft Sans Serif", 20.25F);
            btn1.ForeColor = SystemColors.ControlText;
            btn1.HoverBackground = Color.FromArgb(200, 166, 209, 137);
            btn1.HoverForeColor = Color.Black;
            btn1.HoverImageTint = Color.White;
            btn1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn1.Image = null;
            btn1.ImageAutoCenter = true;
            btn1.ImageExpand = new Point(0, 0);
            btn1.ImageOffset = new Point(0, 0);
            btn1.Location = new Point(296, 175);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.NormalBackground = Color.FromArgb(166, 209, 137);
            btn1.NormalForeColor = SystemColors.ControlText;
            btn1.NormalImageTint = Color.White;
            btn1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn1.OutlineThickness = 1F;
            btn1.PressedBackground = Color.WhiteSmoke;
            btn1.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn1.PressedImageTint = Color.White;
            btn1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn1.Rounding = new Padding(8);
            btn1.Size = new Size(790, 154);
            btn1.TabIndex = 1;
            btn1.TextAlignment = StringAlignment.Center;
            btn1.TextOffset = new Point(0, 0);
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Anchor = AnchorStyles.None;
            btn2.CheckButton = false;
            btn2.Checked = false;
            btn2.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn2.CheckedForeColor = Color.White;
            btn2.CheckedImageTint = Color.White;
            btn2.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn2.Content = "Nivel intermedio";
            btn2.DialogResult = DialogResult.None;
            btn2.Font = new Font("Microsoft Sans Serif", 20.25F);
            btn2.ForeColor = Color.Black;
            btn2.HoverBackground = Color.FromArgb(200, 229, 200, 144);
            btn2.HoverForeColor = Color.Black;
            btn2.HoverImageTint = Color.White;
            btn2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn2.Image = null;
            btn2.ImageAutoCenter = true;
            btn2.ImageExpand = new Point(0, 0);
            btn2.ImageOffset = new Point(0, 0);
            btn2.Location = new Point(296, 350);
            btn2.Margin = new Padding(3, 4, 3, 4);
            btn2.Name = "btn2";
            btn2.NormalBackground = Color.FromArgb(229, 200, 144);
            btn2.NormalForeColor = Color.Black;
            btn2.NormalImageTint = Color.White;
            btn2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn2.OutlineThickness = 1F;
            btn2.PressedBackground = Color.WhiteSmoke;
            btn2.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn2.PressedImageTint = Color.White;
            btn2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn2.Rounding = new Padding(8);
            btn2.Size = new Size(790, 154);
            btn2.TabIndex = 2;
            btn2.TextAlignment = StringAlignment.Center;
            btn2.TextOffset = new Point(0, 0);
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Anchor = AnchorStyles.None;
            btn3.CheckButton = false;
            btn3.Checked = false;
            btn3.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn3.CheckedForeColor = Color.White;
            btn3.CheckedImageTint = Color.White;
            btn3.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn3.Content = "Nivel difícil";
            btn3.DialogResult = DialogResult.None;
            btn3.Font = new Font("Microsoft Sans Serif", 20.25F);
            btn3.ForeColor = Color.Black;
            btn3.HoverBackground = Color.FromArgb(200, 231, 130, 132);
            btn3.HoverForeColor = Color.Black;
            btn3.HoverImageTint = Color.White;
            btn3.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn3.Image = null;
            btn3.ImageAutoCenter = true;
            btn3.ImageExpand = new Point(0, 0);
            btn3.ImageOffset = new Point(0, 0);
            btn3.Location = new Point(296, 531);
            btn3.Margin = new Padding(3, 4, 3, 4);
            btn3.Name = "btn3";
            btn3.NormalBackground = Color.FromArgb(231, 130, 132);
            btn3.NormalForeColor = Color.Black;
            btn3.NormalImageTint = Color.White;
            btn3.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn3.OutlineThickness = 1F;
            btn3.PressedBackground = Color.WhiteSmoke;
            btn3.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn3.PressedImageTint = Color.White;
            btn3.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn3.Rounding = new Padding(8);
            btn3.Size = new Size(790, 147);
            btn3.TabIndex = 3;
            btn3.TextAlignment = StringAlignment.Center;
            btn3.TextOffset = new Point(0, 0);
            btn3.Click += btn3_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.32F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.68F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 126F));
            tableLayoutPanel2.Controls.Add(btnReferencias1, 0, 0);
            tableLayoutPanel2.Controls.Add(regresar1, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 697);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1376, 87);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // btnReferencias1
            // 
            btnReferencias1.Dock = DockStyle.Fill;
            btnReferencias1.Image = Properties.Resources.bibliografia;
            btnReferencias1.Location = new Point(3, 3);
            btnReferencias1.Name = "btnReferencias1";
            btnReferencias1.Size = new Size(123, 81);
            btnReferencias1.SizeMode = PictureBoxSizeMode.Zoom;
            btnReferencias1.TabIndex = 0;
            btnReferencias1.TabStop = false;
            btnReferencias1.Click += btnReferencias1_Click;
            // 
            // regresar1
            // 
            regresar1.Dock = DockStyle.Fill;
            regresar1.Image = Properties.Resources.regresar;
            regresar1.Location = new Point(1253, 3);
            regresar1.Name = "regresar1";
            regresar1.Size = new Size(120, 81);
            regresar1.SizeMode = PictureBoxSizeMode.Zoom;
            regresar1.TabIndex = 1;
            regresar1.TabStop = false;
            regresar1.Click += regresar1_Click;
            // 
            // fmQuizMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 787);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fmQuizMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fmQuiz1";
            Load += fmQuizMenu_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnReferencias1).EndInit();
            ((System.ComponentModel.ISupportInitialize)regresar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CuoreUI.Controls.cuiLabel label;
        private CuoreUI.Controls.cuiButton btn1;
        private CuoreUI.Controls.cuiButton btn3;
        private CuoreUI.Controls.cuiButton btn2;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox btnReferencias1;
        private PictureBox regresar1;
    }
}

