namespace AlberSoft.mapaInteractivo
{
    partial class fmQuiz1
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
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btn3, 0, 3);
            tableLayoutPanel1.Controls.Add(btn2, 0, 2);
            tableLayoutPanel1.Controls.Add(label, 0, 0);
            tableLayoutPanel1.Controls.Add(btn1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label
            // 
            label.Content = "¡Bienvenido\\ al\\ Quiz!";
            label.Dock = DockStyle.Fill;
            label.Font = new Font("Microsoft Sans Serif", 62.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.HorizontalAlignment = StringAlignment.Center;
            label.Location = new Point(4, 3);
            label.Margin = new Padding(4, 3, 4, 3);
            label.Name = "label";
            label.Size = new Size(792, 174);
            label.TabIndex = 0;
            label.VerticalAlignment = StringAlignment.Near;
            label.Load += cuiLabel1_Load;
            // 
            // btn1
            // 
            btn1.CheckButton = false;
            btn1.Checked = false;
            btn1.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn1.CheckedForeColor = Color.White;
            btn1.CheckedImageTint = Color.White;
            btn1.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn1.Content = "Nivel fácil";
            btn1.DialogResult = DialogResult.None;
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Microsoft Sans Serif", 20.25F);
            btn1.ForeColor = Color.Black;
            btn1.HoverBackground = Color.White;
            btn1.HoverForeColor = Color.Black;
            btn1.HoverImageTint = Color.White;
            btn1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn1.Image = null;
            btn1.ImageAutoCenter = true;
            btn1.ImageExpand = new Point(0, 0);
            btn1.ImageOffset = new Point(0, 0);
            btn1.Location = new Point(3, 183);
            btn1.Name = "btn1";
            btn1.NormalBackground = Color.White;
            btn1.NormalForeColor = Color.Black;
            btn1.NormalImageTint = Color.White;
            btn1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn1.OutlineThickness = 1F;
            btn1.PressedBackground = Color.WhiteSmoke;
            btn1.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn1.PressedImageTint = Color.White;
            btn1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn1.Rounding = new Padding(8);
            btn1.Size = new Size(794, 84);
            btn1.TabIndex = 1;
            btn1.TextAlignment = StringAlignment.Center;
            btn1.TextOffset = new Point(0, 0);
            // 
            // btn2
            // 
            btn2.CheckButton = false;
            btn2.Checked = false;
            btn2.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn2.CheckedForeColor = Color.White;
            btn2.CheckedImageTint = Color.White;
            btn2.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn2.Content = "Nivel medio";
            btn2.DialogResult = DialogResult.None;
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Microsoft Sans Serif", 20.25F);
            btn2.ForeColor = Color.Black;
            btn2.HoverBackground = Color.White;
            btn2.HoverForeColor = Color.Black;
            btn2.HoverImageTint = Color.White;
            btn2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn2.Image = null;
            btn2.ImageAutoCenter = true;
            btn2.ImageExpand = new Point(0, 0);
            btn2.ImageOffset = new Point(0, 0);
            btn2.Location = new Point(3, 273);
            btn2.Name = "btn2";
            btn2.NormalBackground = Color.White;
            btn2.NormalForeColor = Color.Black;
            btn2.NormalImageTint = Color.White;
            btn2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn2.OutlineThickness = 1F;
            btn2.PressedBackground = Color.WhiteSmoke;
            btn2.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn2.PressedImageTint = Color.White;
            btn2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn2.Rounding = new Padding(8);
            btn2.Size = new Size(794, 84);
            btn2.TabIndex = 2;
            btn2.TextAlignment = StringAlignment.Center;
            btn2.TextOffset = new Point(0, 0);
            // 
            // btn3
            // 
            btn3.CheckButton = false;
            btn3.Checked = false;
            btn3.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn3.CheckedForeColor = Color.White;
            btn3.CheckedImageTint = Color.White;
            btn3.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn3.Content = "Nivel difícil";
            btn3.DialogResult = DialogResult.None;
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Microsoft Sans Serif", 20.25F);
            btn3.ForeColor = Color.Black;
            btn3.HoverBackground = Color.White;
            btn3.HoverForeColor = Color.Black;
            btn3.HoverImageTint = Color.White;
            btn3.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn3.Image = null;
            btn3.ImageAutoCenter = true;
            btn3.ImageExpand = new Point(0, 0);
            btn3.ImageOffset = new Point(0, 0);
            btn3.Location = new Point(3, 363);
            btn3.Name = "btn3";
            btn3.NormalBackground = Color.White;
            btn3.NormalForeColor = Color.Black;
            btn3.NormalImageTint = Color.White;
            btn3.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn3.OutlineThickness = 1F;
            btn3.PressedBackground = Color.WhiteSmoke;
            btn3.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn3.PressedImageTint = Color.White;
            btn3.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn3.Rounding = new Padding(8);
            btn3.Size = new Size(794, 84);
            btn3.TabIndex = 3;
            btn3.TextAlignment = StringAlignment.Center;
            btn3.TextOffset = new Point(0, 0);
            // 
            // fmQuiz1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "fmQuiz1";
            Text = "fmQuiz1";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private CuoreUI.Controls.cuiLabel label;
        private CuoreUI.Controls.cuiButton btn1;
        private CuoreUI.Controls.cuiButton btn3;
        private CuoreUI.Controls.cuiButton btn2;
    }
}