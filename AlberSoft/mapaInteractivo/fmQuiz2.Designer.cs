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
            components = new System.ComponentModel.Container();
            tablaGeneral = new TableLayoutPanel();
            tablaOpcionesMultiples = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btn4 = new CuoreUI.Controls.cuiButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            btn3 = new CuoreUI.Controls.cuiButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            btn2 = new CuoreUI.Controls.cuiButton();
            tablaOpcion1 = new TableLayoutPanel();
            btn1 = new CuoreUI.Controls.cuiButton();
            labelPregunta = new CuoreUI.Controls.cuiLabel();
            tablaFila2General = new TableLayoutPanel();
            imgPregunta = new PictureBox();
            tablaGeneralFila2Derecha = new TableLayoutPanel();
            labelContadorRespuestasCorrectas = new CuoreUI.Controls.cuiLabel();
            btnSaltarPregunta = new CuoreUI.Controls.cuiButton();
            tablaGeneralFila2Izquierda = new TableLayoutPanel();
            labelTiempo = new CuoreUI.Controls.cuiLabel();
            temporizadorPreguntas = new System.Windows.Forms.Timer(components);
            tablaGeneral.SuspendLayout();
            tablaOpcionesMultiples.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tablaOpcion1.SuspendLayout();
            tablaFila2General.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPregunta).BeginInit();
            tablaGeneralFila2Derecha.SuspendLayout();
            tablaGeneralFila2Izquierda.SuspendLayout();
            SuspendLayout();
            // 
            // tablaGeneral
            // 
            tablaGeneral.ColumnCount = 1;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaGeneral.Controls.Add(tablaOpcionesMultiples, 0, 2);
            tablaGeneral.Controls.Add(labelPregunta, 0, 0);
            tablaGeneral.Controls.Add(tablaFila2General, 0, 1);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 3;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 10.369318F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 41.61932F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 32.9545441F));
            tablaGeneral.Size = new Size(973, 553);
            tablaGeneral.TabIndex = 0;
            // 
            // tablaOpcionesMultiples
            // 
            tablaOpcionesMultiples.ColumnCount = 2;
            tablaOpcionesMultiples.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaOpcionesMultiples.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaOpcionesMultiples.Controls.Add(tableLayoutPanel3, 1, 1);
            tablaOpcionesMultiples.Controls.Add(tableLayoutPanel2, 0, 1);
            tablaOpcionesMultiples.Controls.Add(tableLayoutPanel1, 1, 0);
            tablaOpcionesMultiples.Controls.Add(tablaOpcion1, 0, 0);
            tablaOpcionesMultiples.Dock = DockStyle.Fill;
            tablaOpcionesMultiples.Location = new Point(3, 340);
            tablaOpcionesMultiples.Name = "tablaOpcionesMultiples";
            tablaOpcionesMultiples.RowCount = 2;
            tablaOpcionesMultiples.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaOpcionesMultiples.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaOpcionesMultiples.Size = new Size(967, 210);
            tablaOpcionesMultiples.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6853151F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.31468F));
            tableLayoutPanel3.Controls.Add(btn4, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(486, 108);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(478, 99);
            tableLayoutPanel3.TabIndex = 20;
            // 
            // btn4
            // 
            btn4.CheckButton = false;
            btn4.Checked = false;
            btn4.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn4.CheckedForeColor = Color.White;
            btn4.CheckedImageTint = Color.White;
            btn4.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn4.Content = "Respuesta";
            btn4.DialogResult = DialogResult.None;
            btn4.Dock = DockStyle.Fill;
            btn4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn4.ForeColor = Color.White;
            btn4.HoverBackground = Color.FromArgb(200, 166, 209, 137);
            btn4.HoverForeColor = Color.White;
            btn4.HoverImageTint = Color.White;
            btn4.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn4.Image = null;
            btn4.ImageAutoCenter = true;
            btn4.ImageExpand = new Point(0, 0);
            btn4.ImageOffset = new Point(0, 0);
            btn4.Location = new Point(3, 3);
            btn4.Name = "btn4";
            btn4.NormalBackground = Color.FromArgb(166, 209, 137);
            btn4.NormalForeColor = Color.White;
            btn4.NormalImageTint = Color.White;
            btn4.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn4.OutlineThickness = 1F;
            btn4.PressedBackground = Color.WhiteSmoke;
            btn4.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn4.PressedImageTint = Color.White;
            btn4.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn4.Rounding = new Padding(8);
            btn4.Size = new Size(472, 93);
            btn4.TabIndex = 1;
            btn4.TextAlignment = StringAlignment.Center;
            btn4.TextOffset = new Point(0, 0);
            btn4.Click += Opcion_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6853151F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.31468F));
            tableLayoutPanel2.Controls.Add(btn3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 108);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(477, 99);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // btn3
            // 
            btn3.CheckButton = false;
            btn3.Checked = false;
            btn3.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn3.CheckedForeColor = Color.White;
            btn3.CheckedImageTint = Color.White;
            btn3.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn3.Content = "Respuesta";
            btn3.DialogResult = DialogResult.None;
            btn3.Dock = DockStyle.Fill;
            btn3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn3.ForeColor = Color.White;
            btn3.HoverBackground = Color.FromArgb(200, 229, 200, 144);
            btn3.HoverForeColor = Color.White;
            btn3.HoverImageTint = Color.White;
            btn3.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn3.Image = null;
            btn3.ImageAutoCenter = true;
            btn3.ImageExpand = new Point(0, 0);
            btn3.ImageOffset = new Point(0, 0);
            btn3.Location = new Point(3, 3);
            btn3.Name = "btn3";
            btn3.NormalBackground = Color.FromArgb(229, 200, 144);
            btn3.NormalForeColor = Color.White;
            btn3.NormalImageTint = Color.White;
            btn3.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn3.OutlineThickness = 1F;
            btn3.PressedBackground = Color.WhiteSmoke;
            btn3.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn3.PressedImageTint = Color.White;
            btn3.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn3.Rounding = new Padding(8);
            btn3.Size = new Size(471, 93);
            btn3.TabIndex = 1;
            btn3.TextAlignment = StringAlignment.Center;
            btn3.TextOffset = new Point(0, 0);
            btn3.Click += Opcion_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.6853151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.31468F));
            tableLayoutPanel1.Controls.Add(btn2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(486, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(478, 99);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // btn2
            // 
            btn2.CheckButton = false;
            btn2.Checked = false;
            btn2.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn2.CheckedForeColor = Color.White;
            btn2.CheckedImageTint = Color.White;
            btn2.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn2.Content = "Respuesta";
            btn2.DialogResult = DialogResult.None;
            btn2.Dock = DockStyle.Fill;
            btn2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn2.ForeColor = Color.White;
            btn2.HoverBackground = Color.FromArgb(200, 140, 170, 238);
            btn2.HoverForeColor = Color.White;
            btn2.HoverImageTint = Color.White;
            btn2.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn2.Image = null;
            btn2.ImageAutoCenter = true;
            btn2.ImageExpand = new Point(0, 0);
            btn2.ImageOffset = new Point(0, 0);
            btn2.Location = new Point(3, 3);
            btn2.Name = "btn2";
            btn2.NormalBackground = Color.FromArgb(140, 170, 238);
            btn2.NormalForeColor = Color.White;
            btn2.NormalImageTint = Color.White;
            btn2.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn2.OutlineThickness = 1F;
            btn2.PressedBackground = Color.WhiteSmoke;
            btn2.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn2.PressedImageTint = Color.White;
            btn2.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn2.Rounding = new Padding(8);
            btn2.Size = new Size(472, 93);
            btn2.TabIndex = 1;
            btn2.TextAlignment = StringAlignment.Center;
            btn2.TextOffset = new Point(0, 0);
            btn2.Click += Opcion_Click;
            // 
            // tablaOpcion1
            // 
            tablaOpcion1.ColumnCount = 1;
            tablaOpcion1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 99.99999F));
            tablaOpcion1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tablaOpcion1.Controls.Add(btn1, 0, 0);
            tablaOpcion1.Dock = DockStyle.Fill;
            tablaOpcion1.Location = new Point(3, 3);
            tablaOpcion1.Name = "tablaOpcion1";
            tablaOpcion1.RowCount = 1;
            tablaOpcion1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaOpcion1.Size = new Size(477, 99);
            tablaOpcion1.TabIndex = 17;
            // 
            // btn1
            // 
            btn1.CheckButton = false;
            btn1.Checked = false;
            btn1.CheckedBackground = Color.FromArgb(255, 106, 0);
            btn1.CheckedForeColor = Color.White;
            btn1.CheckedImageTint = Color.White;
            btn1.CheckedOutline = Color.FromArgb(255, 106, 0);
            btn1.Content = "Respuesta";
            btn1.DialogResult = DialogResult.None;
            btn1.Dock = DockStyle.Fill;
            btn1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn1.ForeColor = Color.White;
            btn1.HoverBackground = Color.FromArgb(200, 231, 130, 132);
            btn1.HoverForeColor = Color.White;
            btn1.HoverImageTint = Color.White;
            btn1.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btn1.Image = null;
            btn1.ImageAutoCenter = true;
            btn1.ImageExpand = new Point(0, 0);
            btn1.ImageOffset = new Point(0, 0);
            btn1.Location = new Point(3, 3);
            btn1.Name = "btn1";
            btn1.NormalBackground = Color.FromArgb(231, 130, 132);
            btn1.NormalForeColor = Color.White;
            btn1.NormalImageTint = Color.White;
            btn1.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btn1.OutlineThickness = 1F;
            btn1.PressedBackground = Color.WhiteSmoke;
            btn1.PressedForeColor = Color.FromArgb(32, 32, 32);
            btn1.PressedImageTint = Color.White;
            btn1.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btn1.Rounding = new Padding(8);
            btn1.Size = new Size(471, 93);
            btn1.TabIndex = 1;
            btn1.TextAlignment = StringAlignment.Center;
            btn1.TextOffset = new Point(0, 0);
            btn1.Click += Opcion_Click;
            // 
            // labelPregunta
            // 
            labelPregunta.Content = "Pregunta";
            labelPregunta.Dock = DockStyle.Fill;
            labelPregunta.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPregunta.HorizontalAlignment = StringAlignment.Center;
            labelPregunta.Location = new Point(4, 3);
            labelPregunta.Margin = new Padding(4, 3, 4, 3);
            labelPregunta.Name = "labelPregunta";
            labelPregunta.Size = new Size(965, 61);
            labelPregunta.TabIndex = 1;
            labelPregunta.VerticalAlignment = StringAlignment.Center;
            // 
            // tablaFila2General
            // 
            tablaFila2General.ColumnCount = 3;
            tablaFila2General.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 28.9473686F));
            tablaFila2General.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 71.0526352F));
            tablaFila2General.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 195F));
            tablaFila2General.Controls.Add(imgPregunta, 1, 0);
            tablaFila2General.Controls.Add(tablaGeneralFila2Derecha, 2, 0);
            tablaFila2General.Controls.Add(tablaGeneralFila2Izquierda, 0, 0);
            tablaFila2General.Dock = DockStyle.Fill;
            tablaFila2General.Location = new Point(3, 70);
            tablaFila2General.Name = "tablaFila2General";
            tablaFila2General.RowCount = 1;
            tablaFila2General.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaFila2General.Size = new Size(967, 264);
            tablaFila2General.TabIndex = 2;
            // 
            // imgPregunta
            // 
            imgPregunta.Dock = DockStyle.Fill;
            imgPregunta.Image = Properties.Resources.logo;
            imgPregunta.Location = new Point(226, 3);
            imgPregunta.Name = "imgPregunta";
            imgPregunta.Size = new Size(542, 258);
            imgPregunta.SizeMode = PictureBoxSizeMode.Zoom;
            imgPregunta.TabIndex = 17;
            imgPregunta.TabStop = false;
            // 
            // tablaGeneralFila2Derecha
            // 
            tablaGeneralFila2Derecha.ColumnCount = 1;
            tablaGeneralFila2Derecha.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaGeneralFila2Derecha.Controls.Add(labelContadorRespuestasCorrectas, 0, 1);
            tablaGeneralFila2Derecha.Controls.Add(btnSaltarPregunta, 0, 0);
            tablaGeneralFila2Derecha.Dock = DockStyle.Fill;
            tablaGeneralFila2Derecha.Location = new Point(774, 3);
            tablaGeneralFila2Derecha.Name = "tablaGeneralFila2Derecha";
            tablaGeneralFila2Derecha.RowCount = 3;
            tablaGeneralFila2Derecha.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5F));
            tablaGeneralFila2Derecha.RowStyles.Add(new RowStyle(SizeType.Percent, 71.5F));
            tablaGeneralFila2Derecha.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tablaGeneralFila2Derecha.Size = new Size(190, 258);
            tablaGeneralFila2Derecha.TabIndex = 2;
            tablaGeneralFila2Derecha.Paint += tablaGeneralFila2Derecha_Paint;
            // 
            // labelContadorRespuestasCorrectas
            // 
            labelContadorRespuestasCorrectas.Content = "Correctas:\\ 0";
            labelContadorRespuestasCorrectas.Dock = DockStyle.Fill;
            labelContadorRespuestasCorrectas.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelContadorRespuestasCorrectas.HorizontalAlignment = StringAlignment.Center;
            labelContadorRespuestasCorrectas.Location = new Point(4, 53);
            labelContadorRespuestasCorrectas.Margin = new Padding(4, 3, 4, 3);
            labelContadorRespuestasCorrectas.Name = "labelContadorRespuestasCorrectas";
            labelContadorRespuestasCorrectas.Size = new Size(182, 120);
            labelContadorRespuestasCorrectas.TabIndex = 1;
            labelContadorRespuestasCorrectas.VerticalAlignment = StringAlignment.Center;
            // 
            // btnSaltarPregunta
            // 
            btnSaltarPregunta.BackColor = SystemColors.Control;
            btnSaltarPregunta.CheckButton = false;
            btnSaltarPregunta.Checked = false;
            btnSaltarPregunta.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnSaltarPregunta.CheckedForeColor = Color.White;
            btnSaltarPregunta.CheckedImageTint = Color.White;
            btnSaltarPregunta.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnSaltarPregunta.Content = "Saltar";
            btnSaltarPregunta.DialogResult = DialogResult.None;
            btnSaltarPregunta.Dock = DockStyle.Fill;
            btnSaltarPregunta.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaltarPregunta.ForeColor = Color.White;
            btnSaltarPregunta.HoverBackground = Color.FromArgb(200, 153, 209, 219);
            btnSaltarPregunta.HoverForeColor = Color.White;
            btnSaltarPregunta.HoverImageTint = Color.White;
            btnSaltarPregunta.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnSaltarPregunta.Image = null;
            btnSaltarPregunta.ImageAutoCenter = true;
            btnSaltarPregunta.ImageExpand = new Point(0, 0);
            btnSaltarPregunta.ImageOffset = new Point(0, 0);
            btnSaltarPregunta.Location = new Point(3, 3);
            btnSaltarPregunta.Name = "btnSaltarPregunta";
            btnSaltarPregunta.NormalBackground = Color.FromArgb(153, 209, 219);
            btnSaltarPregunta.NormalForeColor = Color.White;
            btnSaltarPregunta.NormalImageTint = Color.White;
            btnSaltarPregunta.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnSaltarPregunta.OutlineThickness = 1F;
            btnSaltarPregunta.PressedBackground = Color.WhiteSmoke;
            btnSaltarPregunta.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnSaltarPregunta.PressedImageTint = Color.White;
            btnSaltarPregunta.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnSaltarPregunta.Rounding = new Padding(8);
            btnSaltarPregunta.Size = new Size(184, 44);
            btnSaltarPregunta.TabIndex = 0;
            btnSaltarPregunta.TextAlignment = StringAlignment.Center;
            btnSaltarPregunta.TextOffset = new Point(0, 0);
            btnSaltarPregunta.Click += SaltarPregunta_Click;
            // 
            // tablaGeneralFila2Izquierda
            // 
            tablaGeneralFila2Izquierda.ColumnCount = 1;
            tablaGeneralFila2Izquierda.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaGeneralFila2Izquierda.Controls.Add(labelTiempo, 0, 1);
            tablaGeneralFila2Izquierda.Dock = DockStyle.Fill;
            tablaGeneralFila2Izquierda.Location = new Point(3, 3);
            tablaGeneralFila2Izquierda.Name = "tablaGeneralFila2Izquierda";
            tablaGeneralFila2Izquierda.RowCount = 3;
            tablaGeneralFila2Izquierda.RowStyles.Add(new RowStyle(SizeType.Percent, 28.6667347F));
            tablaGeneralFila2Izquierda.RowStyles.Add(new RowStyle(SizeType.Percent, 71.33326F));
            tablaGeneralFila2Izquierda.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tablaGeneralFila2Izquierda.Size = new Size(217, 258);
            tablaGeneralFila2Izquierda.TabIndex = 1;
            // 
            // labelTiempo
            // 
            labelTiempo.Content = "Tiempo";
            labelTiempo.Dock = DockStyle.Fill;
            labelTiempo.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTiempo.HorizontalAlignment = StringAlignment.Center;
            labelTiempo.Location = new Point(4, 53);
            labelTiempo.Margin = new Padding(4, 3, 4, 3);
            labelTiempo.Name = "labelTiempo";
            labelTiempo.Size = new Size(209, 120);
            labelTiempo.TabIndex = 0;
            labelTiempo.VerticalAlignment = StringAlignment.Center;
            // 
            // temporizadorPreguntas
            // 
            temporizadorPreguntas.Interval = 1000;
            temporizadorPreguntas.Tick += ManejarTickTemporizador;
            // 
            // fmQuiz2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 553);
            Controls.Add(tablaGeneral);
            Name = "fmQuiz2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fmQuiz2";
            tablaGeneral.ResumeLayout(false);
            tablaOpcionesMultiples.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tablaOpcion1.ResumeLayout(false);
            tablaFila2General.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)imgPregunta).EndInit();
            tablaGeneralFila2Derecha.ResumeLayout(false);
            tablaGeneralFila2Izquierda.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tablaGeneral;
        private TableLayoutPanel tablaOpcionesMultiples;
        private CuoreUI.Controls.cuiLabel labelPregunta;
        private TableLayoutPanel tablaFila2General;
        private TableLayoutPanel tablaGeneralFila2Derecha;
        private TableLayoutPanel tablaGeneralFila2Izquierda;
        private PictureBox imgPregunta;
        private CuoreUI.Controls.cuiButton btnSaltarPregunta;
        private CuoreUI.Controls.cuiLabel labelTiempo;
        private CuoreUI.Controls.cuiLabel labelContadorRespuestasCorrectas;
        private TableLayoutPanel tablaOpcion1;
        private TableLayoutPanel tableLayoutPanel3;
        private CuoreUI.Controls.cuiButton btn4;
        private TableLayoutPanel tableLayoutPanel2;
        private CuoreUI.Controls.cuiButton btn3;
        private TableLayoutPanel tableLayoutPanel1;
        private CuoreUI.Controls.cuiButton btn2;
        private System.Windows.Forms.Timer temporizadorPreguntas;
        private CuoreUI.Controls.cuiButton btn1;
    }
}

