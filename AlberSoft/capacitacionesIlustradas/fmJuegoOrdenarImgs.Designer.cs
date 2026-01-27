using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AlberSoft.capacitacionesIlustradas
{
    partial class fmJuegoOrdenarImgs
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
            this.components = new Container();
            this.cbEscenario = new CuoreUI.Controls.cuiComboBox();
            this.btnMezclar = new Button();
            this.btnComprobar = new Button();
            this.btnReiniciar = new Button();
            this.lblPuntuacion = new Label();
            this.lblMensaje = new Label();
            this.tlpTargets = new TableLayoutPanel();
            this.flpPool = new FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cbEscenario
            // 
            this.cbEscenario.BackgroundColor = Color.FromArgb(255, 255, 255);
            this.cbEscenario.DropDownBackgroundColor = Color.White;
            this.cbEscenario.DropDownForeColor = Color.FromArgb(27, 27, 27);
            this.cbEscenario.ExpandArrowColor = Color.Gray;
            this.cbEscenario.ForeColor = Color.Gray;
            this.cbEscenario.Items = new string[] { "ABCDE" };
            this.cbEscenario.Location = new Point(24, 20);
            this.cbEscenario.Margin = new Padding(4, 3, 4, 3);
            this.cbEscenario.MaxDropDownHeight = 240;
            this.cbEscenario.Name = "cbEscenario";
            this.cbEscenario.NoSelectionText = "Selecciona escenario";
            this.cbEscenario.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            this.cbEscenario.OutlineThickness = 1F;
            this.cbEscenario.Rounding = 8;
            this.cbEscenario.SelectedIndex = 0;
            this.cbEscenario.SelectedItem = "ABCDE";
            this.cbEscenario.Size = new Size(220, 28);
            this.cbEscenario.SortAlphabetically = false;
            this.cbEscenario.TabIndex = 0;
            this.cbEscenario.SelectedIndexChanged += new EventHandler(this.cbEscenario_SelectedIndexChanged);
            // 
            // btnMezclar
            // 
            this.btnMezclar.Location = new Point(260, 18);
            this.btnMezclar.Name = "btnMezclar";
            this.btnMezclar.Size = new Size(90, 28);
            this.btnMezclar.Text = "Mezclar";
            this.btnMezclar.UseVisualStyleBackColor = true;
            this.btnMezclar.Click += new EventHandler(this.btnMezclar_Click);
            // 
            // btnComprobar
            // 
            this.btnComprobar.Location = new Point(360, 18);
            this.btnComprobar.Name = "btnComprobar";
            this.btnComprobar.Size = new Size(100, 28);
            this.btnComprobar.Text = "Comprobar";
            this.btnComprobar.UseVisualStyleBackColor = true;
            this.btnComprobar.Click += new EventHandler(this.btnComprobar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new Point(470, 18);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new Size(90, 28);
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new EventHandler(this.btnReiniciar_Click);
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.Location = new Point(580, 18);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new Size(140, 28);
            this.lblPuntuacion.Text = "Puntuación: 0";
            this.lblPuntuacion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMensaje
            // 
            this.lblMensaje.Location = new Point(24, 56);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new Size(700, 22);
            this.lblMensaje.Text = "Pulsa Mezclar para iniciar el escenario ABCDE.";
            // 
            // tlpTargets
            // 
            this.tlpTargets.Location = new Point(24, 90);
            this.tlpTargets.Name = "tlpTargets";
            this.tlpTargets.Size = new Size(980, 360);
            this.tlpTargets.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            this.tlpTargets.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // flpPool
            // 
            this.flpPool.Location = new Point(24, 470);
            this.flpPool.Name = "flpPool";
            this.flpPool.Size = new Size(980, 180);
            this.flpPool.AutoScroll = true;
            this.flpPool.FlowDirection = FlowDirection.LeftToRight;
            this.flpPool.WrapContents = true;
            this.flpPool.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            // 
            // fmJuegoOrdenarImgs
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(1028, 680);
            this.Controls.Add(this.cbEscenario);
            this.Controls.Add(this.btnMezclar);
            this.Controls.Add(this.btnComprobar);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.tlpTargets);
            this.Controls.Add(this.flpPool);
            this.Name = "fmJuegoOrdenarImgs";
            this.Text = "fmJuegoDeOrdenarImgs";
            this.ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiComboBox cbEscenario;
        private Button btnMezclar;
        private Button btnComprobar;
        private Button btnReiniciar;
        private Label lblPuntuacion;
        private Label lblMensaje;
        private TableLayoutPanel tlpTargets;
        private FlowLayoutPanel flpPool;
    }
}

