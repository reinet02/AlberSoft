namespace AlberSoft.capacitacionesIlustradas
{
    partial class fmCorreccionRespuestas
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
            lblResultado = new CuoreUI.Controls.cuiLabel();
            lblTiempoUsado = new CuoreUI.Controls.cuiLabel();
            lblRecord = new CuoreUI.Controls.cuiLabel();
            listViewResultados = new CuoreUI.Controls.cuiPanel();
            lblVidaPerdida = new CuoreUI.Controls.cuiLabel();
            tabControlMain = new TabControl();
            tabPageResumen = new TabPage();
            tabPageDetalles = new TabPage();
            btnSiguiente = new CuoreUI.Controls.cuiButton();
            btnJugarDeNuevo = new CuoreUI.Controls.cuiButton();
            tableLayoutPanelMain = new TableLayoutPanel();
            tableLayoutPanelButtons = new TableLayoutPanel();

            //
            // tableLayoutPanelMain
            //
            tableLayoutPanelMain.SuspendLayout();
            tableLayoutPanelMain.ColumnCount = 1;
            tableLayoutPanelMain.ColumnStyles.Clear();
            tableLayoutPanelMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelMain.RowCount = 5;
            tableLayoutPanelMain.RowStyles.Clear();
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // lblRecord
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // lblTiempoUsado
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // lblResultado
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F)); // listViewResultados (expandible)
            tableLayoutPanelMain.RowStyles.Add(new RowStyle(SizeType.AutoSize)); // buttons
            tableLayoutPanelMain.Dock = DockStyle.Fill;
            tableLayoutPanelMain.Padding = new Padding(8);
            tableLayoutPanelMain.Location = new Point(0, 0);
            tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            tableLayoutPanelMain.Size = new Size(700, 520);
            tableLayoutPanelMain.TabIndex = 0;

            //
            // lblRecord
            //
            lblRecord.Content = "Récord: -";
            lblRecord.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblRecord.HorizontalAlignment = StringAlignment.Center;
            lblRecord.Padding = new Padding(6);
            lblRecord.Dock = DockStyle.Fill;
            lblRecord.Name = "lblRecord";

            // lblVidaPerdida
            lblVidaPerdida.Content = "";
            lblVidaPerdida.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVidaPerdida.HorizontalAlignment = StringAlignment.Center;
            lblVidaPerdida.Padding = new Padding(6);
            lblVidaPerdida.Dock = DockStyle.Top;
            lblVidaPerdida.Name = "lblVidaPerdida";

            //
            // lblTiempoUsado
            //
            lblTiempoUsado.Content = "Tiempo: 0 de 0 segundos";
            lblTiempoUsado.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTiempoUsado.HorizontalAlignment = StringAlignment.Center;
            lblTiempoUsado.Padding = new Padding(6);
            lblTiempoUsado.Dock = DockStyle.Fill;
            lblTiempoUsado.Name = "lblTiempoUsado";

            //
            // lblResultado
            //
            lblResultado.Content = "";
            lblResultado.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblResultado.HorizontalAlignment = StringAlignment.Center;
            lblResultado.Padding = new Padding(6);
            lblResultado.Dock = DockStyle.Fill;
            lblResultado.Name = "lblResultado";

            //
            // listViewResultados (moved to tabPageDetalles)
            //
            listViewResultados.AutoScroll = true;
            listViewResultados.Name = "listViewResultados";
            listViewResultados.OutlineThickness = 1F;
            listViewResultados.PanelColor = Color.White;
            listViewResultados.PanelOutlineColor = Color.FromArgb(64, 128, 128, 128);
            listViewResultados.Rounding = new Padding(8);
            listViewResultados.Dock = DockStyle.Fill;
            listViewResultados.TabIndex = 0;

            //
            // tableLayoutPanelButtons
            //
            tableLayoutPanelButtons.ColumnCount = 2;
            tableLayoutPanelButtons.ColumnStyles.Clear();
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelButtons.RowCount = 1;
            tableLayoutPanelButtons.RowStyles.Clear();
            tableLayoutPanelButtons.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            tableLayoutPanelButtons.Dock = DockStyle.Fill;
            tableLayoutPanelButtons.Padding = new Padding(4);
            tableLayoutPanelButtons.Name = "tableLayoutPanelButtons";
            tableLayoutPanelButtons.TabIndex = 1;

            // tabControlMain
            //
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Name = "tabControlMain";
            tabControlMain.TabIndex = 2;

            // tabPageResumen
            tabPageResumen.Text = "Resumen";
            tabPageResumen.Padding = new Padding(8);
            tabPageResumen.UseVisualStyleBackColor = true;
            tabPageResumen.Controls.Add(lblVidaPerdida);
            tabPageResumen.Controls.Add(lblResultado);
            tabPageResumen.Controls.Add(lblTiempoUsado);
            tabPageResumen.Controls.Add(lblRecord);

            // tabPageDetalles
            tabPageDetalles.Text = "Detalles";
            tabPageDetalles.Padding = new Padding(8);
            tabPageDetalles.UseVisualStyleBackColor = true;
            tabPageDetalles.Controls.Add(listViewResultados);

            tabControlMain.TabPages.Add(tabPageResumen);
            tabControlMain.TabPages.Add(tabPageDetalles);

            //
            // btnSiguiente
            //
            btnSiguiente.CheckButton = false;
            btnSiguiente.Checked = false;
            btnSiguiente.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnSiguiente.CheckedForeColor = Color.White;
            btnSiguiente.CheckedImageTint = Color.White;
            btnSiguiente.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnSiguiente.Content = "Siguiente escenario";
            btnSiguiente.DialogResult = DialogResult.None;
            btnSiguiente.Font = new Font("Segoe UI", 12F);
            btnSiguiente.ForeColor = Color.Black;
            btnSiguiente.HoverBackground = Color.White;
            btnSiguiente.HoverForeColor = Color.Black;
            btnSiguiente.HoverImageTint = Color.White;
            btnSiguiente.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnSiguiente.Image = null;
            btnSiguiente.ImageAutoCenter = true;
            btnSiguiente.ImageExpand = new Point(0, 0);
            btnSiguiente.ImageOffset = new Point(0, 0);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.NormalBackground = Color.White;
            btnSiguiente.NormalForeColor = Color.Black;
            btnSiguiente.NormalImageTint = Color.White;
            btnSiguiente.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnSiguiente.OutlineThickness = 1F;
            btnSiguiente.PressedBackground = Color.WhiteSmoke;
            btnSiguiente.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnSiguiente.PressedImageTint = Color.White;
            btnSiguiente.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnSiguiente.Rounding = new Padding(8);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.TextAlignment = StringAlignment.Center;
            btnSiguiente.TextOffset = new Point(0, 0);
            btnSiguiente.Click += btnSiguiente_Click;

            //
            // btnJugarDeNuevo
            //
            btnJugarDeNuevo.CheckButton = false;
            btnJugarDeNuevo.Checked = false;
            btnJugarDeNuevo.CheckedBackground = Color.FromArgb(255, 106, 0);
            btnJugarDeNuevo.CheckedForeColor = Color.White;
            btnJugarDeNuevo.CheckedImageTint = Color.White;
            btnJugarDeNuevo.CheckedOutline = Color.FromArgb(255, 106, 0);
            btnJugarDeNuevo.Content = "Jugar de nuevo";
            btnJugarDeNuevo.DialogResult = DialogResult.None;
            btnJugarDeNuevo.Font = new Font("Segoe UI", 12F);
            btnJugarDeNuevo.ForeColor = Color.Black;
            btnJugarDeNuevo.HoverBackground = Color.White;
            btnJugarDeNuevo.HoverForeColor = Color.Black;
            btnJugarDeNuevo.HoverImageTint = Color.White;
            btnJugarDeNuevo.HoverOutline = Color.FromArgb(32, 128, 128, 128);
            btnJugarDeNuevo.Image = null;
            btnJugarDeNuevo.ImageAutoCenter = true;
            btnJugarDeNuevo.ImageExpand = new Point(0, 0);
            btnJugarDeNuevo.ImageOffset = new Point(0, 0);
            btnJugarDeNuevo.Name = "btnJugarDeNuevo";
            btnJugarDeNuevo.NormalBackground = Color.White;
            btnJugarDeNuevo.NormalForeColor = Color.Black;
            btnJugarDeNuevo.NormalImageTint = Color.White;
            btnJugarDeNuevo.NormalOutline = Color.FromArgb(64, 128, 128, 128);
            btnJugarDeNuevo.OutlineThickness = 1F;
            btnJugarDeNuevo.PressedBackground = Color.WhiteSmoke;
            btnJugarDeNuevo.PressedForeColor = Color.FromArgb(32, 32, 32);
            btnJugarDeNuevo.PressedImageTint = Color.White;
            btnJugarDeNuevo.PressedOutline = Color.FromArgb(64, 128, 128, 128);
            btnJugarDeNuevo.Rounding = new Padding(8);
            btnJugarDeNuevo.TabIndex = 2;
            btnJugarDeNuevo.TextAlignment = StringAlignment.Center;
            btnJugarDeNuevo.TextOffset = new Point(0, 0);
            btnJugarDeNuevo.Click += btnJugarDeNuevo_Click;

            // add controls into buttons table
            tableLayoutPanelButtons.Controls.Add(btnJugarDeNuevo, 0, 0);
            tableLayoutPanelButtons.Controls.Add(btnSiguiente, 1, 0);
            btnJugarDeNuevo.Dock = DockStyle.Fill;
            btnSiguiente.Dock = DockStyle.Fill;

            // add controls into main table
            tableLayoutPanelMain.Controls.Add(lblRecord, 0, 0);
            tableLayoutPanelMain.Controls.Add(lblTiempoUsado, 0, 1);
            tableLayoutPanelMain.Controls.Add(lblResultado, 0, 2);
            tableLayoutPanelMain.Controls.Add(listViewResultados, 0, 3);
            tableLayoutPanelMain.Controls.Add(tableLayoutPanelButtons, 0, 4);

            //
            // fmCorreccionRespuestas
            //
            ClientSize = new Size(700, 520);
            Controls.Add(tableLayoutPanelMain);
            Font = new Font("Segoe UI", 12F);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fmCorreccionRespuestas";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Corrección de respuestas";

            tableLayoutPanelMain.ResumeLayout(false);
            tableLayoutPanelMain.PerformLayout();
        }

        #endregion

        private CuoreUI.Controls.cuiPanel listViewResultados;
        private CuoreUI.Controls.cuiLabel lblTiempoUsado;
        private CuoreUI.Controls.cuiLabel lblRecord;
        private CuoreUI.Controls.cuiLabel lblResultado;
        private CuoreUI.Controls.cuiButton btnSiguiente;
        private CuoreUI.Controls.cuiButton btnJugarDeNuevo;
        private TableLayoutPanel tableLayoutPanelMain;
        private TableLayoutPanel tableLayoutPanelButtons;
        private CuoreUI.Controls.cuiLabel lblVidaPerdida;
        private TabControl tabControlMain;
        private TabPage tabPageResumen;
        private TabPage tabPageDetalles;
    }
}
