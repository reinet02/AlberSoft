namespace AlberSoft.actividadesRecreativas
{
    partial class fmLogoHuerto
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
            tablaGeneralF2Botones = new TableLayoutPanel();
            regresar = new PictureBox();
            btnReferencias = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbLogoCocina).BeginInit();
            tablaGeneral.SuspendLayout();
            tablaGeneralF2Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)regresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnReferencias).BeginInit();
            SuspendLayout();
            // 
            // pbLogoCocina
            // 
            pbLogoCocina.BackColor = Color.FromArgb(254, 254, 254);
            pbLogoCocina.Dock = DockStyle.Fill;
            pbLogoCocina.Image = Properties.Resources.logoHuertoComunitario;
            pbLogoCocina.Location = new Point(3, 3);
            pbLogoCocina.Name = "pbLogoCocina";
            pbLogoCocina.Size = new Size(974, 628);
            pbLogoCocina.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogoCocina.TabIndex = 0;
            pbLogoCocina.TabStop = false;
            // 
            // tablaGeneral
            // 
            tablaGeneral.BackColor = Color.White;
            tablaGeneral.ColumnCount = 1;
            tablaGeneral.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tablaGeneral.Controls.Add(tablaGeneralF2Botones, 0, 1);
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
            // tablaGeneralF2Botones
            // 
            tablaGeneralF2Botones.BackColor = Color.White;
            tablaGeneralF2Botones.ColumnCount = 3;
            tablaGeneralF2Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.3232536F));
            tablaGeneralF2Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 89.67675F));
            tablaGeneralF2Botones.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
            tablaGeneralF2Botones.Controls.Add(regresar, 2, 0);
            tablaGeneralF2Botones.Controls.Add(btnReferencias, 0, 0);
            tablaGeneralF2Botones.Dock = DockStyle.Fill;
            tablaGeneralF2Botones.Location = new Point(3, 637);
            tablaGeneralF2Botones.Name = "tablaGeneralF2Botones";
            tablaGeneralF2Botones.RowCount = 1;
            tablaGeneralF2Botones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tablaGeneralF2Botones.Size = new Size(974, 65);
            tablaGeneralF2Botones.TabIndex = 2;
            // 
            // regresar
            // 
            regresar.BackColor = Color.Transparent;
            regresar.Dock = DockStyle.Fill;
            regresar.Image = Properties.Resources.regresar;
            regresar.Location = new Point(866, 3);
            regresar.Name = "regresar";
            regresar.Size = new Size(105, 59);
            regresar.SizeMode = PictureBoxSizeMode.Zoom;
            regresar.TabIndex = 10;
            regresar.TabStop = false;
            regresar.Click += regresar_Click;
            // 
            // btnReferencias
            // 
            btnReferencias.Dock = DockStyle.Fill;
            btnReferencias.Image = Properties.Resources.bibliografia;
            btnReferencias.Location = new Point(3, 3);
            btnReferencias.Name = "btnReferencias";
            btnReferencias.Size = new Size(83, 59);
            btnReferencias.SizeMode = PictureBoxSizeMode.Zoom;
            btnReferencias.TabIndex = 11;
            btnReferencias.TabStop = false;
            btnReferencias.Click += btnReferencias_Click;
            // 
            // fmLogoHuerto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(980, 705);
            Controls.Add(tablaGeneral);
            Name = "fmLogoHuerto";
            Text = "fmLogoHuerto";
            ((System.ComponentModel.ISupportInitialize)pbLogoCocina).EndInit();
            tablaGeneral.ResumeLayout(false);
            tablaGeneralF2Botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)regresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnReferencias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbLogoCocina;
        private TableLayoutPanel tablaGeneral;
        private TableLayoutPanel tablaGeneralF2Botones;
        private PictureBox regresar;
        private PictureBox btnReferencias;
    }
}