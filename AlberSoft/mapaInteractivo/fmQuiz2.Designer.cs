namespace AlberSoft.mapaInteractivo
{
    partial class fmQuiz2
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
            tablaOpcionesMultiples = new TableLayoutPanel();
            btn = new CuoreUI.Controls.cuiButton();
            btn3 = new CuoreUI.Controls.cuiButton();
            bnt2 = new CuoreUI.Controls.cuiButton();
            btn1 = new CuoreUI.Controls.cuiButton();
            tablaGeneral.SuspendLayout();
            tablaOpcionesMultiples.SuspendLayout();
            SuspendLayout();
            // 
            // tablaGeneral
            // 
            tablaGeneral.ColumnCount = 1;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaGeneral.Controls.Add(tablaOpcionesMultiples, 0, 2);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 4;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablaGeneral.Size = new Size(973, 704);
            tablaGeneral.TabIndex = 0;
            // 
            // tablaOpcionesMultiples
            // 
            tablaOpcionesMultiples.ColumnCount = 2;
            tablaOpcionesMultiples.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaOpcionesMultiples.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaOpcionesMultiples.Controls.Add(btn, 1, 1);
            tablaOpcionesMultiples.Controls.Add(btn3, 0, 1);
            tablaOpcionesMultiples.Controls.Add(bnt2, 1, 0);
            tablaOpcionesMultiples.Controls.Add(btn1, 0, 0);
            tablaOpcionesMultiples.Dock = DockStyle.Fill;
            tablaOpcionesMultiples.Location = new Point(3, 284);
            tablaOpcionesMultiples.Name = "tablaOpcionesMultiples";
            tablaOpcionesMultiples.RowCount = 2;
            tablaOpcionesMultiples.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaOpcionesMultiples.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaOpcionesMultiples.Size = new Size(967, 310);
            tablaOpcionesMultiples.TabIndex = 0;
            // 
            // btn
            // 
            btn.CheckButton = false;
            btn.Checked = false;
            btn.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn.CheckedForeColor = Color.White;
            btn.CheckedImageTint = Color.White;
            btn.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn.Content = "Your text here!";
            btn.DialogResult = DialogResult.None;
            btn.Dock = DockStyle.Fill;
            btn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn.ForeColor = Color.Black;
            btn.HoverBackground = Color.White;
            btn.HoverForeColor = Color.Black;
            btn.HoverImageTint = Color.White;
            btn.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn.Image = null;
            btn.ImageAutoCenter = true;
            btn.ImageExpand = new Point(0, 0);
            btn.ImageOffset = new Point(0, 0);
            btn.Location = new Point(486, 158);
            btn.Name = "btn";
            btn.NormalBackground = Color.White;
            btn.NormalForeColor = Color.Black;
            btn.NormalImageTint = Color.White;
            btn.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn.OutlineThickness = 1F;
            btn.PressedBackground = Color.WhiteSmoke;
            btn.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn.PressedImageTint = Color.White;
            btn.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn.Rounding = new Padding(8);
            btn.Size = new Size(478, 149);
            btn.TabIndex = 3;
            btn.TextAlignment = StringAlignment.Center;
            btn.TextOffset = new Point(0, 0);
            // 
            // btn3
            // 
            btn3.CheckButton = false;
            btn3.Checked = false;
            btn3.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn3.CheckedForeColor = Color.White;
            btn3.CheckedImageTint = Color.White;
            btn3.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn3.Content = "Your text here!";
            btn3.DialogResult = DialogResult.None;
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.Black;
            btn3.HoverBackground = Color.White;
            btn3.HoverForeColor = Color.Black;
            btn3.HoverImageTint = Color.White;
            btn3.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn3.Image = null;
            btn3.ImageAutoCenter = true;
            btn3.ImageExpand = new Point(0, 0);
            btn3.ImageOffset = new Point(0, 0);
            btn3.Location = new Point(3, 158);
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
            btn3.Size = new Size(477, 149);
            btn3.TabIndex = 2;
            btn3.TextAlignment = StringAlignment.Center;
            btn3.TextOffset = new Point(0, 0);
            // 
            // bnt2
            // 
            bnt2.CheckButton = false;
            bnt2.Checked = false;
            bnt2.CheckedBackground = Color.FromArgb(255, 106, 0);
            bnt2.CheckedForeColor = Color.White;
            bnt2.CheckedImageTint = Color.White;
            bnt2.CheckedOutline = Color.FromArgb(255, 106, 0);
            bnt2.Content = "Your text here!";
            bnt2.DialogResult = DialogResult.None;
            bnt2.Dock = DockStyle.Fill;
            bnt2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bnt2.ForeColor = Color.Black;
            bnt2.HoverBackground = Color.White;
            bnt2.HoverForeColor = Color.Black;
            bnt2.HoverImageTint = Color.White;
            bnt2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            bnt2.Image = null;
            bnt2.ImageAutoCenter = true;
            bnt2.ImageExpand = new Point(0, 0);
            bnt2.ImageOffset = new Point(0, 0);
            bnt2.Location = new Point(486, 3);
            bnt2.Name = "bnt2";
            bnt2.NormalBackground = Color.White;
            bnt2.NormalForeColor = Color.Black;
            bnt2.NormalImageTint = Color.White;
            bnt2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            bnt2.OutlineThickness = 1F;
            bnt2.PressedBackground = Color.WhiteSmoke;
            bnt2.PressedForeColor = Color.FromArgb(32, 32, 32);
            bnt2.PressedImageTint = Color.White;
            bnt2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            bnt2.Rounding = new Padding(8);
            bnt2.Size = new Size(478, 149);
            bnt2.TabIndex = 1;
            bnt2.TextAlignment = StringAlignment.Center;
            bnt2.TextOffset = new Point(0, 0);
            // 
            // btn1
            // 
            btn1.CheckButton = false;
            btn1.Checked = false;
            btn1.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn1.CheckedForeColor = Color.White;
            btn1.CheckedImageTint = Color.White;
            btn1.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn1.Content = "Your text here!";
            btn1.DialogResult = DialogResult.None;
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.Black;
            btn1.HoverBackground = Color.White;
            btn1.HoverForeColor = Color.Black;
            btn1.HoverImageTint = Color.White;
            btn1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn1.Image = null;
            btn1.ImageAutoCenter = true;
            btn1.ImageExpand = new Point(0, 0);
            btn1.ImageOffset = new Point(0, 0);
            btn1.Location = new Point(3, 3);
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
            btn1.Size = new Size(477, 149);
            btn1.TabIndex = 0;
            btn1.TextAlignment = StringAlignment.Center;
            btn1.TextOffset = new Point(0, 0);
            // 
            // fmQuiz2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 704);
            Controls.Add(tablaGeneral);
            Name = "fmQuiz2";
            Text = "fmQuiz2";
            tablaGeneral.ResumeLayout(false);
            tablaOpcionesMultiples.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablaGeneral;
        private TableLayoutPanel tablaOpcionesMultiples;
        private CuoreUI.Controls.cuiButton btn;
        private CuoreUI.Controls.cuiButton btn3;
        private CuoreUI.Controls.cuiButton bnt2;
        private CuoreUI.Controls.cuiButton btn1;
    }
}