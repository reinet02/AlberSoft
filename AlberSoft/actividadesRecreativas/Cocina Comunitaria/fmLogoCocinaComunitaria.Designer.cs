namespace AlberSoft.actividadesRecreativas
{
    partial class fmLogoCocinaComunitaria
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
            pbLogoCocina = new PictureBox();
            tablaGeneral = new TableLayoutPanel();
            tablaGeneralF5Botones = new TableLayoutPanel();
            btnRegresar = new PictureBox();
            btnReferencias = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogoCocina).BeginInit();
            tablaGeneral.SuspendLayout();
            tablaGeneralF5Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReferencias).BeginInit();
            SuspendLayout();
            // 
            // pbLogoCocina
            // 
            pbLogoCocina.BackColor = Color.FromArgb(254, 254, 254);
            pbLogoCocina.Dock = DockStyle.Fill;
            pbLogoCocina.Image = Properties.Resources.logoCocinaComunitaria;
            pbLogoCocina.Location = new Point(3, 3);
            pbLogoCocina.Name = "pbLogoCocina";
            pbLogoCocina.Size = new Size(974, 628);
            pbLogoCocina.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoCocina.TabIndex = 0;
            pbLogoCocina.TabStop = false;
            // 
            // tablaGeneral
            // 
            tablaGeneral.ColumnCount = 1;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaGeneral.Controls.Add(tablaGeneralF5Botones, 0, 1);
            tablaGeneral.Controls.Add(pbLogoCocina, 0, 0);
            tablaGeneral.Dock = DockStyle.Fill;
            tablaGeneral.Location = new Point(0, 0);
            tablaGeneral.Name = "tablaGeneral";
            tablaGeneral.RowCount = 2;
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tablaGeneral.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tablaGeneral.Size = new Size(980, 705);
            tablaGeneral.TabIndex = 1;
            // 
            // tablaGeneralF5Botones
            // 
            tablaGeneralF5Botones.ColumnCount = 3;
            tablaGeneralF5Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.3232536F));
            tablaGeneralF5Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.67675F));
            tablaGeneralF5Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tablaGeneralF5Botones.Controls.Add(btnRegresar, 2, 0);
            tablaGeneralF5Botones.Controls.Add(btnReferencias, 0, 0);
            tablaGeneralF5Botones.Dock = DockStyle.Fill;
            tablaGeneralF5Botones.Location = new Point(3, 637);
            tablaGeneralF5Botones.Name = "tablaGeneralF5Botones";
            tablaGeneralF5Botones.RowCount = 1;
            tablaGeneralF5Botones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaGeneralF5Botones.Size = new Size(974, 65);
            tablaGeneralF5Botones.TabIndex = 5;
            // 
            // btnRegresar
            // 
            btnRegresar.BackColor = Color.Transparent;
            btnRegresar.Dock = DockStyle.Fill;
            btnRegresar.Image = Properties.Resources.regresar;
            btnRegresar.Location = new Point(866, 3);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(105, 59);
            btnRegresar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRegresar.TabIndex = 10;
            btnRegresar.TabStop = false;
            btnRegresar.Click += regresar_Click;
            // 
            // btnReferencias
            // 
            btnReferencias.Dock = DockStyle.Fill;
            btnReferencias.Location = new Point(3, 3);
            btnReferencias.Name = "btnReferencias";
            btnReferencias.Size = new Size(83, 59);
            btnReferencias.SizeMode = PictureBoxSizeMode.Zoom;
            btnReferencias.TabIndex = 11;
            btnReferencias.TabStop = false;
            // 
            // fmLogoCocinaComunitaria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 705);
            Controls.Add(tablaGeneral);
            Name = "fmLogoCocinaComunitaria";
            Text = "fmLogoCocinaComunitaria";
            ((System.ComponentModel.ISupportInitialize)pbLogoCocina).EndInit();
            tablaGeneral.ResumeLayout(false);
            tablaGeneralF5Botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReferencias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogoCocina;
        private TableLayoutPanel tablaGeneral;
        private TableLayoutPanel tablaGeneralF5Botones;
        private PictureBox btnRegresar;
        private PictureBox btnReferencias;
    }
}