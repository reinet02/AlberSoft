namespace AlberSoft.Alojamiento_e_Inventario
{
    partial class fmInventarioComida
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            cuiPanelGradient1 = new CuoreUI.Controls.cuiPanelGradient();
            pictureBox1 = new PictureBox();
            clblComida = new CuoreUI.Controls.cuiLabel();
            tableLayoutPanel2 = new TableLayoutPanel();
            cuiPanelGradient2 = new CuoreUI.Controls.cuiPanelGradient();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            dtgInventarioComida = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            FechaDeVencimiento = new DataGridViewTextBoxColumn();
            cuiPanelGradient3 = new CuoreUI.Controls.cuiPanelGradient();
            nudCantidadComi = new NumericUpDown();
            cuibtnGuardar = new CuoreUI.Controls.cuiButton();
            cuibtnEliminar = new CuoreUI.Controls.cuiButton();
            cuibtnAgregar = new CuoreUI.Controls.cuiButton();
            dtpFechaVencimiento = new DateTimePicker();
            cuiLabel7 = new CuoreUI.Controls.cuiLabel();
            cuiLabel6 = new CuoreUI.Controls.cuiLabel();
            cuiLabel5 = new CuoreUI.Controls.cuiLabel();
            cuicmbCategoria = new CuoreUI.Controls.cuiComboBox();
            cuiLabel4 = new CuoreUI.Controls.cuiLabel();
            cuitxtID = new CuoreUI.Controls.cuiTextBox();
            cuicmbProducto = new CuoreUI.Controls.cuiComboBox();
            cuiLabel3 = new CuoreUI.Controls.cuiLabel();
            cuiLabel2 = new CuoreUI.Controls.cuiLabel();
            tableLayoutPanel1.SuspendLayout();
            cuiPanelGradient1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            cuiPanelGradient2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgInventarioComida).BeginInit();
            cuiPanelGradient3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadComi).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(cuiPanelGradient1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.44805F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.5519562F));
            tableLayoutPanel1.Size = new Size(1335, 1000);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // cuiPanelGradient1
            // 
            cuiPanelGradient1.AutoSize = true;
            cuiPanelGradient1.Controls.Add(pictureBox1);
            cuiPanelGradient1.Controls.Add(clblComida);
            cuiPanelGradient1.Dock = DockStyle.Fill;
            cuiPanelGradient1.GradientAngle = 0F;
            cuiPanelGradient1.Location = new Point(3, 3);
            cuiPanelGradient1.Name = "cuiPanelGradient1";
            cuiPanelGradient1.OutlineThickness = 1F;
            cuiPanelGradient1.PanelColor1 = Color.FromArgb(4, 165, 229);
            cuiPanelGradient1.PanelColor2 = Color.FromArgb(204, 208, 218);
            cuiPanelGradient1.PanelOutlineColor1 = Color.FromArgb(203, 166, 247);
            cuiPanelGradient1.PanelOutlineColor2 = Color.FromArgb(203, 166, 247);
            cuiPanelGradient1.Rounding = new Padding(8);
            cuiPanelGradient1.Size = new Size(1329, 118);
            cuiPanelGradient1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.inventarioDeComida_icon1;
            pictureBox1.Location = new Point(405, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(65, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // clblComida
            // 
            clblComida.BackColor = Color.Transparent;
            clblComida.Content = "Inventario\\ de\\ Comida";
            clblComida.Font = new Font("Microsoft Sans Serif", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clblComida.ForeColor = Color.FromArgb(31, 41, 55);
            clblComida.HorizontalAlignment = StringAlignment.Center;
            clblComida.Location = new Point(461, 22);
            clblComida.Margin = new Padding(4, 5, 4, 5);
            clblComida.Name = "clblComida";
            clblComida.Size = new Size(549, 81);
            clblComida.TabIndex = 0;
            clblComida.VerticalAlignment = StringAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.4657555F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.53425F));
            tableLayoutPanel2.Controls.Add(cuiPanelGradient2, 1, 0);
            tableLayoutPanel2.Controls.Add(cuiPanelGradient3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 127);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(1329, 870);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // cuiPanelGradient2
            // 
            cuiPanelGradient2.AutoSize = true;
            cuiPanelGradient2.Controls.Add(cuiLabel1);
            cuiPanelGradient2.Controls.Add(dtgInventarioComida);
            cuiPanelGradient2.Dock = DockStyle.Fill;
            cuiPanelGradient2.GradientAngle = 0F;
            cuiPanelGradient2.Location = new Point(394, 3);
            cuiPanelGradient2.Name = "cuiPanelGradient2";
            cuiPanelGradient2.OutlineThickness = 1F;
            cuiPanelGradient2.PanelColor1 = Color.White;
            cuiPanelGradient2.PanelColor2 = Color.White;
            cuiPanelGradient2.PanelOutlineColor1 = Color.FromArgb(203, 166, 247);
            cuiPanelGradient2.PanelOutlineColor2 = Color.FromArgb(203, 166, 247);
            cuiPanelGradient2.Rounding = new Padding(8);
            cuiPanelGradient2.Size = new Size(932, 864);
            cuiPanelGradient2.TabIndex = 7;
            // 
            // cuiLabel1
            // 
            cuiLabel1.BackColor = Color.Transparent;
            cuiLabel1.Content = "Inventario\\ Actual";
            cuiLabel1.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cuiLabel1.ForeColor = Color.FromArgb(31, 41, 55);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(234, 5);
            cuiLabel1.Margin = new Padding(4, 5, 4, 5);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(408, 52);
            cuiLabel1.TabIndex = 1;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // dtgInventarioComida
            // 
            dtgInventarioComida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgInventarioComida.BackgroundColor = Color.FromArgb(239, 241, 245);
            dtgInventarioComida.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dtgInventarioComida.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(136, 57, 239);
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dtgInventarioComida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgInventarioComida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgInventarioComida.Columns.AddRange(new DataGridViewColumn[] { ID, Producto, Categoria, Cantidad, FechaDeVencimiento });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(198, 160, 246);
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dtgInventarioComida.DefaultCellStyle = dataGridViewCellStyle2;
            dtgInventarioComida.GridColor = SystemColors.HotTrack;
            dtgInventarioComida.Location = new Point(18, 65);
            dtgInventarioComida.Name = "dtgInventarioComida";
            dtgInventarioComida.ReadOnly = true;
            dtgInventarioComida.RowHeadersWidth = 51;
            dtgInventarioComida.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgInventarioComida.Size = new Size(865, 795);
            dtgInventarioComida.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Resizable = DataGridViewTriState.False;
            // 
            // Producto
            // 
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.ReadOnly = true;
            Producto.Resizable = DataGridViewTriState.False;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            Categoria.Resizable = DataGridViewTriState.False;
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.ReadOnly = true;
            Cantidad.Resizable = DataGridViewTriState.False;
            // 
            // FechaDeVencimiento
            // 
            FechaDeVencimiento.HeaderText = "Fecha de Vencimiento";
            FechaDeVencimiento.MinimumWidth = 6;
            FechaDeVencimiento.Name = "FechaDeVencimiento";
            FechaDeVencimiento.ReadOnly = true;
            FechaDeVencimiento.Resizable = DataGridViewTriState.False;
            // 
            // cuiPanelGradient3
            // 
            cuiPanelGradient3.AutoSize = true;
            cuiPanelGradient3.Controls.Add(nudCantidadComi);
            cuiPanelGradient3.Controls.Add(cuibtnGuardar);
            cuiPanelGradient3.Controls.Add(cuibtnEliminar);
            cuiPanelGradient3.Controls.Add(cuibtnAgregar);
            cuiPanelGradient3.Controls.Add(dtpFechaVencimiento);
            cuiPanelGradient3.Controls.Add(cuiLabel7);
            cuiPanelGradient3.Controls.Add(cuiLabel6);
            cuiPanelGradient3.Controls.Add(cuiLabel5);
            cuiPanelGradient3.Controls.Add(cuicmbCategoria);
            cuiPanelGradient3.Controls.Add(cuiLabel4);
            cuiPanelGradient3.Controls.Add(cuitxtID);
            cuiPanelGradient3.Controls.Add(cuicmbProducto);
            cuiPanelGradient3.Controls.Add(cuiLabel3);
            cuiPanelGradient3.Controls.Add(cuiLabel2);
            cuiPanelGradient3.Dock = DockStyle.Fill;
            cuiPanelGradient3.GradientAngle = 0F;
            cuiPanelGradient3.Location = new Point(3, 3);
            cuiPanelGradient3.Name = "cuiPanelGradient3";
            cuiPanelGradient3.OutlineThickness = 1F;
            cuiPanelGradient3.PanelColor1 = Color.White;
            cuiPanelGradient3.PanelColor2 = Color.White;
            cuiPanelGradient3.PanelOutlineColor1 = Color.FromArgb(203, 166, 247);
            cuiPanelGradient3.PanelOutlineColor2 = Color.FromArgb(203, 166, 247);
            cuiPanelGradient3.Rounding = new Padding(8);
            cuiPanelGradient3.Size = new Size(385, 864);
            cuiPanelGradient3.TabIndex = 6;
            // 
            // nudCantidadComi
            // 
            nudCantidadComi.AutoSize = true;
            nudCantidadComi.BackColor = Color.Silver;
            nudCantidadComi.BorderStyle = BorderStyle.FixedSingle;
            nudCantidadComi.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudCantidadComi.Location = new Point(16, 537);
            nudCantidadComi.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidadComi.Name = "nudCantidadComi";
            nudCantidadComi.Size = new Size(234, 38);
            nudCantidadComi.TabIndex = 16;
            nudCantidadComi.TextAlign = HorizontalAlignment.Center;
            nudCantidadComi.Value = new decimal(new int[] { 1, 0, 0, 0 });
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
            cuibtnGuardar.Location = new Point(205, 802);
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
            cuibtnGuardar.TabIndex = 15;
            cuibtnGuardar.TextAlignment = StringAlignment.Center;
            cuibtnGuardar.TextOffset = new Point(0, 0);
            cuibtnGuardar.Click += cuibtnGuardar_Click;
            // 
            // cuibtnEliminar
            // 
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
            cuibtnEliminar.HoverBackground = Color.FromArgb(255, 128, 128);
            cuibtnEliminar.HoverForeColor = Color.WhiteSmoke;
            cuibtnEliminar.HoverImageTint = Color.White;
            cuibtnEliminar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuibtnEliminar.Image = null;
            cuibtnEliminar.ImageAutoCenter = true;
            cuibtnEliminar.ImageExpand = new Point(0, 0);
            cuibtnEliminar.ImageOffset = new Point(0, 0);
            cuibtnEliminar.Location = new Point(205, 724);
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
            cuibtnEliminar.TabIndex = 14;
            cuibtnEliminar.TextAlignment = StringAlignment.Center;
            cuibtnEliminar.TextOffset = new Point(0, 0);
            cuibtnEliminar.Click += cuibtnEliminar_Click;
            // 
            // cuibtnAgregar
            // 
            cuibtnAgregar.BackColor = Color.Transparent;
            cuibtnAgregar.CheckButton = false;
            cuibtnAgregar.Checked = false;
            cuibtnAgregar.CheckedBackground = Color.FromArgb(255, 106, 0);
            cuibtnAgregar.CheckedForeColor = Color.White;
            cuibtnAgregar.CheckedImageTint = Color.White;
            cuibtnAgregar.CheckedOutline = Color.FromArgb(255, 106, 0);
            cuibtnAgregar.Content = "Agregar";
            cuibtnAgregar.DialogResult = DialogResult.None;
            cuibtnAgregar.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuibtnAgregar.ForeColor = Color.ForestGreen;
            cuibtnAgregar.HoverBackground = Color.ForestGreen;
            cuibtnAgregar.HoverForeColor = Color.White;
            cuibtnAgregar.HoverImageTint = Color.WhiteSmoke;
            cuibtnAgregar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            cuibtnAgregar.Image = null;
            cuibtnAgregar.ImageAutoCenter = true;
            cuibtnAgregar.ImageExpand = new Point(0, 0);
            cuibtnAgregar.ImageOffset = new Point(0, 0);
            cuibtnAgregar.Location = new Point(16, 724);
            cuibtnAgregar.Name = "cuibtnAgregar";
            cuibtnAgregar.NormalBackground = Color.Lime;
            cuibtnAgregar.NormalForeColor = Color.ForestGreen;
            cuibtnAgregar.NormalImageTint = Color.White;
            cuibtnAgregar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            cuibtnAgregar.OutlineThickness = 1F;
            cuibtnAgregar.PressedBackground = Color.WhiteSmoke;
            cuibtnAgregar.PressedForeColor = Color.FromArgb(32, 32, 32);
            cuibtnAgregar.PressedImageTint = Color.White;
            cuibtnAgregar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            cuibtnAgregar.Rounding = new Padding(8);
            cuibtnAgregar.Size = new Size(164, 56);
            cuibtnAgregar.TabIndex = 13;
            cuibtnAgregar.TextAlignment = StringAlignment.Center;
            cuibtnAgregar.TextOffset = new Point(0, 0);
            cuibtnAgregar.Click += cuibtnAgregar_Click;
            // 
            // dtpFechaVencimiento
            // 
            dtpFechaVencimiento.CalendarFont = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFechaVencimiento.CalendarMonthBackground = Color.FromArgb(224, 224, 224);
            dtpFechaVencimiento.CalendarTitleBackColor = Color.FromArgb(224, 224, 224);
            dtpFechaVencimiento.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpFechaVencimiento.Format = DateTimePickerFormat.Short;
            dtpFechaVencimiento.ImeMode = ImeMode.NoControl;
            dtpFechaVencimiento.Location = new Point(89, 652);
            dtpFechaVencimiento.Name = "dtpFechaVencimiento";
            dtpFechaVencimiento.Size = new Size(183, 38);
            dtpFechaVencimiento.TabIndex = 12;
            // 
            // cuiLabel7
            // 
            cuiLabel7.BackColor = Color.Transparent;
            cuiLabel7.Content = "Fecha\\ de\\ Vencimiento:";
            cuiLabel7.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel7.ForeColor = Color.FromArgb(31, 41, 55);
            cuiLabel7.HorizontalAlignment = StringAlignment.Center;
            cuiLabel7.Location = new Point(15, 592);
            cuiLabel7.Margin = new Padding(4, 5, 4, 5);
            cuiLabel7.Name = "cuiLabel7";
            cuiLabel7.Size = new Size(352, 52);
            cuiLabel7.TabIndex = 11;
            cuiLabel7.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel6
            // 
            cuiLabel6.BackColor = Color.Transparent;
            cuiLabel6.Content = "Cantidad:";
            cuiLabel6.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel6.ForeColor = Color.FromArgb(31, 41, 55);
            cuiLabel6.HorizontalAlignment = StringAlignment.Center;
            cuiLabel6.Location = new Point(16, 477);
            cuiLabel6.Margin = new Padding(4, 5, 4, 5);
            cuiLabel6.Name = "cuiLabel6";
            cuiLabel6.Size = new Size(178, 52);
            cuiLabel6.TabIndex = 9;
            cuiLabel6.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel5
            // 
            cuiLabel5.BackColor = Color.Transparent;
            cuiLabel5.Content = "Categoria:";
            cuiLabel5.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel5.ForeColor = Color.FromArgb(31, 41, 55);
            cuiLabel5.HorizontalAlignment = StringAlignment.Center;
            cuiLabel5.Location = new Point(16, 338);
            cuiLabel5.Margin = new Padding(4, 5, 4, 5);
            cuiLabel5.Name = "cuiLabel5";
            cuiLabel5.Size = new Size(184, 52);
            cuiLabel5.TabIndex = 8;
            cuiLabel5.VerticalAlignment = StringAlignment.Center;
            // 
            // cuicmbCategoria
            // 
            cuicmbCategoria.BackgroundColor = Color.FromArgb(224, 224, 224);
            cuicmbCategoria.DropDownBackgroundColor = Color.Silver;
            cuicmbCategoria.DropDownForeColor = Color.Black;
            cuicmbCategoria.ExpandArrowColor = Color.FromArgb(203, 166, 247);
            cuicmbCategoria.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cuicmbCategoria.ForeColor = Color.Black;
            cuicmbCategoria.Items = new string[]
    {
    "Granos",
    "Carnes",
    "Lacteos",
    "Panaderia",
    "Frutas",
    "Verdura"
    };
            cuicmbCategoria.Location = new Point(16, 388);
            cuicmbCategoria.Margin = new Padding(16, 12, 16, 12);
            cuicmbCategoria.MaxDropDownHeight = 170;
            cuicmbCategoria.Name = "cuicmbCategoria";
            cuicmbCategoria.NoSelectionText = "----Seleccione----";
            cuicmbCategoria.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuicmbCategoria.OutlineThickness = 1F;
            cuicmbCategoria.Rounding = 8;
            cuicmbCategoria.SelectedIndex = -1;
            cuicmbCategoria.SelectedItem = "";
            cuicmbCategoria.Size = new Size(353, 46);
            cuicmbCategoria.SortAlphabetically = true;
            cuicmbCategoria.TabIndex = 7;
            // 
            // cuiLabel4
            // 
            cuiLabel4.BackColor = Color.Transparent;
            cuiLabel4.Content = "Producto:";
            cuiLabel4.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel4.ForeColor = Color.FromArgb(31, 41, 55);
            cuiLabel4.HorizontalAlignment = StringAlignment.Center;
            cuiLabel4.Location = new Point(15, 204);
            cuiLabel4.Margin = new Padding(4, 5, 4, 5);
            cuiLabel4.Name = "cuiLabel4";
            cuiLabel4.Size = new Size(184, 52);
            cuiLabel4.TabIndex = 6;
            cuiLabel4.VerticalAlignment = StringAlignment.Center;
            // 
            // cuitxtID
            // 
            cuitxtID.BackgroundColor = Color.FromArgb(224, 224, 224);
            cuitxtID.Content = "";
            cuitxtID.FocusBackgroundColor = Color.White;
            cuitxtID.FocusImageTint = Color.White;
            cuitxtID.FocusOutlineColor = Color.FromArgb(255, 106, 0);
            cuitxtID.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cuitxtID.ForeColor = Color.Black;
            cuitxtID.Image = null;
            cuitxtID.ImageExpand = new Point(0, 0);
            cuitxtID.ImageOffset = new Point(0, 0);
            cuitxtID.Location = new Point(15, 127);
            cuitxtID.Margin = new Padding(4);
            cuitxtID.Multiline = false;
            cuitxtID.Name = "cuitxtID";
            cuitxtID.NormalImageTint = Color.White;
            cuitxtID.OutlineColor = Color.FromArgb(128, 128, 128, 128);
            cuitxtID.Padding = new Padding(31, 8, 31, 0);
            cuitxtID.PasswordChar = false;
            cuitxtID.PlaceholderColor = Color.LightGray;
            cuitxtID.PlaceholderText = "";
            cuitxtID.Rounding = new Padding(8);
            cuitxtID.Size = new Size(353, 46);
            cuitxtID.TabIndex = 5;
            cuitxtID.TextOffset = new Size(0, 0);
            cuitxtID.UnderlinedStyle = true;
            // 
            // cuicmbProducto
            // 
            cuicmbProducto.BackgroundColor = Color.FromArgb(224, 224, 224);
            cuicmbProducto.DropDownBackgroundColor = Color.Silver;
            cuicmbProducto.DropDownForeColor = Color.Black;
            cuicmbProducto.ExpandArrowColor = Color.FromArgb(203, 166, 247);
            cuicmbProducto.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            cuicmbProducto.ForeColor = Color.Black;
            cuicmbProducto.Items = new string[]
    {
    "Arroz",
    "Pollo",
    "Leche",
    "Pan",
    "Manzanas",
    "Pasta",
    "Tomate"
    };
            cuicmbProducto.Location = new Point(15, 254);
            cuicmbProducto.Margin = new Padding(16, 12, 16, 12);
            cuicmbProducto.MaxDropDownHeight = 170;
            cuicmbProducto.Name = "cuicmbProducto";
            cuicmbProducto.NoSelectionText = "----Seleccione----";
            cuicmbProducto.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cuicmbProducto.OutlineThickness = 1F;
            cuicmbProducto.Rounding = 8;
            cuicmbProducto.SelectedIndex = -1;
            cuicmbProducto.SelectedItem = "";
            cuicmbProducto.Size = new Size(353, 46);
            cuicmbProducto.SortAlphabetically = true;
            cuicmbProducto.TabIndex = 4;
            // 
            // cuiLabel3
            // 
            cuiLabel3.BackColor = Color.Transparent;
            cuiLabel3.Content = "ID:";
            cuiLabel3.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel3.ForeColor = Color.FromArgb(31, 41, 55);
            cuiLabel3.HorizontalAlignment = StringAlignment.Center;
            cuiLabel3.Location = new Point(15, 76);
            cuiLabel3.Margin = new Padding(4, 5, 4, 5);
            cuiLabel3.Name = "cuiLabel3";
            cuiLabel3.Size = new Size(73, 52);
            cuiLabel3.TabIndex = 3;
            cuiLabel3.VerticalAlignment = StringAlignment.Center;
            // 
            // cuiLabel2
            // 
            cuiLabel2.BackColor = Color.Transparent;
            cuiLabel2.Content = "Agregar\\ Producto";
            cuiLabel2.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cuiLabel2.ForeColor = Color.FromArgb(31, 41, 55);
            cuiLabel2.HorizontalAlignment = StringAlignment.Center;
            cuiLabel2.Location = new Point(4, 5);
            cuiLabel2.Margin = new Padding(4, 5, 4, 5);
            cuiLabel2.Name = "cuiLabel2";
            cuiLabel2.Size = new Size(365, 52);
            cuiLabel2.TabIndex = 2;
            cuiLabel2.VerticalAlignment = StringAlignment.Center;
            // 
            // frmInventarioDeComida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1335, 1000);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmInventarioDeComida";
            Text = "frmInventarioDeComida";
            FormClosing += frmInventarioDeComida_FormClosing;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            cuiPanelGradient1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            cuiPanelGradient2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgInventarioComida).EndInit();
            cuiPanelGradient3.ResumeLayout(false);
            cuiPanelGradient3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCantidadComi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private CuoreUI.Controls.cuiPanelGradient cuiPanelGradient1;
        private PictureBox pictureBox1;
        private CuoreUI.Controls.cuiLabel clblComida;
        private CuoreUI.Controls.cuiPanelGradient cuiPanelGradient3;
        private NumericUpDown nudCantidadComi;
        private CuoreUI.Controls.cuiButton cuibtnGuardar;
        private CuoreUI.Controls.cuiButton cuibtnEliminar;
        private CuoreUI.Controls.cuiButton cuibtnAgregar;
        private DateTimePicker dtpFechaVencimiento;
        private CuoreUI.Controls.cuiLabel cuiLabel7;
        private CuoreUI.Controls.cuiLabel cuiLabel6;
        private CuoreUI.Controls.cuiLabel cuiLabel5;
        private CuoreUI.Controls.cuiComboBox cuicmbCategoria;
        private CuoreUI.Controls.cuiLabel cuiLabel4;
        private CuoreUI.Controls.cuiTextBox cuitxtID;
        private CuoreUI.Controls.cuiComboBox cuicmbProducto;
        private CuoreUI.Controls.cuiLabel cuiLabel3;
        private CuoreUI.Controls.cuiLabel cuiLabel2;
        private CuoreUI.Controls.cuiPanelGradient cuiPanelGradient2;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private DataGridView dtgInventarioComida;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn FechaDeVencimiento;
    }
}