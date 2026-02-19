namespace AlberSoft.mapaInteractivo
{
    partial class fmInstruccionesQuiz
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
            tableLayoutPanel2 = new TableLayoutPanel();
            btnAceptar = new CuoreUI.Controls.cuiButton();
            btnCancelar = new CuoreUI.Controls.cuiButton();
            lblTitulo = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Lavender;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(lblTitulo, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.3065128F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.22222F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5555553F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.63473F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.2155685F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 94F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.66467F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.78443F));
            tableLayoutPanel2.Controls.Add(btnAceptar, 1, 0);
            tableLayoutPanel2.Controls.Add(btnCancelar, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 328);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(794, 119);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.Transparent;
            btnAceptar.CheckButton = false;
            btnAceptar.Checked = false;
            btnAceptar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnAceptar.CheckedForeColor = Color.White;
            btnAceptar.CheckedImageTint = Color.White;
            btnAceptar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnAceptar.Content = "Aceptar";
            btnAceptar.DialogResult = DialogResult.None;
            btnAceptar.Dock = DockStyle.Fill;
            btnAceptar.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnAceptar.ForeColor = Color.Black;
            btnAceptar.HoverBackground = Color.White;
            btnAceptar.HoverForeColor = Color.Black;
            btnAceptar.HoverImageTint = Color.White;
            btnAceptar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnAceptar.Image = null;
            btnAceptar.ImageAutoCenter = true;
            btnAceptar.ImageExpand = new Point(0, 0);
            btnAceptar.ImageOffset = new Point(0, 0);
            btnAceptar.Location = new Point(230, 3);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.NormalBackground = Color.FromArgb(192, 255, 192);
            btnAceptar.NormalForeColor = Color.Black;
            btnAceptar.NormalImageTint = Color.White;
            btnAceptar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnAceptar.OutlineThickness = 1F;
            btnAceptar.PressedBackground = Color.WhiteSmoke;
            btnAceptar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnAceptar.PressedImageTint = Color.White;
            btnAceptar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnAceptar.Rounding = new Padding(8);
            btnAceptar.Size = new Size(114, 113);
            btnAceptar.TabIndex = 2;
            btnAceptar.TextAlignment = StringAlignment.Center;
            btnAceptar.TextOffset = new Point(0, 0);
            btnAceptar.Click += btnAceptar_Click_1;
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
            btnCancelar.Dock = DockStyle.Fill;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnCancelar.ForeColor = Color.Black;
            btnCancelar.HoverBackground = Color.White;
            btnCancelar.HoverForeColor = Color.Black;
            btnCancelar.HoverImageTint = Color.White;
            btnCancelar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnCancelar.Image = null;
            btnCancelar.ImageAutoCenter = true;
            btnCancelar.ImageExpand = new Point(0, 0);
            btnCancelar.ImageOffset = new Point(0, 0);
            btnCancelar.Location = new Point(444, 3);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NormalBackground = Color.FromArgb(255, 128, 128);
            btnCancelar.NormalForeColor = Color.Black;
            btnCancelar.NormalImageTint = Color.White;
            btnCancelar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnCancelar.OutlineThickness = 1F;
            btnCancelar.PressedBackground = Color.WhiteSmoke;
            btnCancelar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnCancelar.PressedImageTint = Color.White;
            btnCancelar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnCancelar.Rounding = new Padding(8);
            btnCancelar.Size = new Size(117, 113);
            btnCancelar.TabIndex = 3;
            btnCancelar.TextAlignment = StringAlignment.Center;
            btnCancelar.TextOffset = new Point(0, 0);
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // lblTitulo
            // 
            lblTitulo.Anchor = AnchorStyles.None;
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.FromArgb(192, 192, 255);
            lblTitulo.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(254, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(292, 52);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Instrucciones";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 91);
            label1.Name = "label1";
            label1.Size = new Size(794, 234);
            label1.TabIndex = 2;
            // 
            // fmInstruccionesQuiz
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 247);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "fmInstruccionesQuiz";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Instrucciones";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitulo;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private CuoreUI.Controls.cuiButton btnAceptar;
        private CuoreUI.Controls.cuiButton btnCancelar;
    }
}