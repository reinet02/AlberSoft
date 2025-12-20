namespace AlberSoft
{
    partial class FMRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FMRegistro));
            entrada = new TextBox();
            ingresarNombre = new Label();
            pictureBox1 = new PictureBox();
            btnIngresar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // entrada
            // 
            entrada.Location = new Point(225, 310);
            entrada.Name = "entrada";
            entrada.Size = new Size(351, 23);
            entrada.TabIndex = 3;
            // 
            // ingresarNombre
            // 
            ingresarNombre.AutoSize = true;
            ingresarNombre.Font = new Font("Segoe UI", 28F);
            ingresarNombre.Location = new Point(126, 238);
            ingresarNombre.Name = "ingresarNombre";
            ingresarNombre.Size = new Size(596, 51);
            ingresarNombre.TabIndex = 4;
            ingresarNombre.Text = "Ingrese su nombre para continuar:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(298, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(326, 354);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(132, 38);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Agregar nombre";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox1);
            Controls.Add(ingresarNombre);
            Controls.Add(entrada);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox entrada;
        private Label ingresarNombre;
        private PictureBox pictureBox1;
        private Button btnIngresar;
    }
}
