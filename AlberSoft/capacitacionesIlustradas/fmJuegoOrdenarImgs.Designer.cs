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
            cbEscenario = new CuoreUI.Controls.cuiComboBox();
            cbDificultad = new ComboBox();
            btnMezclar = new Button();
            btnComprobar = new Button();
            btnReiniciar = new Button();
            lblPuntuacion = new Label();
            lblTiempo = new Label();
            lblMensaje = new Label();
            tlpTargets = new TableLayoutPanel();
            flpPool = new FlowLayoutPanel();
            pnlTop = new Panel();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // cbEscenario
            // 
            cbEscenario.BackgroundColor = Color.FromArgb(255, 255, 255);
            cbEscenario.DropDownBackgroundColor = Color.White;
            cbEscenario.DropDownForeColor = Color.FromArgb(27, 27, 27);
            cbEscenario.ExpandArrowColor = Color.Gray;
            cbEscenario.ForeColor = Color.Gray;
            cbEscenario.Items = new string[]
    {
    "ABCDE"
    };
            cbEscenario.Location = new Point(16, 16);
            cbEscenario.Margin = new Padding(4, 3, 4, 3);
            cbEscenario.MaxDropDownHeight = 240;
            cbEscenario.Name = "cbEscenario";
            cbEscenario.NoSelectionText = "Selecciona escenario";
            cbEscenario.OutlineColor = Color.FromArgb(64, 128, 128, 128);
            cbEscenario.OutlineThickness = 1F;
            cbEscenario.Rounding = 8;
            cbEscenario.SelectedIndex = 0;
            cbEscenario.SelectedItem = "ABCDE";
            cbEscenario.Size = new Size(220, 28);
            cbEscenario.SortAlphabetically = false;
            cbEscenario.TabIndex = 0;
            cbEscenario.SelectedIndexChanged += cbEscenario_SelectedIndexChanged;
            // 
            // cbDificultad
            // 
            cbDificultad.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDificultad.Location = new Point(256, 16);
            cbDificultad.Name = "cbDificultad";
            cbDificultad.Size = new Size(132, 28);
            cbDificultad.TabIndex = 1;
            cbDificultad.SelectedIndexChanged += cbDificultad_SelectedIndexChanged;
            // 
            // btnMezclar
            // 
            btnMezclar.Location = new Point(424, 16);
            btnMezclar.Name = "btnMezclar";
            btnMezclar.Size = new Size(120, 40);
            btnMezclar.TabIndex = 2;
            btnMezclar.Text = "Mezclar";
            btnMezclar.UseVisualStyleBackColor = true;
            btnMezclar.Click += btnMezclar_Click;
            // 
            // btnComprobar
            // 
            btnComprobar.Location = new Point(568, 16);
            btnComprobar.Name = "btnComprobar";
            btnComprobar.Size = new Size(144, 40);
            btnComprobar.TabIndex = 3;
            btnComprobar.Text = "Comprobar";
            btnComprobar.UseVisualStyleBackColor = true;
            btnComprobar.Click += btnComprobar_Click;
            // 
            // btnReiniciar
            // 
            btnReiniciar.Location = new Point(736, 16);
            btnReiniciar.Name = "btnReiniciar";
            btnReiniciar.Size = new Size(120, 40);
            btnReiniciar.TabIndex = 4;
            btnReiniciar.Text = "Reiniciar";
            btnReiniciar.UseVisualStyleBackColor = true;
            btnReiniciar.Click += btnReiniciar_Click;
            // 
            // lblPuntuacion
            // 
            lblPuntuacion.AutoSize = true;
            lblPuntuacion.Location = new Point(872, 16);
            lblPuntuacion.Name = "lblPuntuacion";
            lblPuntuacion.Size = new Size(97, 20);
            lblPuntuacion.TabIndex = 5;
            lblPuntuacion.Text = "Puntuación: 0";
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.Location = new Point(880, 56);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(81, 20);
            lblTiempo.TabIndex = 6;
            lblTiempo.Text = "Tiempo: 0s";
            // 
            // lblMensaje
            // 
            lblMensaje.Location = new Point(24, 56);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(100, 23);
            lblMensaje.TabIndex = 1;
            // 
            // tlpTargets
            // 
            tlpTargets.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpTargets.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tlpTargets.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpTargets.Location = new Point(24, 90);
            tlpTargets.Name = "tlpTargets";
            tlpTargets.Size = new Size(980, 360);
            tlpTargets.TabIndex = 0;
            // 
            // flpPool
            // 
            flpPool.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpPool.AutoScroll = true;
            flpPool.Location = new Point(24, 470);
            flpPool.Name = "flpPool";
            flpPool.Size = new Size(980, 180);
            flpPool.TabIndex = 2;
            // 
            // pnlTop
            // 
            pnlTop.BackColor = SystemColors.Control;
            pnlTop.Controls.Add(cbEscenario);
            pnlTop.Controls.Add(lblMensaje);
            pnlTop.Controls.Add(cbDificultad);
            pnlTop.Controls.Add(btnMezclar);
            pnlTop.Controls.Add(btnComprobar);
            pnlTop.Controls.Add(btnReiniciar);
            pnlTop.Controls.Add(lblPuntuacion);
            pnlTop.Controls.Add(lblTiempo);
            pnlTop.Dock = DockStyle.Fill;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Padding = new Padding(6);
            pnlTop.Size = new Size(1028, 680);
            pnlTop.TabIndex = 3;
            // 
            // fmJuegoOrdenarImgs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 680);
            Controls.Add(tlpTargets);
            Controls.Add(flpPool);
            Controls.Add(pnlTop);
            Name = "fmJuegoOrdenarImgs";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Juego - Ordenar Imágenes";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private CuoreUI.Controls.cuiComboBox cbEscenario;
        private ComboBox cbDificultad;
        private Button btnMezclar;
        private Button btnComprobar;
        private Button btnReiniciar;
        private Label lblPuntuacion;
        private Label lblTiempo;
        private Label lblMensaje;
        private TableLayoutPanel tlpTargets;
        private FlowLayoutPanel flpPool;
        private Panel pnlTop;
    }
}

