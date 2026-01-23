namespace AlberSoft.mapaInteractivo
{
    partial class fmQuiz
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
            bntfacil = new Button();
            label1 = new Label();
            bnmedio = new Button();
            bndificil = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(bntfacil, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(bnmedio, 0, 2);
            tableLayoutPanel1.Controls.Add(bndificil, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // bntfacil
            // 
            bntfacil.Dock = DockStyle.Fill;
            bntfacil.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntfacil.Location = new Point(3, 153);
            bntfacil.Name = "bntfacil";
            bntfacil.Size = new Size(794, 94);
            bntfacil.TabIndex = 1;
            bntfacil.Text = "Nivel Facil";
            bntfacil.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(794, 150);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido a Queen Gema";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // bnmedio
            // 
            bnmedio.Dock = DockStyle.Fill;
            bnmedio.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bnmedio.Location = new Point(3, 253);
            bnmedio.Name = "bnmedio";
            bnmedio.Size = new Size(794, 94);
            bnmedio.TabIndex = 3;
            bnmedio.Text = "Nivel Medio";
            bnmedio.UseVisualStyleBackColor = true;
            // 
            // bndificil
            // 
            bndificil.Dock = DockStyle.Fill;
            bndificil.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bndificil.Location = new Point(3, 353);
            bndificil.Name = "bndificil";
            bndificil.Size = new Size(794, 94);
            bndificil.TabIndex = 4;
            bndificil.Text = "Nivel Difícil";
            bndificil.UseVisualStyleBackColor = true;
            // 
            // fmQuiz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "fmQuiz";
            Text = "Quiz";
            Load += fmQuiz_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button bntfacil;
        private Label label1;
        private Button bnmedio;
        private Button bndificil;
    }
}