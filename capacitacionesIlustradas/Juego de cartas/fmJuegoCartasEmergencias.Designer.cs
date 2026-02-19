namespace AlberSoft.capacitacionesIlustradas
{
    partial class fmJuegoCartasEmergencias
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
            tablaVentana = new TableLayoutPanel();
            tablaGeneral = new TableLayoutPanel();
            tablaBotonesEtc = new TableLayoutPanel();
            lbTiempo = new CuoreUI.Controls.cuiLabel();
            tablaEscenarios = new TableLayoutPanel();
            pbEscenarios = new PictureBox();
            labelEscenario = new CuoreUI.Controls.cuiLabel();
            tablaContieneTableroCartas = new TableLayoutPanel();
            tablaTableroCartas = new TableLayoutPanel();
            panelMano = new Panel();
            tablaVentanaC1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tablaPuntosVida = new TableLayoutPanel();
            pbPuntosVida = new PictureBox();
            lbPuntosVidaTitulo = new CuoreUI.Controls.cuiLabel();
            lbPuntosVidaConteo = new CuoreUI.Controls.cuiLabel();
            tablaInfoCartas = new TableLayoutPanel();
            panelInfoCartas = new CuoreUI.Controls.cuiPanel();
            controlCarta1 = new AlberSoft.capacitacionesIlustradas.Juego_de_cartas.ControlCarta();
            cuiLabel1 = new CuoreUI.Controls.cuiLabel();
            tablaVentanaC3 = new TableLayoutPanel();
            tablaCementerio = new TableLayoutPanel();
            pbCementerio = new PictureBox();
            btnValidar = new CuoreUI.Controls.cuiButton();
            btnVolverMenuInicio = new CuoreUI.Controls.cuiButton();
            labelPuntosPerdidos = new CuoreUI.Controls.cuiLabel();
            labelPuntosPerdidosCarta = new CuoreUI.Controls.cuiLabel();
            tablaMazo = new TableLayoutPanel();
            pbMazo = new PictureBox();
            pictureBox1 = new PictureBox();
            tablaPuntosPerdidos = new TableLayoutPanel();
            btnInstrucciones = new CuoreUI.Controls.cuiButton();
            tablaVentana.SuspendLayout();
            tablaGeneral.SuspendLayout();
            tablaBotonesEtc.SuspendLayout();
            tablaEscenarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEscenarios).BeginInit();
            tablaContieneTableroCartas.SuspendLayout();
            tablaVentanaC1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tablaPuntosVida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPuntosVida).BeginInit();
            tablaInfoCartas.SuspendLayout();
            panelInfoCartas.SuspendLayout();
            tablaVentanaC3.SuspendLayout();
            tablaCementerio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCementerio).BeginInit();
            tablaMazo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMazo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tablaPuntosPerdidos.SuspendLayout();
            SuspendLayout();
            // 
            // tablaVentana
            // 
            tablaVentana.ColumnCount = 3;
            tablaVentana.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.69917F));
            tablaVentana.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.19501F));
            tablaVentana.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaVentana.Controls.Add(tablaGeneral, 1, 0);
            tablaVentana.Controls.Add(tablaVentanaC1, 0, 0);
            tablaVentana.Controls.Add(tablaVentanaC3, 2, 0);
            tablaVentana.Dock = DockStyle.Fill;
            tablaVentana.Location = new Point(0, 0);
            tablaVentana.Name = "tablaVentana";
            tablaVentana.RowCount = 1;
            tablaVentana.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaVentana.Size = new Size(1323, 856);
            tablaVentana.TabIndex = 0;
            // 
            // tablaGeneral
            // 
            tablaGeneral.BackColor = Color.White;
            tablaGeneral.ColumnCount = 1;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaGeneral.Controls.Add(tablaBotonesEtc, 0, 0);
            tablaGeneral.Controls.Add(tablaEscenarios, 0, 2);
            tablaGeneral.Controls.Add(tablaContieneTableroCartas, 0, 3);
            tablaGeneral.Controls.Add(panelMano, 0, 4);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(343, 3);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 5;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 4.54901934F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 6.23529434F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 20.82353F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 37.17647F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 31.5294113F));
            tablaGeneral.Size = new Size(711, 850);
            tablaGeneral.TabIndex = 3;
            tablaGeneral.Paint += tablaGeneral_Paint;
            // 
            // tablaBotonesEtc
            // 
            tablaBotonesEtc.ColumnCount = 3;
            tablaBotonesEtc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tablaBotonesEtc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaBotonesEtc.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tablaBotonesEtc.Controls.Add(lbTiempo, 1, 0);
            tablaBotonesEtc.Dock = DockStyle.Fill;
            tablaBotonesEtc.Location = new Point(3, 3);
            tablaBotonesEtc.Name = "tablaBotonesEtc";
            tablaBotonesEtc.RowCount = 1;
            tablaBotonesEtc.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaBotonesEtc.Size = new Size(705, 32);
            tablaBotonesEtc.TabIndex = 0;
            // 
            // lbTiempo
            // 
            lbTiempo.Content = "Tiempo:\\ 0\\ segundos";
            lbTiempo.Dock = DockStyle.Fill;
            lbTiempo.Font = new Font("Yu Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTiempo.HorizontalAlignment = StringAlignment.Center;
            lbTiempo.Location = new Point(180, 3);
            lbTiempo.Margin = new Padding(4, 3, 4, 3);
            lbTiempo.Name = "lbTiempo";
            lbTiempo.Size = new Size(344, 26);
            lbTiempo.TabIndex = 3;
            lbTiempo.VerticalAlignment = StringAlignment.Center;
            // 
            // tablaEscenarios
            // 
            tablaEscenarios.ColumnCount = 1;
            tablaEscenarios.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaEscenarios.Controls.Add(pbEscenarios, 0, 0);
            tablaEscenarios.Controls.Add(labelEscenario, 0, 1);
            tablaEscenarios.Dock = DockStyle.Fill;
            tablaEscenarios.Location = new Point(3, 93);
            tablaEscenarios.Name = "tablaEscenarios";
            tablaEscenarios.RowCount = 2;
            tablaEscenarios.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            tablaEscenarios.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tablaEscenarios.Size = new Size(705, 170);
            tablaEscenarios.TabIndex = 15;
            // 
            // pbEscenarios
            // 
            pbEscenarios.Dock = DockStyle.Fill;
            pbEscenarios.Image = Properties.Resources.incendio;
            pbEscenarios.Location = new Point(3, 3);
            pbEscenarios.Name = "pbEscenarios";
            pbEscenarios.Size = new Size(699, 121);
            pbEscenarios.SizeMode = PictureBoxSizeMode.Zoom;
            pbEscenarios.TabIndex = 0;
            pbEscenarios.TabStop = false;
            // 
            // labelEscenario
            // 
            labelEscenario.Content = "Escenario:";
            labelEscenario.Dock = DockStyle.Fill;
            labelEscenario.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEscenario.HorizontalAlignment = StringAlignment.Center;
            labelEscenario.Location = new Point(4, 130);
            labelEscenario.Margin = new Padding(4, 3, 4, 3);
            labelEscenario.Name = "labelEscenario";
            labelEscenario.Size = new Size(697, 37);
            labelEscenario.TabIndex = 16;
            labelEscenario.VerticalAlignment = StringAlignment.Center;
            // 
            // tablaContieneTableroCartas
            // 
            tablaContieneTableroCartas.ColumnCount = 3;
            tablaContieneTableroCartas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tablaContieneTableroCartas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tablaContieneTableroCartas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tablaContieneTableroCartas.Controls.Add(tablaTableroCartas, 1, 0);
            tablaContieneTableroCartas.Dock = DockStyle.Fill;
            tablaContieneTableroCartas.Location = new Point(3, 269);
            tablaContieneTableroCartas.Name = "tablaContieneTableroCartas";
            tablaContieneTableroCartas.RowCount = 1;
            tablaContieneTableroCartas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaContieneTableroCartas.Size = new Size(705, 309);
            tablaContieneTableroCartas.TabIndex = 11;
            // 
            // tablaTableroCartas
            // 
            tablaTableroCartas.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tablaTableroCartas.ColumnCount = 5;
            tablaTableroCartas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tablaTableroCartas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tablaTableroCartas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tablaTableroCartas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tablaTableroCartas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 11.1111107F));
            tablaTableroCartas.Dock = DockStyle.Fill;
            tablaTableroCartas.Location = new Point(108, 3);
            tablaTableroCartas.Name = "tablaTableroCartas";
            tablaTableroCartas.RowCount = 2;
            tablaTableroCartas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaTableroCartas.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaTableroCartas.Size = new Size(487, 303);
            tablaTableroCartas.TabIndex = 3;
            // 
            // panelMano
            // 
            panelMano.BackColor = Color.Transparent;
            panelMano.Dock = DockStyle.Fill;
            panelMano.Location = new Point(0, 581);
            panelMano.Margin = new Padding(0);
            panelMano.Name = "panelMano";
            panelMano.Size = new Size(711, 269);
            panelMano.TabIndex = 10;
            // 
            // tablaVentanaC1
            // 
            tablaVentanaC1.ColumnCount = 1;
            tablaVentanaC1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaVentanaC1.Controls.Add(tableLayoutPanel2, 0, 3);
            tablaVentanaC1.Controls.Add(tablaInfoCartas, 0, 1);
            tablaVentanaC1.Controls.Add(cuiLabel1, 0, 0);
            tablaVentanaC1.Dock = DockStyle.Fill;
            tablaVentanaC1.Location = new Point(3, 3);
            tablaVentanaC1.Name = "tablaVentanaC1";
            tablaVentanaC1.RowCount = 4;
            tablaVentanaC1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.352941F));
            tablaVentanaC1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.82353F));
            tablaVentanaC1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.294117F));
            tablaVentanaC1.RowStyles.Add(new RowStyle(SizeType.Percent, 17.4117641F));
            tablaVentanaC1.Size = new Size(334, 850);
            tablaVentanaC1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(tablaPuntosVida, 0, 0);
            tableLayoutPanel2.Controls.Add(lbPuntosVidaConteo, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 704);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 47.6923065F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5384617F));
            tableLayoutPanel2.Size = new Size(328, 143);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // tablaPuntosVida
            // 
            tablaPuntosVida.ColumnCount = 2;
            tablaPuntosVida.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.4968948F));
            tablaPuntosVida.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.5031052F));
            tablaPuntosVida.Controls.Add(pbPuntosVida, 0, 0);
            tablaPuntosVida.Controls.Add(lbPuntosVidaTitulo, 1, 0);
            tablaPuntosVida.Dock = DockStyle.Fill;
            tablaPuntosVida.Location = new Point(3, 3);
            tablaPuntosVida.Name = "tablaPuntosVida";
            tablaPuntosVida.RowCount = 1;
            tablaPuntosVida.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaPuntosVida.Size = new Size(322, 62);
            tablaPuntosVida.TabIndex = 2;
            // 
            // pbPuntosVida
            // 
            pbPuntosVida.Dock = DockStyle.Fill;
            pbPuntosVida.Image = Properties.Resources.puntosVida;
            pbPuntosVida.Location = new Point(3, 3);
            pbPuntosVida.Name = "pbPuntosVida";
            pbPuntosVida.Size = new Size(60, 56);
            pbPuntosVida.SizeMode = PictureBoxSizeMode.Zoom;
            pbPuntosVida.TabIndex = 0;
            pbPuntosVida.TabStop = false;
            // 
            // lbPuntosVidaTitulo
            // 
            lbPuntosVidaTitulo.Content = "Puntos\\ de\\ vida:\\ ";
            lbPuntosVidaTitulo.Dock = DockStyle.Fill;
            lbPuntosVidaTitulo.Font = new Font("Yu Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPuntosVidaTitulo.HorizontalAlignment = StringAlignment.Near;
            lbPuntosVidaTitulo.Location = new Point(70, 3);
            lbPuntosVidaTitulo.Margin = new Padding(4, 3, 4, 3);
            lbPuntosVidaTitulo.Name = "lbPuntosVidaTitulo";
            lbPuntosVidaTitulo.Size = new Size(248, 56);
            lbPuntosVidaTitulo.TabIndex = 0;
            lbPuntosVidaTitulo.VerticalAlignment = StringAlignment.Center;
            // 
            // lbPuntosVidaConteo
            // 
            lbPuntosVidaConteo.Content = "0";
            lbPuntosVidaConteo.Dock = DockStyle.Fill;
            lbPuntosVidaConteo.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPuntosVidaConteo.HorizontalAlignment = StringAlignment.Center;
            lbPuntosVidaConteo.Location = new Point(4, 71);
            lbPuntosVidaConteo.Margin = new Padding(4, 3, 4, 3);
            lbPuntosVidaConteo.Name = "lbPuntosVidaConteo";
            lbPuntosVidaConteo.Size = new Size(320, 51);
            lbPuntosVidaConteo.TabIndex = 1;
            lbPuntosVidaConteo.VerticalAlignment = StringAlignment.Near;
            // 
            // tablaInfoCartas
            // 
            tablaInfoCartas.ColumnCount = 3;
            tablaInfoCartas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tablaInfoCartas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tablaInfoCartas.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tablaInfoCartas.Controls.Add(panelInfoCartas, 1, 0);
            tablaInfoCartas.Location = new Point(3, 57);
            tablaInfoCartas.Name = "tablaInfoCartas";
            tablaInfoCartas.RowCount = 1;
            tablaInfoCartas.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tablaInfoCartas.Size = new Size(328, 392);
            tablaInfoCartas.TabIndex = 9;
            // 
            // panelInfoCartas
            // 
            panelInfoCartas.Controls.Add(controlCarta1);
            panelInfoCartas.Dock = DockStyle.Fill;
            panelInfoCartas.Location = new Point(35, 3);
            panelInfoCartas.Name = "panelInfoCartas";
            panelInfoCartas.OutlineThickness = 1F;
            panelInfoCartas.PanelColor = Color.White;
            panelInfoCartas.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            panelInfoCartas.Rounding = new Padding(8);
            panelInfoCartas.Size = new Size(256, 386);
            panelInfoCartas.TabIndex = 0;
            // 
            // controlCarta1
            // 
            controlCarta1.BackColor = Color.White;
            controlCarta1.BorderStyle = BorderStyle.FixedSingle;
            controlCarta1.Descripcion = "";
            controlCarta1.Dock = DockStyle.Fill;
            controlCarta1.Imagen = null;
            controlCarta1.Location = new Point(0, 0);
            controlCarta1.Name = "controlCarta1";
            controlCarta1.Padding = new Padding(6);
            controlCarta1.Size = new Size(256, 386);
            controlCarta1.TabIndex = 0;
            controlCarta1.Titulo = "";
            // 
            // cuiLabel1
            // 
            cuiLabel1.Content = "Información\\ de\\ la\\ carta:";
            cuiLabel1.Dock = DockStyle.Fill;
            cuiLabel1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuiLabel1.HorizontalAlignment = StringAlignment.Center;
            cuiLabel1.Location = new Point(4, 3);
            cuiLabel1.Margin = new Padding(4, 3, 4, 3);
            cuiLabel1.Name = "cuiLabel1";
            cuiLabel1.Size = new Size(326, 48);
            cuiLabel1.TabIndex = 10;
            cuiLabel1.VerticalAlignment = StringAlignment.Center;
            // 
            // tablaVentanaC3
            // 
            tablaVentanaC3.ColumnCount = 1;
            tablaVentanaC3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaVentanaC3.Controls.Add(btnValidar, 0, 0);
            tablaVentanaC3.Controls.Add(btnVolverMenuInicio, 0, 1);
            tablaVentanaC3.Controls.Add(tablaMazo, 0, 6);
            tablaVentanaC3.Controls.Add(tablaPuntosPerdidos, 0, 4);
            tablaVentanaC3.Controls.Add(tablaCementerio, 0, 3);
            tablaVentanaC3.Controls.Add(btnInstrucciones, 0, 2);
            tablaVentanaC3.Dock = DockStyle.Fill;
            tablaVentanaC3.Location = new Point(1060, 3);
            tablaVentanaC3.Name = "tablaVentanaC3";
            tablaVentanaC3.RowCount = 7;
            tablaVentanaC3.RowStyles.Add(new RowStyle(SizeType.Percent, 3.25426459F));
            tablaVentanaC3.RowStyles.Add(new RowStyle(SizeType.Percent, 3.43505716F));
            tablaVentanaC3.RowStyles.Add(new RowStyle(SizeType.Percent, 3.88235283F));
            tablaVentanaC3.RowStyles.Add(new RowStyle(SizeType.Percent, 32.35294F));
            tablaVentanaC3.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9411764F));
            tablaVentanaC3.RowStyles.Add(new RowStyle(SizeType.Percent, 8.941176F));
            tablaVentanaC3.RowStyles.Add(new RowStyle(SizeType.Percent, 33.7647057F));
            tablaVentanaC3.Size = new Size(260, 850);
            tablaVentanaC3.TabIndex = 5;
            // 
            // tablaCementerio
            // 
            tablaCementerio.ColumnCount = 3;
            tablaCementerio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaCementerio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tablaCementerio.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaCementerio.Controls.Add(pbCementerio, 1, 1);
            tablaCementerio.Dock = DockStyle.Fill;
            tablaCementerio.Location = new Point(3, 91);
            tablaCementerio.Name = "tablaCementerio";
            tablaCementerio.RowCount = 3;
            tablaCementerio.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablaCementerio.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tablaCementerio.RowStyles.Add(new RowStyle(SizeType.Percent, 19.0476189F));
            tablaCementerio.Size = new Size(254, 267);
            tablaCementerio.TabIndex = 16;
            tablaCementerio.Paint += tablaCementerio_Paint;
            // 
            // pbCementerio
            // 
            pbCementerio.Cursor = Cursors.Hand;
            pbCementerio.Dock = DockStyle.Fill;
            pbCementerio.Image = Properties.Resources.cartaCementerio;
            pbCementerio.Location = new Point(53, 42);
            pbCementerio.Name = "pbCementerio";
            pbCementerio.Size = new Size(146, 170);
            pbCementerio.SizeMode = PictureBoxSizeMode.Zoom;
            pbCementerio.TabIndex = 12;
            pbCementerio.TabStop = false;
            // 
            // btnValidar
            // 
            btnValidar.CheckButton = false;
            btnValidar.Checked = false;
            btnValidar.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnValidar.CheckedForeColor = Color.White;
            btnValidar.CheckedImageTint = Color.White;
            btnValidar.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnValidar.Content = "Validar Respuestas";
            btnValidar.DialogResult = DialogResult.None;
            btnValidar.Dock = DockStyle.Fill;
            btnValidar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidar.ForeColor = Color.Black;
            btnValidar.HoverBackground = Color.White;
            btnValidar.HoverForeColor = Color.Black;
            btnValidar.HoverImageTint = Color.White;
            btnValidar.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnValidar.Image = null;
            btnValidar.ImageAutoCenter = true;
            btnValidar.ImageExpand = new Point(0, 0);
            btnValidar.ImageOffset = new Point(0, 0);
            btnValidar.Location = new Point(3, 3);
            btnValidar.Name = "btnValidar";
            btnValidar.NormalBackground = Color.White;
            btnValidar.NormalForeColor = Color.Black;
            btnValidar.NormalImageTint = Color.White;
            btnValidar.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnValidar.OutlineThickness = 1F;
            btnValidar.PressedBackground = Color.WhiteSmoke;
            btnValidar.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnValidar.PressedImageTint = Color.White;
            btnValidar.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnValidar.Rounding = new Padding(8);
            btnValidar.Size = new Size(254, 21);
            btnValidar.TabIndex = 5;
            btnValidar.TextAlignment = StringAlignment.Center;
            btnValidar.TextOffset = new Point(0, 0);
            // 
            // btnVolverMenuInicio
            // 
            btnVolverMenuInicio.CheckButton = false;
            btnVolverMenuInicio.Checked = false;
            btnVolverMenuInicio.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnVolverMenuInicio.CheckedForeColor = Color.White;
            btnVolverMenuInicio.CheckedImageTint = Color.White;
            btnVolverMenuInicio.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnVolverMenuInicio.Content = "Volver al Menú de inicio";
            btnVolverMenuInicio.DialogResult = DialogResult.None;
            btnVolverMenuInicio.Dock = DockStyle.Fill;
            btnVolverMenuInicio.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolverMenuInicio.ForeColor = Color.Black;
            btnVolverMenuInicio.HoverBackground = Color.White;
            btnVolverMenuInicio.HoverForeColor = Color.Black;
            btnVolverMenuInicio.HoverImageTint = Color.White;
            btnVolverMenuInicio.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnVolverMenuInicio.Image = null;
            btnVolverMenuInicio.ImageAutoCenter = true;
            btnVolverMenuInicio.ImageExpand = new Point(0, 0);
            btnVolverMenuInicio.ImageOffset = new Point(0, 0);
            btnVolverMenuInicio.Location = new Point(3, 30);
            btnVolverMenuInicio.Name = "btnVolverMenuInicio";
            btnVolverMenuInicio.NormalBackground = Color.White;
            btnVolverMenuInicio.NormalForeColor = Color.Black;
            btnVolverMenuInicio.NormalImageTint = Color.White;
            btnVolverMenuInicio.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnVolverMenuInicio.OutlineThickness = 1F;
            btnVolverMenuInicio.PressedBackground = Color.WhiteSmoke;
            btnVolverMenuInicio.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnVolverMenuInicio.PressedImageTint = Color.White;
            btnVolverMenuInicio.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnVolverMenuInicio.Rounding = new Padding(8);
            btnVolverMenuInicio.Size = new Size(254, 23);
            btnVolverMenuInicio.TabIndex = 15;
            btnVolverMenuInicio.TextAlignment = StringAlignment.Center;
            btnVolverMenuInicio.TextOffset = new Point(0, 0);
            // 
            // labelPuntosPerdidos
            // 
            labelPuntosPerdidos.Content = "";
            labelPuntosPerdidos.Dock = DockStyle.Fill;
            labelPuntosPerdidos.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPuntosPerdidos.HorizontalAlignment = StringAlignment.Center;
            labelPuntosPerdidos.Location = new Point(4, 3);
            labelPuntosPerdidos.Margin = new Padding(4, 3, 4, 3);
            labelPuntosPerdidos.Name = "labelPuntosPerdidos";
            labelPuntosPerdidos.Size = new Size(246, 34);
            labelPuntosPerdidos.TabIndex = 17;
            labelPuntosPerdidos.VerticalAlignment = StringAlignment.Center;
            labelPuntosPerdidos.Visible = false;
            // 
            // labelPuntosPerdidosCarta
            // 
            labelPuntosPerdidosCarta.Content = "";
            labelPuntosPerdidosCarta.Dock = DockStyle.Fill;
            labelPuntosPerdidosCarta.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelPuntosPerdidosCarta.HorizontalAlignment = StringAlignment.Center;
            labelPuntosPerdidosCarta.Location = new Point(4, 43);
            labelPuntosPerdidosCarta.Margin = new Padding(4, 3, 4, 3);
            labelPuntosPerdidosCarta.Name = "labelPuntosPerdidosCarta";
            labelPuntosPerdidosCarta.Size = new Size(246, 74);
            labelPuntosPerdidosCarta.TabIndex = 18;
            labelPuntosPerdidosCarta.VerticalAlignment = StringAlignment.Near;
            labelPuntosPerdidosCarta.Visible = false;
            // 
            // tablaMazo
            // 
            tablaMazo.ColumnCount = 3;
            tablaMazo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaMazo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tablaMazo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tablaMazo.Controls.Add(pbMazo, 1, 1);
            tablaMazo.Location = new Point(3, 565);
            tablaMazo.Name = "tablaMazo";
            tablaMazo.RowCount = 3;
            tablaMazo.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablaMazo.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tablaMazo.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tablaMazo.Size = new Size(254, 282);
            tablaMazo.TabIndex = 14;
            // 
            // pbMazo
            // 
            pbMazo.Cursor = Cursors.Hand;
            pbMazo.Dock = DockStyle.Fill;
            pbMazo.Image = Properties.Resources.parteTrasera;
            pbMazo.Location = new Point(53, 45);
            pbMazo.Name = "pbMazo";
            pbMazo.Size = new Size(146, 191);
            pbMazo.SizeMode = PictureBoxSizeMode.Zoom;
            pbMazo.TabIndex = 12;
            pbMazo.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(699, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tablaPuntosPerdidos
            // 
            tablaPuntosPerdidos.ColumnCount = 1;
            tablaPuntosPerdidos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tablaPuntosPerdidos.Controls.Add(labelPuntosPerdidos, 0, 0);
            tablaPuntosPerdidos.Controls.Add(labelPuntosPerdidosCarta, 0, 1);
            tablaPuntosPerdidos.Dock = DockStyle.Fill;
            tablaPuntosPerdidos.Location = new Point(3, 364);
            tablaPuntosPerdidos.Name = "tablaPuntosPerdidos";
            tablaPuntosPerdidos.RowCount = 2;
            tablaPuntosPerdidos.RowStyles.Add(new RowStyle(SizeType.Percent, 33.5616455F));
            tablaPuntosPerdidos.RowStyles.Add(new RowStyle(SizeType.Percent, 66.4383545F));
            tablaPuntosPerdidos.Size = new Size(254, 120);
            tablaPuntosPerdidos.TabIndex = 17;
            // 
            // btnInstrucciones
            // 
            btnInstrucciones.CheckButton = false;
            btnInstrucciones.Checked = false;
            btnInstrucciones.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnInstrucciones.CheckedForeColor = Color.White;
            btnInstrucciones.CheckedImageTint = Color.White;
            btnInstrucciones.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnInstrucciones.Content = "Instrucciones";
            btnInstrucciones.DialogResult = DialogResult.None;
            btnInstrucciones.Dock = DockStyle.Fill;
            btnInstrucciones.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInstrucciones.ForeColor = Color.Black;
            btnInstrucciones.HoverBackground = Color.White;
            btnInstrucciones.HoverForeColor = Color.Black;
            btnInstrucciones.HoverImageTint = Color.White;
            btnInstrucciones.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnInstrucciones.Image = null;
            btnInstrucciones.ImageAutoCenter = true;
            btnInstrucciones.ImageExpand = new Point(0, 0);
            btnInstrucciones.ImageOffset = new Point(0, 0);
            btnInstrucciones.Location = new Point(3, 59);
            btnInstrucciones.Name = "btnInstrucciones";
            btnInstrucciones.NormalBackground = Color.White;
            btnInstrucciones.NormalForeColor = Color.Black;
            btnInstrucciones.NormalImageTint = Color.White;
            btnInstrucciones.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnInstrucciones.OutlineThickness = 1F;
            btnInstrucciones.PressedBackground = Color.WhiteSmoke;
            btnInstrucciones.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnInstrucciones.PressedImageTint = Color.White;
            btnInstrucciones.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnInstrucciones.Rounding = new Padding(8);
            btnInstrucciones.Size = new Size(254, 26);
            btnInstrucciones.TabIndex = 18;
            btnInstrucciones.TextAlignment = StringAlignment.Center;
            btnInstrucciones.TextOffset = new Point(0, 0);
            // 
            // fmJuegoCartasEmergencias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1323, 856);
            Controls.Add(tablaVentana);
            Name = "fmJuegoCartasEmergencias";
            Text = "Juego de Cartas";
            Load += fmJuegoCartasEmergencias_Load_1;
            tablaVentana.ResumeLayout(false);
            tablaGeneral.ResumeLayout(false);
            tablaBotonesEtc.ResumeLayout(false);
            tablaEscenarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbEscenarios).EndInit();
            tablaContieneTableroCartas.ResumeLayout(false);
            tablaVentanaC1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tablaPuntosVida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbPuntosVida).EndInit();
            tablaInfoCartas.ResumeLayout(false);
            panelInfoCartas.ResumeLayout(false);
            tablaVentanaC3.ResumeLayout(false);
            tablaCementerio.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbCementerio).EndInit();
            tablaMazo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMazo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tablaPuntosPerdidos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private CuoreUI.Controls.cuiLabel lbNivel;
        private CuoreUI.Controls.cuiComboBox cbNiveles;
        private CuoreUI.Controls.cuiButton btnJugar;
        private TableLayoutPanel tablaVentana;
        private TableLayoutPanel tablaGeneral;
        private TableLayoutPanel tablaBotonesEtc;
        private CuoreUI.Controls.cuiLabel lbTiempo;
        private Panel panelMano;
        private TableLayoutPanel tableLayoutPanel2;
        private CuoreUI.Controls.cuiLabel lbPuntosVidaTitulo;
        private CuoreUI.Controls.cuiLabel lbPuntosVidaConteo;
        private TableLayoutPanel tablaContieneTableroCartas;
        private TableLayoutPanel tablaTableroCartas;
        private TableLayoutPanel tablaEscenarios;
        private PictureBox pbEscenarios;
        private CuoreUI.Controls.cuiButton btnValidar;
        private TableLayoutPanel tablaVentanaC1;
        private TableLayoutPanel tablaMazo;
        private PictureBox pbMazo;
        private TableLayoutPanel tablaInfoCartas;
        private CuoreUI.Controls.cuiPanel panelInfoCartas;
        private Juego_de_cartas.ControlCarta controlCarta1;
        private TableLayoutPanel tablaVentanaC3;
        private TableLayoutPanel tablaPuntosVida;
        private PictureBox pbPuntosVida;
        private CuoreUI.Controls.cuiButton btnVolverMenuInicio;
        private CuoreUI.Controls.cuiLabel cuiLabel1;
        private TableLayoutPanel tablaCementerio;
        private PictureBox pbCementerio;
        private CuoreUI.Controls.cuiLabel labelPuntosPerdidos;
        private CuoreUI.Controls.cuiLabel labelPuntosPerdidosCarta;
        private CuoreUI.Controls.cuiLabel labelEscenario;
        private PictureBox pictureBox1;
        private TableLayoutPanel tablaPuntosPerdidos;
        private CuoreUI.Controls.cuiButton btnInstrucciones;
    }
}