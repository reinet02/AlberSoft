namespace AlberSoft.activadesRecreativas
{
    partial class fmJuegoDeParesCocina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmJuegoDeParesCocina));
            label2 = new CuoreUI.Controls.cuiLabel();
            btnReinicio = new CuoreUI.Controls.cuiButton();
            temporizador = new System.Windows.Forms.Timer(components);
            tableroGeneral = new TableLayoutPanel();
            panel1 = new CuoreUI.Controls.cuiPanel();
            tablero1 = new TableLayoutPanel();
            carta16 = new PictureBox();
            carta15 = new PictureBox();
            carta14 = new PictureBox();
            carta13 = new PictureBox();
            carta12 = new PictureBox();
            carta11 = new PictureBox();
            carta10 = new PictureBox();
            carta9 = new PictureBox();
            carta8 = new PictureBox();
            carta7 = new PictureBox();
            carta6 = new PictureBox();
            carta5 = new PictureBox();
            carta4 = new PictureBox();
            carta3 = new PictureBox();
            carta2 = new PictureBox();
            carta1 = new PictureBox();
            tablero2 = new TableLayoutPanel();
            label1 = new CuoreUI.Controls.cuiLabel();
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            tableroGeneral.SuspendLayout();
            panel1.SuspendLayout();
            tablero1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)carta16).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta15).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta14).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta13).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)carta1).BeginInit();
            tablero2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Content = "Intentos\\ fallidos:";
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Purple;
            label2.HorizontalAlignment = StringAlignment.Near;
            label2.Location = new Point(5, 139);
            label2.Margin = new Padding(5, 4, 5, 4);
            label2.Name = "label2";
            label2.Size = new Size(318, 176);
            label2.TabIndex = 2;
            label2.VerticalAlignment = StringAlignment.Near;
            // 
            // btnReinicio
            // 
            btnReinicio.BackColor = Color.Transparent;
            btnReinicio.CheckButton = false;
            btnReinicio.Checked = false;
            btnReinicio.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnReinicio.CheckedForeColor = Color.White;
            btnReinicio.CheckedImageTint = Color.White;
            btnReinicio.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnReinicio.Content = "Reiniciar";
            btnReinicio.DialogResult = DialogResult.None;
            btnReinicio.Dock = DockStyle.Fill;
            btnReinicio.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReinicio.ForeColor = Color.Indigo;
            btnReinicio.HoverBackground = Color.Plum;
            btnReinicio.HoverForeColor = Color.Black;
            btnReinicio.HoverImageTint = Color.White;
            btnReinicio.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnReinicio.Image = null;
            btnReinicio.ImageAutoCenter = true;
            btnReinicio.ImageExpand = new Point(0, 0);
            btnReinicio.ImageOffset = new Point(0, 0);
            btnReinicio.Location = new Point(3, 323);
            btnReinicio.Margin = new Padding(3, 4, 3, 4);
            btnReinicio.Name = "btnReinicio";
            btnReinicio.NormalBackground = Color.Lavender;
            btnReinicio.NormalForeColor = Color.Indigo;
            btnReinicio.NormalImageTint = Color.White;
            btnReinicio.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnReinicio.OutlineThickness = 1F;
            btnReinicio.PressedBackground = Color.WhiteSmoke;
            btnReinicio.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnReinicio.PressedImageTint = Color.White;
            btnReinicio.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnReinicio.Rounding = new Padding(8);
            btnReinicio.Size = new Size(322, 78);
            btnReinicio.TabIndex = 3;
            btnReinicio.TextAlignment = StringAlignment.Center;
            btnReinicio.TextOffset = new Point(0, 0);
            btnReinicio.Click += btnReinicio_Click;
            // 
            // temporizador
            // 
            temporizador.Interval = 700;
            temporizador.Tick += timer_Cartas;
            // 
            // tableroGeneral
            // 
            tableroGeneral.BackColor = Color.Thistle;
            tableroGeneral.ColumnCount = 2;
            tableroGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableroGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableroGeneral.Controls.Add(panel1, 0, 0);
            tableroGeneral.Controls.Add(tablero2, 1, 0);
            tableroGeneral.Dock = DockStyle.Fill;
            tableroGeneral.Location = new Point(0, 0);
            tableroGeneral.Margin = new Padding(3, 4, 3, 4);
            tableroGeneral.Name = "tableroGeneral";
            tableroGeneral.RowCount = 1;
            tableroGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableroGeneral.Size = new Size(1113, 823);
            tableroGeneral.TabIndex = 4;
            tableroGeneral.Paint += tableroGeneral_Paint;
            // 
            // panel1
            // 
            panel1.Controls.Add(tablero1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.OutlineThickness = 1F;
            panel1.PanelColor = Color.White;
            panel1.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            panel1.Rounding = new Padding(8);
            panel1.Size = new Size(773, 815);
            panel1.TabIndex = 1;
            // 
            // tablero1
            // 
            tablero1.ColumnCount = 4;
            tablero1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tablero1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tablero1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tablero1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tablero1.Controls.Add(carta16, 3, 3);
            tablero1.Controls.Add(carta15, 2, 3);
            tablero1.Controls.Add(carta14, 1, 3);
            tablero1.Controls.Add(carta13, 0, 3);
            tablero1.Controls.Add(carta12, 3, 2);
            tablero1.Controls.Add(carta11, 2, 2);
            tablero1.Controls.Add(carta10, 1, 2);
            tablero1.Controls.Add(carta9, 0, 2);
            tablero1.Controls.Add(carta8, 3, 1);
            tablero1.Controls.Add(carta7, 2, 1);
            tablero1.Controls.Add(carta6, 1, 1);
            tablero1.Controls.Add(carta5, 0, 1);
            tablero1.Controls.Add(carta4, 3, 0);
            tablero1.Controls.Add(carta3, 2, 0);
            tablero1.Controls.Add(carta2, 1, 0);
            tablero1.Controls.Add(carta1, 0, 0);
            tablero1.Dock = DockStyle.Fill;
            tablero1.Location = new Point(0, 0);
            tablero1.Margin = new Padding(3, 4, 3, 4);
            tablero1.Name = "tablero1";
            tablero1.RowCount = 4;
            tablero1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tablero1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tablero1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tablero1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tablero1.Size = new Size(773, 815);
            tablero1.TabIndex = 0;
            // 
            // carta16
            // 
            carta16.Cursor = Cursors.Hand;
            carta16.Dock = DockStyle.Fill;
            carta16.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta16.Location = new Point(582, 613);
            carta16.Margin = new Padding(3, 4, 3, 4);
            carta16.Name = "carta16";
            carta16.Size = new Size(188, 198);
            carta16.SizeMode = PictureBoxSizeMode.Zoom;
            carta16.TabIndex = 15;
            carta16.TabStop = false;
            carta16.Tag = "15";
            carta16.Click += carta_Click;
            // 
            // carta15
            // 
            carta15.Cursor = Cursors.Hand;
            carta15.Dock = DockStyle.Fill;
            carta15.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta15.Location = new Point(389, 613);
            carta15.Margin = new Padding(3, 4, 3, 4);
            carta15.Name = "carta15";
            carta15.Size = new Size(187, 198);
            carta15.SizeMode = PictureBoxSizeMode.Zoom;
            carta15.TabIndex = 14;
            carta15.TabStop = false;
            carta15.Tag = "14";
            carta15.Click += carta_Click;
            // 
            // carta14
            // 
            carta14.Cursor = Cursors.Hand;
            carta14.Dock = DockStyle.Fill;
            carta14.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta14.Location = new Point(196, 613);
            carta14.Margin = new Padding(3, 4, 3, 4);
            carta14.Name = "carta14";
            carta14.Size = new Size(187, 198);
            carta14.SizeMode = PictureBoxSizeMode.Zoom;
            carta14.TabIndex = 13;
            carta14.TabStop = false;
            carta14.Tag = "13";
            carta14.Click += carta_Click;
            // 
            // carta13
            // 
            carta13.Cursor = Cursors.Hand;
            carta13.Dock = DockStyle.Fill;
            carta13.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta13.Location = new Point(3, 613);
            carta13.Margin = new Padding(3, 4, 3, 4);
            carta13.Name = "carta13";
            carta13.Size = new Size(187, 198);
            carta13.SizeMode = PictureBoxSizeMode.Zoom;
            carta13.TabIndex = 12;
            carta13.TabStop = false;
            carta13.Tag = "12";
            carta13.Click += carta_Click;
            // 
            // carta12
            // 
            carta12.Cursor = Cursors.Hand;
            carta12.Dock = DockStyle.Fill;
            carta12.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta12.Location = new Point(582, 410);
            carta12.Margin = new Padding(3, 4, 3, 4);
            carta12.Name = "carta12";
            carta12.Size = new Size(188, 195);
            carta12.SizeMode = PictureBoxSizeMode.Zoom;
            carta12.TabIndex = 11;
            carta12.TabStop = false;
            carta12.Tag = "11";
            carta12.Click += carta_Click;
            // 
            // carta11
            // 
            carta11.Cursor = Cursors.Hand;
            carta11.Dock = DockStyle.Fill;
            carta11.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta11.Location = new Point(389, 410);
            carta11.Margin = new Padding(3, 4, 3, 4);
            carta11.Name = "carta11";
            carta11.Size = new Size(187, 195);
            carta11.SizeMode = PictureBoxSizeMode.Zoom;
            carta11.TabIndex = 10;
            carta11.TabStop = false;
            carta11.Tag = "10";
            carta11.Click += carta_Click;
            // 
            // carta10
            // 
            carta10.Cursor = Cursors.Hand;
            carta10.Dock = DockStyle.Fill;
            carta10.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta10.Location = new Point(196, 410);
            carta10.Margin = new Padding(3, 4, 3, 4);
            carta10.Name = "carta10";
            carta10.Size = new Size(187, 195);
            carta10.SizeMode = PictureBoxSizeMode.Zoom;
            carta10.TabIndex = 9;
            carta10.TabStop = false;
            carta10.Tag = "9";
            carta10.Click += carta_Click;
            // 
            // carta9
            // 
            carta9.Cursor = Cursors.Hand;
            carta9.Dock = DockStyle.Fill;
            carta9.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta9.Location = new Point(3, 410);
            carta9.Margin = new Padding(3, 4, 3, 4);
            carta9.Name = "carta9";
            carta9.Size = new Size(187, 195);
            carta9.SizeMode = PictureBoxSizeMode.Zoom;
            carta9.TabIndex = 8;
            carta9.TabStop = false;
            carta9.Tag = "8";
            carta9.Click += carta_Click;
            // 
            // carta8
            // 
            carta8.Cursor = Cursors.Hand;
            carta8.Dock = DockStyle.Fill;
            carta8.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta8.Location = new Point(582, 207);
            carta8.Margin = new Padding(3, 4, 3, 4);
            carta8.Name = "carta8";
            carta8.Size = new Size(188, 195);
            carta8.SizeMode = PictureBoxSizeMode.Zoom;
            carta8.TabIndex = 7;
            carta8.TabStop = false;
            carta8.Tag = "7";
            carta8.Click += carta_Click;
            // 
            // carta7
            // 
            carta7.Cursor = Cursors.Hand;
            carta7.Dock = DockStyle.Fill;
            carta7.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta7.Location = new Point(389, 207);
            carta7.Margin = new Padding(3, 4, 3, 4);
            carta7.Name = "carta7";
            carta7.Size = new Size(187, 195);
            carta7.SizeMode = PictureBoxSizeMode.Zoom;
            carta7.TabIndex = 6;
            carta7.TabStop = false;
            carta7.Tag = "6";
            carta7.Click += carta_Click;
            // 
            // carta6
            // 
            carta6.Cursor = Cursors.Hand;
            carta6.Dock = DockStyle.Fill;
            carta6.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta6.Location = new Point(196, 207);
            carta6.Margin = new Padding(3, 4, 3, 4);
            carta6.Name = "carta6";
            carta6.Size = new Size(187, 195);
            carta6.SizeMode = PictureBoxSizeMode.Zoom;
            carta6.TabIndex = 5;
            carta6.TabStop = false;
            carta6.Tag = "5";
            carta6.Click += carta_Click;
            // 
            // carta5
            // 
            carta5.Cursor = Cursors.Hand;
            carta5.Dock = DockStyle.Fill;
            carta5.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta5.Location = new Point(3, 207);
            carta5.Margin = new Padding(3, 4, 3, 4);
            carta5.Name = "carta5";
            carta5.Size = new Size(187, 195);
            carta5.SizeMode = PictureBoxSizeMode.Zoom;
            carta5.TabIndex = 4;
            carta5.TabStop = false;
            carta5.Tag = "4";
            carta5.Click += carta_Click;
            // 
            // carta4
            // 
            carta4.Cursor = Cursors.Hand;
            carta4.Dock = DockStyle.Fill;
            carta4.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta4.Location = new Point(582, 4);
            carta4.Margin = new Padding(3, 4, 3, 4);
            carta4.Name = "carta4";
            carta4.Size = new Size(188, 195);
            carta4.SizeMode = PictureBoxSizeMode.Zoom;
            carta4.TabIndex = 3;
            carta4.TabStop = false;
            carta4.Tag = "3";
            carta4.Click += carta_Click;
            // 
            // carta3
            // 
            carta3.Cursor = Cursors.Hand;
            carta3.Dock = DockStyle.Fill;
            carta3.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta3.Location = new Point(389, 4);
            carta3.Margin = new Padding(3, 4, 3, 4);
            carta3.Name = "carta3";
            carta3.Size = new Size(187, 195);
            carta3.SizeMode = PictureBoxSizeMode.Zoom;
            carta3.TabIndex = 2;
            carta3.TabStop = false;
            carta3.Tag = "2";
            carta3.Click += carta_Click;
            // 
            // carta2
            // 
            carta2.Cursor = Cursors.Hand;
            carta2.Dock = DockStyle.Fill;
            carta2.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta2.Location = new Point(196, 4);
            carta2.Margin = new Padding(3, 4, 3, 4);
            carta2.Name = "carta2";
            carta2.Size = new Size(187, 195);
            carta2.SizeMode = PictureBoxSizeMode.Zoom;
            carta2.TabIndex = 1;
            carta2.TabStop = false;
            carta2.Tag = "1";
            carta2.Click += carta_Click;
            // 
            // carta1
            // 
            carta1.Cursor = Cursors.Hand;
            carta1.Dock = DockStyle.Fill;
            carta1.Image = Properties.Resources.parteTraseraDeCartasCocina;
            carta1.Location = new Point(3, 4);
            carta1.Margin = new Padding(3, 4, 3, 4);
            carta1.Name = "carta1";
            carta1.Size = new Size(187, 195);
            carta1.SizeMode = PictureBoxSizeMode.Zoom;
            carta1.TabIndex = 0;
            carta1.TabStop = false;
            carta1.Tag = "0";
            carta1.Click += carta_Click;
            // 
            // tablero2
            // 
            tablero2.ColumnCount = 1;
            tablero2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablero2.Controls.Add(label2, 0, 1);
            tablero2.Controls.Add(btnReinicio, 0, 2);
            tablero2.Controls.Add(label1, 0, 0);
            tablero2.Controls.Add(tableLayoutPanel1, 0, 3);
            tablero2.Dock = DockStyle.Fill;
            tablero2.Location = new Point(782, 4);
            tablero2.Margin = new Padding(3, 4, 3, 4);
            tablero2.Name = "tablero2";
            tablero2.RowCount = 4;
            tablero2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6644421F));
            tablero2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.66151F));
            tablero2.RowStyles.Add(new RowStyle(SizeType.Percent, 10.6607113F));
            tablero2.RowStyles.Add(new RowStyle(SizeType.Percent, 50.01334F));
            tablero2.Size = new Size(328, 815);
            tablero2.TabIndex = 2;
            // 
            // label1
            // 
            label1.Content = "Cocina\\ Comunitaria/Solo\\ tienes\\ 16\\ intentos\\.";
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Purple;
            label1.HorizontalAlignment = StringAlignment.Center;
            label1.Location = new Point(5, 4);
            label1.Margin = new Padding(5, 4, 5, 4);
            label1.Name = "label1";
            label1.Size = new Size(318, 127);
            label1.TabIndex = 4;
            label1.VerticalAlignment = StringAlignment.Near;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 88.81988F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1801243F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 408);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.9901F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.0099F));
            tableLayoutPanel1.Size = new Size(322, 404);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(280, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // fmJuegoDeParesCocina
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 823);
            Controls.Add(tableroGeneral);
            Margin = new Padding(3, 4, 3, 4);
            Name = "fmJuegoDeParesCocina";
            Text = "fmJuegoDeParesCocina";
            Load += fmJuegoDeParesCocina_Load;
            tableroGeneral.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tablero1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)carta16).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta15).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta14).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta13).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta12).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta11).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta10).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta9).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta8).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta7).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta6).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta5).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta4).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta3).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta2).EndInit();
            ((System.ComponentModel.ISupportInitialize)carta1).EndInit();
            tablero2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CuoreUI.Controls.cuiLabel label2;
        private CuoreUI.Controls.cuiButton btnReinicio;
        private System.Windows.Forms.Timer temporizador;
        private TableLayoutPanel tableroGeneral;
        private CuoreUI.Controls.cuiPanel panel1;
        private TableLayoutPanel tablero1;
        private PictureBox carta16;
        private PictureBox carta15;
        private PictureBox carta14;
        private PictureBox carta13;
        private PictureBox carta12;
        private PictureBox carta11;
        private PictureBox carta10;
        private PictureBox carta9;
        private PictureBox carta8;
        private PictureBox carta7;
        private PictureBox carta6;
        private PictureBox carta5;
        private PictureBox carta4;
        private PictureBox carta3;
        private PictureBox carta2;
        private PictureBox carta1;
        private TableLayoutPanel tablero2;
        private CuoreUI.Controls.cuiLabel label1;
        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
    }
}