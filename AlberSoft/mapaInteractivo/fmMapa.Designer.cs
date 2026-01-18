namespace MapaInterc
{
    partial class fmMapa
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
            webViewmapa = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webViewmapa).BeginInit();
            SuspendLayout();
            // 
            // webViewmapa
            // 
            webViewmapa.AllowExternalDrop = true;
            webViewmapa.CreationProperties = null;
            webViewmapa.DefaultBackgroundColor = Color.White;
            webViewmapa.Dock = DockStyle.Fill;
            webViewmapa.Location = new Point(0, 0);
            webViewmapa.Name = "webViewmapa";
            webViewmapa.Size = new Size(800, 450);
            webViewmapa.TabIndex = 0;
            webViewmapa.ZoomFactor = 1D;
            webViewmapa.Click += webViewmapa_Click;
            // 
            // fmMapa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webViewmapa);
            Name = "fmMapa";
            Text = "Mapa Interactivo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)webViewmapa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewmapa;
    }
}
