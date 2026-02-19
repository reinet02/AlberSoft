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
            tablaGeneral = new TableLayoutPanel();
            tablaGeneralF3 = new TableLayoutPanel();
            btnJugar = new CuoreUI.Controls.cuiButton();
            btnCancelar = new CuoreUI.Controls.cuiButton();
            lblTitulo = new Label();
            label1 = new Label();
            tablaGeneral.SuspendLayout();
            tablaGeneralF3.SuspendLayout();
            SuspendLayout();
            // 
            // tablaGeneral
            // 
            tablaGeneral.BackColor = Color.Lavender;
            tablaGeneral.ColumnCount = 1;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaGeneral.Controls.Add(tablaGeneralF3, 0, 2);
            tablaGeneral.Controls.Add(lblTitulo, 0, 0);
            tablaGeneral.Controls.Add(label1, 0, 1);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Margin = new Padding(3, 2, 3, 2);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 3;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 20.28941F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 63.6094666F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 16.27219F));
            tablaGeneral.Size = new Size(700, 338);
            tablaGeneral.TabIndex = 0;
            tablaGeneral.Paint += tableLayoutPanel1_Paint;
            // 
            // tablaGeneralF3
            // 
            tablaGeneralF3.ColumnCount = 5;
            tablaGeneralF3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.7131462F));
            tablaGeneralF3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.4610958F));
            tablaGeneralF3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.8674355F));
            tablaGeneralF3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.766571F));
            tablaGeneralF3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.002882F));
            tablaGeneralF3.Controls.Add(btnJugar, 1, 0);
            tablaGeneralF3.Controls.Add(btnCancelar, 3, 0);
            tablaGeneralF3.Dock = DockStyle.Fill;
            tablaGeneralF3.Location = new Point(3, 284);
            tablaGeneralF3.Margin = new Padding(3, 2, 3, 2);
            tablaGeneralF3.Name = "tablaGeneralF3";
            tablaGeneralF3.RowCount = 1;
            tablaGeneralF3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaGeneralF3.Size = new Size(694, 52);
            tablaGeneralF3.TabIndex = 1;
            // 
            // btnJugar
            // 
            btnJugar.BackColor = Color.Transparent;
            btnJugar.CheckButton = false;
            btnJugar.Checked = false;
            btnJugar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnJugar.CheckedForeColor = Color.White;
            btnJugar.CheckedImageTint = Color.White;
            btnJugar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnJugar.Content = "Jugar";
            btnJugar.DialogResult = DialogResult.None;
            btnJugar.Dock = DockStyle.Fill;
            btnJugar.Font = new Font("Microsoft Sans Serif", 9.75F);
            btnJugar.ForeColor = Color.Black;
            btnJugar.HoverBackground = Color.White;
            btnJugar.HoverForeColor = Color.Black;
            btnJugar.HoverImageTint = Color.White;
            btnJugar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnJugar.Image = null;
            btnJugar.ImageAutoCenter = true;
            btnJugar.ImageExpand = new Point(0, 0);
            btnJugar.ImageOffset = new Point(0, 0);
            btnJugar.Location = new Point(153, 2);
            btnJugar.Margin = new Padding(3, 2, 3, 2);
            btnJugar.Name = "btnJugar";
            btnJugar.NormalBackground = Color.FromArgb(192, 255, 192);
            btnJugar.NormalForeColor = Color.Black;
            btnJugar.NormalImageTint = Color.White;
            btnJugar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnJugar.OutlineThickness = 1F;
            btnJugar.PressedBackground = Color.WhiteSmoke;
            btnJugar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnJugar.PressedImageTint = Color.White;
            btnJugar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnJugar.Rounding = new Padding(8);
            btnJugar.Size = new Size(136, 48);
            btnJugar.TabIndex = 2;
            btnJugar.TextAlignment = StringAlignment.Center;
            btnJugar.TextOffset = new Point(0, 0);
            btnJugar.Click += btnAceptar_Click_1;
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
            btnCancelar.Location = new Point(419, 2);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
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
            btnCancelar.Size = new Size(152, 48);
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
            lblTitulo.Location = new Point(232, 14);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(236, 39);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Instrucciones";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 68);
            label1.Name = "label1";
            label1.Size = new Size(694, 214);
            label1.TabIndex = 2;
            // 
            // fmInstruccionesQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 247, 247);
            ClientSize = new Size(700, 338);
            Controls.Add(tablaGeneral);
            Margin = new Padding(3, 2, 3, 2);
            Name = "fmInstruccionesQuiz";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Instrucciones";
            tablaGeneral.ResumeLayout(false);
            tablaGeneral.PerformLayout();
            tablaGeneralF3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablaGeneral;
        private Label lblTitulo;
        private TableLayoutPanel tablaGeneralF3;
        private Label label1;
        private CuoreUI.Controls.cuiButton btnJugar;
        private CuoreUI.Controls.cuiButton btnCancelar;
    }
}