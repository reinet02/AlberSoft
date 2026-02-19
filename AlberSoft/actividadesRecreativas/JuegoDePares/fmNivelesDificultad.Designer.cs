namespace AlberSoft.activadesRecreativas
{
    partial class fmNivelesDificultad
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
            panel1 = new CuoreUI.Controls.cuiPanel();
            seleccionadorDeNivel = new CuoreUI.Controls.cuiComboBox();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            tablaGeneral = new TableLayoutPanel();
            tabla1 = new TableLayoutPanel();
            btnintrucionespares = new CuoreUI.Controls.cuiButton();
            tablaGeneral.SuspendLayout();
            tabla1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.OutlineThickness = 1F;
            panel1.PanelColor = Color.White;
            panel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            panel1.Rounding = new Padding(8);
            panel1.Size = new Size(1250, 1167);
            panel1.TabIndex = 0;
            // 
            // seleccionadorDeNivel
            // 
            seleccionadorDeNivel.BackgroundColor = Color.FromArgb(255, 255, 255);
            seleccionadorDeNivel.Dock = DockStyle.Fill;
            seleccionadorDeNivel.DropDownBackgroundColor = Color.White;
            seleccionadorDeNivel.DropDownForeColor = Color.FromArgb(27, 27, 27);
            seleccionadorDeNivel.ExpandArrowColor = Color.Gray;
            seleccionadorDeNivel.ForeColor = Color.Gray;
            seleccionadorDeNivel.Items = new string[]
    {
    "Fácil",
    "Intermedio",
    "Difícil"
    };
            seleccionadorDeNivel.Location = new Point(5, 120);
            seleccionadorDeNivel.Margin = new Padding(5, 4, 5, 4);
            seleccionadorDeNivel.MaxDropDownHeight = 240;
            seleccionadorDeNivel.Name = "seleccionadorDeNivel";
            seleccionadorDeNivel.NoSelectionText = "Seleccione un nivel";
            seleccionadorDeNivel.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            seleccionadorDeNivel.OutlineThickness = 1F;
            seleccionadorDeNivel.Rounding = 8;
            seleccionadorDeNivel.SelectedIndex = 0;
            seleccionadorDeNivel.SelectedItem = "Fácil";
            seleccionadorDeNivel.Size = new Size(299, 50);
            seleccionadorDeNivel.SortAlphabetically = true;
            seleccionadorDeNivel.TabIndex = 1;
            seleccionadorDeNivel.SelectedIndexChanged += seleccionadorDeNivel_SelectedIndexChanged;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Seleccione\\ el\\ nivel\\ de\\ dificultad:";
            cuiLabel1.Dock = DockStyle.Fill;
            cuiLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(5, 4);
            cuiLabel1.Margin = new Padding(5, 4, 5, 4);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(299, 108);
            cuiLabel1.TabIndex = 2;
            cuiLabel1.VerticalAlignment = StringAlignment.Near;
            // 
            // tablaGeneral
            // 
            tablaGeneral.ColumnCount = 2;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaGeneral.Controls.Add(panel1, 0, 0);
            tablaGeneral.Controls.Add(tabla1, 1, 0);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Margin = new Padding(3, 4, 3, 4);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 1;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaGeneral.Size = new Size(1571, 1175);
            tablaGeneral.TabIndex = 3;
            // 
            // tabla1
            // 
            tabla1.ColumnCount = 1;
            tabla1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tabla1.Controls.Add(cuiLabel1, 0, 0);
            tabla1.Controls.Add(seleccionadorDeNivel, 0, 1);
            tabla1.Controls.Add(btnintrucionespares, 0, 3);
            tabla1.Dock = DockStyle.Fill;
            tabla1.Location = new Point(1259, 4);
            tabla1.Margin = new Padding(3, 4, 3, 4);
            tabla1.Name = "tabla1";
            tabla1.RowCount = 5;
            tabla1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabla1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tabla1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabla1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tabla1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tabla1.Size = new Size(309, 1167);
            tabla1.TabIndex = 1;
            // 
            // btnintrucionespares
            // 
            btnintrucionespares.CheckButton = false;
            btnintrucionespares.Checked = false;
            btnintrucionespares.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnintrucionespares.CheckedForeColor = Color.White;
            btnintrucionespares.CheckedImageTint = Color.White;
            btnintrucionespares.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnintrucionespares.Content = "Intrucciones del Juego";
            btnintrucionespares.DialogResult = DialogResult.None;
            btnintrucionespares.Dock = DockStyle.Fill;
            btnintrucionespares.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnintrucionespares.ForeColor = Color.Black;
            btnintrucionespares.HoverBackground = Color.OldLace;
            btnintrucionespares.HoverForeColor = Color.Black;
            btnintrucionespares.HoverImageTint = Color.White;
            btnintrucionespares.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnintrucionespares.Image = null;
            btnintrucionespares.ImageAutoCenter = true;
            btnintrucionespares.ImageExpand = new Point(0, 0);
            btnintrucionespares.ImageOffset = new Point(0, 0);
            btnintrucionespares.Location = new Point(3, 293);
            btnintrucionespares.Name = "btnintrucionespares";
            btnintrucionespares.NormalBackground = Color.White;
            btnintrucionespares.NormalForeColor = Color.Black;
            btnintrucionespares.NormalImageTint = Color.White;
            btnintrucionespares.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnintrucionespares.OutlineThickness = 1F;
            btnintrucionespares.PressedBackground = Color.WhiteSmoke;
            btnintrucionespares.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnintrucionespares.PressedImageTint = Color.White;
            btnintrucionespares.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnintrucionespares.Rounding = new Padding(8);
            btnintrucionespares.Size = new Size(303, 52);
            btnintrucionespares.TabIndex = 3;
            btnintrucionespares.TextAlignment = StringAlignment.Center;
            btnintrucionespares.TextOffset = new Point(0, 0);
            btnintrucionespares.Click += btnintrucionespares_Click;
            // 
            // fmNivelesDificultad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 1175);
            Controls.Add(tablaGeneral);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fmNivelesDificultad";
            Text = "fmNivelesDeDificultad";
            Load += fmNivelesDeDificultad_Load;
            tablaGeneral.ResumeLayout(false);
            tabla1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiPanel panel1;
        private CuoreUI.Controls.cuiComboBox seleccionadorDeNivel;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private TableLayoutPanel tablaGeneral;
        private TableLayoutPanel tabla1;
        private CuoreUI.Controls.cuiButton btnintrucionespares;
    }
}