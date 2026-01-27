namespace AlberSoft.alojamientoEInventario
{
    partial class fmInventarioRopa
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
            cuiPanelGradient2 = new CuoreUI.Controls.cuiPanelGradient();
            cuibtnGuardar = new CuoreUI.Controls.cuiButton();
            cuibtnEliminar = new CuoreUI.Controls.cuiButton();
            cuibtnAgregarRopa = new CuoreUI.Controls.cuiButton();
            cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            nudCantidad = new NumericUpDown();
            cuicmbColor = new CuoreUI.Controls.cuiComboBox();
            cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            cuicmbTalla = new CuoreUI.Controls.cuiComboBox();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuicmbTipo = new CuoreUI.Controls.cuiComboBox();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            cuiPanelGradient3 = new CuoreUI.Controls.cuiPanelGradient();
            dtgInventarioRopa = new DataGridView();
            Tipo = new DataGridViewTextBoxColumn();
            Talla = new DataGridViewTextBoxColumn();
            ColumnaColor = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            cuiLabel7 = new CuoreUI.Controls.cuiLabel();
            cuiPanelGradient1 = new CuoreUI.Controls.cuiPanelGradient();
            pictureBox1 = new PictureBox();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            cuiPanelGradient2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            cuiPanelGradient3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInventarioRopa).BeginInit();
            cuiPanelGradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ActiveBorder;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(cuiPanelGradient1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2807016F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.7193F));
            tableLayoutPanel1.Size = new Size(1335, 1000);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.6804657F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.3195343F));
            tableLayoutPanel2.Controls.Add(cuiPanelGradient2, 0, 0);
            tableLayoutPanel2.Controls.Add(cuiPanelGradient3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 125);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1329, 872);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // cuiPanelGradient2
            // 
            cuiPanelGradient2.AutoSize = true;
            cuiPanelGradient2.Controls.Add(cuibtnGuardar);
            cuiPanelGradient2.Controls.Add(cuibtnEliminar);
            cuiPanelGradient2.Controls.Add(cuibtnAgregarRopa);
            cuiPanelGradient2.Controls.Add(cuiLabel6);
            cuiPanelGradient2.Controls.Add(nudCantidad);
            cuiPanelGradient2.Controls.Add(cuicmbColor);
            cuiPanelGradient2.Controls.Add(cuiLabel5);
            cuiPanelGradient2.Controls.Add(cuicmbTalla);
            cuiPanelGradient2.Controls.Add(cuiLabel4);
            cuiPanelGradient2.Controls.Add(cuicmbTipo);
            cuiPanelGradient2.Controls.Add(cuiLabel3);
            cuiPanelGradient2.Controls.Add(cuiLabel1);
            cuiPanelGradient2.Dock = DockStyle.Fill;
            cuiPanelGradient2.GradientAngle = 0F;
            cuiPanelGradient2.Location = new Point(3, 3);
            cuiPanelGradient2.Name = "cuiPanelGradient2";
            cuiPanelGradient2.OutlineThickness = 1F;
            cuiPanelGradient2.PanelColor1 = Color.FromArgb(224, 224, 224);
            cuiPanelGradient2.PanelColor2 = Color.Transparent;
            cuiPanelGradient2.PanelOutlineColor1 = Color.Red;
            cuiPanelGradient2.PanelOutlineColor2 = Color.Red;
            cuiPanelGradient2.Rounding = new Padding(8);
            cuiPanelGradient2.Size = new Size(388, 866);
            cuiPanelGradient2.TabIndex = 0;
            // 
            // cuibtnGuardar
            // 
            cuibtnGuardar.BackColor = Color.Transparent;
            cuibtnGuardar.CheckButton = false;
            cuibtnGuardar.Checked = false;
            cuibtnGuardar.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuibtnGuardar.CheckedForeColor = Color.White;
            cuibtnGuardar.CheckedImageTint = Color.White;
            cuibtnGuardar.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuibtnGuardar.Content = "Guardar";
            cuibtnGuardar.DialogResult = DialogResult.None;
            cuibtnGuardar.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuibtnGuardar.ForeColor = Color.FromArgb(30, 102, 245);
            cuibtnGuardar.HoverBackground = Color.FromArgb(30, 102, 245);
            cuibtnGuardar.HoverForeColor = Color.WhiteSmoke;
            cuibtnGuardar.HoverImageTint = Color.White;
            cuibtnGuardar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuibtnGuardar.Image = null;
            cuibtnGuardar.ImageAutoCenter = true;
            cuibtnGuardar.ImageExpand = new Point(0, 0);
            cuibtnGuardar.ImageOffset = new Point(0, 0);
            cuibtnGuardar.Location = new Point(202, 804);
            cuibtnGuardar.Name = "cuibtnGuardar";
            cuibtnGuardar.NormalBackground = Color.FromArgb(23, 146, 153);
            cuibtnGuardar.NormalForeColor = Color.FromArgb(30, 102, 245);
            cuibtnGuardar.NormalImageTint = Color.White;
            cuibtnGuardar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuibtnGuardar.OutlineThickness = 1F;
            cuibtnGuardar.PressedBackground = Color.WhiteSmoke;
            cuibtnGuardar.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuibtnGuardar.PressedImageTint = Color.White;
            cuibtnGuardar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuibtnGuardar.Rounding = new Padding(8);
            cuibtnGuardar.Size = new Size(164, 56);
            cuibtnGuardar.TabIndex = 16;
            cuibtnGuardar.TextAlignment = StringAlignment.Center;
            cuibtnGuardar.TextOffset = new Point(0, 0);
            cuibtnGuardar.Click += cuibtnGuardar_Click;
            // 
            // cuibtnEliminar
            // 
            cuibtnEliminar.AutoSize = true;
            cuibtnEliminar.BackColor = Color.Transparent;
            cuibtnEliminar.CheckButton = false;
            cuibtnEliminar.Checked = false;
            cuibtnEliminar.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuibtnEliminar.CheckedForeColor = Color.White;
            cuibtnEliminar.CheckedImageTint = Color.White;
            cuibtnEliminar.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuibtnEliminar.Content = "Eliminar";
            cuibtnEliminar.DialogResult = DialogResult.None;
            cuibtnEliminar.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuibtnEliminar.ForeColor = Color.Crimson;
            cuibtnEliminar.HoverBackground = Color.Crimson;
            cuibtnEliminar.HoverForeColor = Color.WhiteSmoke;
            cuibtnEliminar.HoverImageTint = Color.White;
            cuibtnEliminar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuibtnEliminar.Image = null;
            cuibtnEliminar.ImageAutoCenter = true;
            cuibtnEliminar.ImageExpand = new Point(0, 0);
            cuibtnEliminar.ImageOffset = new Point(0, 0);
            cuibtnEliminar.Location = new Point(202, 716);
            cuibtnEliminar.Name = "cuibtnEliminar";
            cuibtnEliminar.NormalBackground = Color.PaleVioletRed;
            cuibtnEliminar.NormalForeColor = Color.Crimson;
            cuibtnEliminar.NormalImageTint = Color.White;
            cuibtnEliminar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuibtnEliminar.OutlineThickness = 1F;
            cuibtnEliminar.PressedBackground = Color.WhiteSmoke;
            cuibtnEliminar.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuibtnEliminar.PressedImageTint = Color.White;
            cuibtnEliminar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuibtnEliminar.Rounding = new Padding(8);
            cuibtnEliminar.Size = new Size(164, 56);
            cuibtnEliminar.TabIndex = 12;
            cuibtnEliminar.TextAlignment = StringAlignment.Center;
            cuibtnEliminar.TextOffset = new Point(0, 0);
            cuibtnEliminar.Click += cuibtnEliminar_Click;
            // 
            // cuibtnAgregarRopa
            // 
            cuibtnAgregarRopa.AutoSize = true;
            cuibtnAgregarRopa.BackColor = Color.Transparent;
            cuibtnAgregarRopa.CheckButton = false;
            cuibtnAgregarRopa.Checked = false;
            cuibtnAgregarRopa.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuibtnAgregarRopa.CheckedForeColor = Color.White;
            cuibtnAgregarRopa.CheckedImageTint = Color.White;
            cuibtnAgregarRopa.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuibtnAgregarRopa.Content = "Agregar";
            cuibtnAgregarRopa.DialogResult = DialogResult.None;
            cuibtnAgregarRopa.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuibtnAgregarRopa.ForeColor = Color.ForestGreen;
            cuibtnAgregarRopa.HoverBackground = Color.ForestGreen;
            cuibtnAgregarRopa.HoverForeColor = Color.WhiteSmoke;
            cuibtnAgregarRopa.HoverImageTint = Color.White;
            cuibtnAgregarRopa.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuibtnAgregarRopa.Image = null;
            cuibtnAgregarRopa.ImageAutoCenter = true;
            cuibtnAgregarRopa.ImageExpand = new Point(0, 0);
            cuibtnAgregarRopa.ImageOffset = new Point(0, 0);
            cuibtnAgregarRopa.Location = new Point(11, 716);
            cuibtnAgregarRopa.Name = "cuibtnAgregarRopa";
            cuibtnAgregarRopa.NormalBackground = Color.Lime;
            cuibtnAgregarRopa.NormalForeColor = Color.ForestGreen;
            cuibtnAgregarRopa.NormalImageTint = Color.White;
            cuibtnAgregarRopa.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuibtnAgregarRopa.OutlineThickness = 1F;
            cuibtnAgregarRopa.PressedBackground = Color.WhiteSmoke;
            cuibtnAgregarRopa.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuibtnAgregarRopa.PressedImageTint = Color.White;
            cuibtnAgregarRopa.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuibtnAgregarRopa.Rounding = new Padding(8);
            cuibtnAgregarRopa.Size = new Size(164, 56);
            cuibtnAgregarRopa.TabIndex = 11;
            cuibtnAgregarRopa.TextAlignment = StringAlignment.Center;
            cuibtnAgregarRopa.TextOffset = new Point(0, 0);
            cuibtnAgregarRopa.Click += cuibtnAgregarRopa_Click;
            // 
            // cuiLabel6
            // 
            cuiLabel6.AutoSize = true;
            cuiLabel6.BackColor = Color.Transparent;
            cuiLabel6.Content = "Cantidad\\*";
            cuiLabel6.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel6.HorizontalAlignment = StringAlignment.Center;
            cuiLabel6.Location = new Point(11, 541);
            cuiLabel6.Margin = new Padding(4, 5, 4, 5);
            cuiLabel6.Name = "cuiLabel6";
            cuiLabel6.Size = new Size(216, 59);
            cuiLabel6.TabIndex = 10;
            cuiLabel6.VerticalAlignment = StringAlignment.Center;
            // 
            // nudCantidad
            // 
            nudCantidad.AutoSize = true;
            nudCantidad.BorderStyle = BorderStyle.FixedSingle;
            nudCantidad.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidad.Location = new Point(11, 608);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(234, 38);
            nudCantidad.TabIndex = 9;
            nudCantidad.TextAlign = HorizontalAlignment.Center;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cuicmbColor
            // 
            cuicmbColor.AutoSize = true;
            cuicmbColor.BackgroundColor = Color.FromArgb(255, 255, 255);
            cuicmbColor.DropDownBackgroundColor = Color.White;
            cuicmbColor.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cuicmbColor.ExpandArrowColor = Color.Gray;
            cuicmbColor.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cuicmbColor.ForeColor = Color.Gray;
            cuicmbColor.Items = new string[]
    {
    "Negro",
    "Blanco",
    "Gris",
    "Azul",
    "Rojo",
    "Amarillo",
    "Celeste",
    "Morado",
    "Cafe",
    "Verde",
    "Rosa",
    "Naranja"
    };
            cuicmbColor.Location = new Point(11, 454);
            cuicmbColor.Margin = new Padding(8);
            cuicmbColor.MaxDropDownHeight = 240;
            cuicmbColor.Name = "cuicmbColor";
            cuicmbColor.NoSelectionText = "--Seleccione--";
            cuicmbColor.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuicmbColor.OutlineThickness = 1F;
            cuicmbColor.Rounding = 8;
            cuicmbColor.SelectedIndex = -1;
            cuicmbColor.SelectedItem = "";
            cuicmbColor.Size = new Size(355, 58);
            cuicmbColor.SortAlphabetically = true;
            cuicmbColor.TabIndex = 7;
            // 
            // cuiLabel5
            // 
            cuiLabel5.AutoSize = true;
            cuiLabel5.BackColor = Color.Transparent;
            cuiLabel5.Content = "Color\\*";
            cuiLabel5.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel5.HorizontalAlignment = StringAlignment.Center;
            cuiLabel5.Location = new Point(11, 395);
            cuiLabel5.Margin = new Padding(4, 5, 4, 5);
            cuiLabel5.Name = "cuiLabel5";
            cuiLabel5.Size = new Size(139, 59);
            cuiLabel5.TabIndex = 6;
            cuiLabel5.VerticalAlignment = StringAlignment.Center;
            // 
            // cuicmbTalla
            // 
            cuicmbTalla.AutoSize = true;
            cuicmbTalla.BackgroundColor = Color.FromArgb(255, 255, 255);
            cuicmbTalla.DropDownBackgroundColor = Color.White;
            cuicmbTalla.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cuicmbTalla.ExpandArrowColor = Color.Gray;
            cuicmbTalla.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cuicmbTalla.ForeColor = Color.Gray;
            cuicmbTalla.Items = new string[]
    {
    "XS",
    "S",
    "M",
    "L",
    "XL",
    "XXL"
    };
            cuicmbTalla.Location = new Point(11, 296);
            cuicmbTalla.Margin = new Padding(8);
            cuicmbTalla.MaxDropDownHeight = 240;
            cuicmbTalla.Name = "cuicmbTalla";
            cuicmbTalla.NoSelectionText = "--Seleccione--";
            cuicmbTalla.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuicmbTalla.OutlineThickness = 1F;
            cuicmbTalla.Rounding = 8;
            cuicmbTalla.SelectedIndex = -1;
            cuicmbTalla.SelectedItem = "";
            cuicmbTalla.Size = new Size(355, 58);
            cuicmbTalla.SortAlphabetically = true;
            cuicmbTalla.TabIndex = 5;
            // 
            // cuiLabel4
            // 
            cuiLabel4.AutoSize = true;
            cuiLabel4.BackColor = Color.Transparent;
            cuiLabel4.Content = "Talla\\*";
            cuiLabel4.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(11, 233);
            cuiLabel4.Margin = new Padding(4, 5, 4, 5);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(139, 59);
            cuiLabel4.TabIndex = 4;
            cuiLabel4.VerticalAlignment = StringAlignment.Center;
            // 
            // cuicmbTipo
            // 
            cuicmbTipo.AutoSize = true;
            cuicmbTipo.BackgroundColor = Color.FromArgb(255, 255, 255);
            cuicmbTipo.DropDownBackgroundColor = Color.White;
            cuicmbTipo.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cuicmbTipo.ExpandArrowColor = Color.Gray;
            cuicmbTipo.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cuicmbTipo.ForeColor = Color.Gray;
            cuicmbTipo.Items = new string[]
    {
    "Falda",
    "Pantalon",
    "Camisa",
    "Zapatos",
    "Vestido",
    "Abrigos"
    };
            cuicmbTipo.Location = new Point(11, 141);
            cuicmbTipo.Margin = new Padding(8);
            cuicmbTipo.MaxDropDownHeight = 240;
            cuicmbTipo.Name = "cuicmbTipo";
            cuicmbTipo.NoSelectionText = "--Seleccione--";
            cuicmbTipo.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuicmbTipo.OutlineThickness = 1F;
            cuicmbTipo.Rounding = 8;
            cuicmbTipo.SelectedIndex = -1;
            cuicmbTipo.SelectedItem = "";
            cuicmbTipo.Size = new Size(355, 58);
            cuicmbTipo.SortAlphabetically = true;
            cuicmbTipo.TabIndex = 3;
            // 
            // cuiLabel3
            // 
            cuiLabel3.AutoSize = true;
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "Tipo\\*";
            cuiLabel3.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(4, 79);
            cuiLabel3.Margin = new Padding(4, 5, 4, 5);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(139, 59);
            cuiLabel3.TabIndex = 2;
            cuiLabel3.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel1
            // 
            cuiLabel1.AutoSize = true;
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Agregar\\ Prenda";
            cuiLabel1.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(11, -3);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(359, 92);
            cuiLabel1.TabIndex = 1;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiPanelGradient3
            // 
            cuiPanelGradient3.AutoSize = true;
            cuiPanelGradient3.Controls.Add(dtgInventarioRopa);
            cuiPanelGradient3.Controls.Add(cuiLabel7);
            cuiPanelGradient3.Dock = DockStyle.Fill;
            cuiPanelGradient3.GradientAngle = 0F;
            cuiPanelGradient3.Location = new Point(397, 3);
            cuiPanelGradient3.Name = "cuiPanelGradient3";
            cuiPanelGradient3.OutlineThickness = 1F;
            cuiPanelGradient3.PanelColor1 = Color.White;
            cuiPanelGradient3.PanelColor2 = Color.White;
            cuiPanelGradient3.PanelOutlineColor1 = Color.Red;
            cuiPanelGradient3.PanelOutlineColor2 = Color.Red;
            cuiPanelGradient3.Rounding = new Padding(8);
            cuiPanelGradient3.Size = new Size(929, 866);
            cuiPanelGradient3.TabIndex = 1;
            // 
            // dtgInventarioRopa
            // 
            dtgInventarioRopa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgInventarioRopa.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgInventarioRopa.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dtgInventarioRopa.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgInventarioRopa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInventarioRopa.Columns.AddRange(new DataGridViewColumn[] { Tipo, Talla, ColumnaColor, Cantidad });
            dtgInventarioRopa.Location = new Point(26, 79);
            dtgInventarioRopa.Name = "dtgInventarioRopa";
            dtgInventarioRopa.ReadOnly = true;
            dtgInventarioRopa.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dtgInventarioRopa.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtgInventarioRopa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgInventarioRopa.Size = new Size(882, 762);
            dtgInventarioRopa.TabIndex = 3;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            // 
            // Talla
            // 
            Talla.HeaderText = "Talla";
            Talla.MinimumWidth = 6;
            Talla.Name = "Talla";
            Talla.ReadOnly = true;
            // 
            // ColumnaColor
            // 
            ColumnaColor.HeaderText = "Color";
            ColumnaColor.MinimumWidth = 6;
            ColumnaColor.Name = "ColumnaColor";
            ColumnaColor.ReadOnly = true;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            // 
            // cuiLabel7
            // 
            cuiLabel7.AutoSize = true;
            cuiLabel7.BackColor = Color.Transparent;
            cuiLabel7.Content = "Inventario\\ Actual";
            cuiLabel7.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cuiLabel7.HorizontalAlignment = StringAlignment.Center;
            cuiLabel7.Location = new Point(331, -3);
            cuiLabel7.Margin = new Padding(4, 5, 4, 5);
            cuiLabel7.Name = "cuiLabel7";
            cuiLabel7.Size = new Size(359, 90);
            cuiLabel7.TabIndex = 2;
            cuiLabel7.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiPanelGradient1
            // 
            cuiPanelGradient1.AutoSize = true;
            cuiPanelGradient1.Controls.Add(pictureBox1);
            cuiPanelGradient1.Controls.Add(cuiLabel2);
            cuiPanelGradient1.Dock = DockStyle.Fill;
            cuiPanelGradient1.GradientAngle = 0F;
            cuiPanelGradient1.Location = new Point(3, 3);
            cuiPanelGradient1.Name = "cuiPanelGradient1";
            cuiPanelGradient1.OutlineThickness = 1F;
            cuiPanelGradient1.PanelColor1 = Color.FromArgb(234, 153, 156);
            cuiPanelGradient1.PanelColor2 = Color.FromArgb(210, 15, 57);
            cuiPanelGradient1.PanelOutlineColor1 = Color.Red;
            cuiPanelGradient1.PanelOutlineColor2 = Color.Red;
            cuiPanelGradient1.Rounding = new Padding(8);
            cuiPanelGradient1.Size = new Size(1329, 116);
            cuiPanelGradient1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.inventarioDeRopa_icon1;
            pictureBox1.Location = new Point(372, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // cuiLabel2
            // 
            cuiLabel2.AutoSize = true;
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Inventario\\ De\\ Ropa";
            cuiLabel2.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(441, 11);
            cuiLabel2.Margin = new Padding(4, 5, 4, 5);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(529, 90);
            cuiLabel2.TabIndex = 0;
            cuiLabel2.VerticalAlignment = StringAlignment.Center;
            // 
            // frmInventarioDeRopa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 1000);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInventarioDeRopa";
            Text = "frmInventarioDeRopa";
            FormClosing += frmInventarioDeRopa_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            cuiPanelGradient2.ResumeLayout(false);
            cuiPanelGradient2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            cuiPanelGradient3.ResumeLayout(false);
            cuiPanelGradient3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInventarioRopa).EndInit();
            cuiPanelGradient1.ResumeLayout(false);
            cuiPanelGradient1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private CuoreUI.Controls.cuiPanelGradient cuiPanelGradient1;
        private CuoreUI.Controls.cuiPanelGradient cuiPanelGradient2;
        private CuoreUI.Controls.cuiPanelGradient cuiPanelGradient3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiComboBox cuicmbTipo;
        private CuoreUI.Controls.cuiComboBox cuicmbTalla;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiComboBox cuicmbColor;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private NumericUpDown nudCantidad;
        private CuoreUI.Controls.cuiButton cuibtnAgregarRopa;
        private CuoreUI.Controls.cuiLabel cuiLabel7;
        private DataGridView dtgInventarioRopa;
        private CuoreUI.Controls.cuiButton cuibtnEliminar;
        private CuoreUI.Controls.cuiButton cuibtnGuardar;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Talla;
        private DataGridViewTextBoxColumn ColumnaColor;
        private DataGridViewTextBoxColumn Cantidad;
    }
}