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
            tablaGeneral.SuspendLayout();
            tabla1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.OutlineThickness = 1F;
            panel1.PanelColor = Color.White;
            panel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            panel1.Rounding = new Padding(8);
            panel1.Size = new Size(1094, 900);
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
            seleccionadorDeNivel.Location = new Point(4, 93);
            seleccionadorDeNivel.Margin = new Padding(4, 3, 4, 3);
            seleccionadorDeNivel.MaxDropDownHeight = 240;
            seleccionadorDeNivel.Name = "seleccionadorDeNivel";
            seleccionadorDeNivel.NoSelectionText = "Seleccione un nivel";
            seleccionadorDeNivel.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            seleccionadorDeNivel.OutlineThickness = 1F;
            seleccionadorDeNivel.Rounding = 8;
            seleccionadorDeNivel.SelectedIndex = 0;
            seleccionadorDeNivel.SelectedItem = "Fácil";
            seleccionadorDeNivel.Size = new Size(261, 39);
            seleccionadorDeNivel.SortAlphabetically = true;
            seleccionadorDeNivel.TabIndex = 1;
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Seleccione\\ el\\ nivel\\ de\\ dificultad:";
            cuiLabel1.Dock = DockStyle.Fill;
            cuiLabel1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(4, 3);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(261, 84);
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
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 1;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaGeneral.Size = new Size(1375, 906);
            tablaGeneral.TabIndex = 3;
            // 
            // tabla1
            // 
            tabla1.ColumnCount = 1;
            tabla1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tabla1.Controls.Add(cuiLabel1, 0, 0);
            tabla1.Controls.Add(seleccionadorDeNivel, 0, 1);
            tabla1.Dock = DockStyle.Fill;
            tabla1.Location = new Point(1103, 3);
            tabla1.Name = "tabla1";
            tabla1.RowCount = 3;
            tabla1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tabla1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tabla1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tabla1.Size = new Size(269, 900);
            tabla1.TabIndex = 1;
            // 
            // fmNivelesDeDificultad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1375, 906);
            Controls.Add(tablaGeneral);
            Name = "fmNivelesDeDificultad";
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
    }
}