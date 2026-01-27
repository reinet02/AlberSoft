namespace AlberSoft.actividadesRecreativas
{
    partial class fmCocinaComunitaria
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
            btnReceta1 = new CuoreUI.Controls.cuiButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabla1 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btntostadas = new CuoreUI.Controls.cuiButton();
            panel1 = new CuoreUI.Controls.cuiPanel();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabla1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnReceta1
            // 
            btnReceta1.BackColor = Color.FromArgb(255, 192, 192);
            btnReceta1.CheckButton = false;
            btnReceta1.Checked = false;
            btnReceta1.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnReceta1.CheckedForeColor = Color.White;
            btnReceta1.CheckedImageTint = Color.White;
            btnReceta1.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnReceta1.Content = "Avena Nocturna ";
            btnReceta1.DialogResult = DialogResult.None;
            btnReceta1.Dock = DockStyle.Fill;
            btnReceta1.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnReceta1.ForeColor = Color.Black;
            btnReceta1.HoverBackground = Color.White;
            btnReceta1.HoverForeColor = Color.Black;
            btnReceta1.HoverImageTint = Color.White;
            btnReceta1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnReceta1.Image = null;
            btnReceta1.ImageAutoCenter = true;
            btnReceta1.ImageExpand = new Point(0, 0);
            btnReceta1.ImageOffset = new Point(0, 0);
            btnReceta1.Location = new Point(3, 4);
            btnReceta1.Margin = new Padding(3, 4, 3, 4);
            btnReceta1.Name = "btnReceta1";
            btnReceta1.NormalBackground = Color.White;
            btnReceta1.NormalForeColor = Color.Black;
            btnReceta1.NormalImageTint = Color.White;
            btnReceta1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnReceta1.OutlineThickness = 1F;
            btnReceta1.PressedBackground = Color.WhiteSmoke;
            btnReceta1.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnReceta1.PressedImageTint = Color.White;
            btnReceta1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnReceta1.Rounding = new Padding(8);
            btnReceta1.Size = new Size(179, 108);
            btnReceta1.TabIndex = 0;
            btnReceta1.TextAlignment = StringAlignment.Center;
            btnReceta1.TextOffset = new Point(0, 0);
            btnReceta1.Click += btnReceta1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1543, 1045);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tabla1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1535, 1012);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Desayunos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabla1
            // 
            tabla1.ColumnCount = 2;
            tabla1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tabla1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tabla1.Controls.Add(tableLayoutPanel1, 0, 0);
            tabla1.Controls.Add(panel1, 1, 0);
            tabla1.Dock = DockStyle.Fill;
            tabla1.Location = new Point(3, 4);
            tabla1.Margin = new Padding(3, 4, 3, 4);
            tabla1.Name = "tabla1";
            tabla1.RowCount = 1;
            tabla1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tabla1.Size = new Size(1529, 1004);
            tabla1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.2512474F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.7487526F));
            tableLayoutPanel1.Controls.Add(btnReceta1, 0, 0);
            tableLayoutPanel1.Controls.Add(btntostadas, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 4);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.69355F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.63441F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75.67204F));
            tableLayoutPanel1.Size = new Size(376, 996);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btntostadas
            // 
            btntostadas.CheckButton = false;
            btntostadas.Checked = false;
            btntostadas.CheckedBackground = Color.FromArgb(255, 106, 0);
            btntostadas.CheckedForeColor = Color.White;
            btntostadas.CheckedImageTint = Color.White;
            btntostadas.CheckedOutline = Color.FromArgb(255, 106, 0);
            btntostadas.Content = "Tostadas de Aguacate";
            btntostadas.DialogResult = DialogResult.None;
            btntostadas.Dock = DockStyle.Fill;
            btntostadas.Font = new Font("Microsoft Sans Serif", 9.75F);
            btntostadas.ForeColor = Color.Black;
            btntostadas.HoverBackground = Color.White;
            btntostadas.HoverForeColor = Color.Black;
            btntostadas.HoverImageTint = Color.White;
            btntostadas.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btntostadas.Image = null;
            btntostadas.ImageAutoCenter = true;
            btntostadas.ImageExpand = new Point(0, 0);
            btntostadas.ImageOffset = new Point(0, 0);
            btntostadas.Location = new Point(188, 3);
            btntostadas.Name = "btntostadas";
            btntostadas.NormalBackground = Color.White;
            btntostadas.NormalForeColor = Color.Black;
            btntostadas.NormalImageTint = Color.White;
            btntostadas.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btntostadas.OutlineThickness = 1F;
            btntostadas.PressedBackground = Color.WhiteSmoke;
            btntostadas.PressedForeColor = Color.FromArgb(32, 32, 32);
            btntostadas.PressedImageTint = Color.White;
            btntostadas.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btntostadas.Rounding = new Padding(8);
            btntostadas.Size = new Size(185, 110);
            btntostadas.TabIndex = 1;
            btntostadas.TextAlignment = StringAlignment.Center;
            btntostadas.TextOffset = new Point(0, 0);
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.Center;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(385, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.OutlineThickness = 1F;
            panel1.PanelColor = Color.White;
            panel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            panel1.Rounding = new Padding(8);
            panel1.Size = new Size(1141, 996);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1535, 1012);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Almuerzos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1535, 1012);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Meriendas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1535, 1012);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Postres";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // fmCocinaComunitaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1543, 1045);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fmCocinaComunitaria";
            Text = "fmInformación";
            Load += CargarFormularioPorDefecto_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabla1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiButton btnReceta1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tabla1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel1;
        private CuoreUI.Controls.cuiPanel panel1;
        private CuoreUI.Controls.cuiButton btntostadas;
    }
}