using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MapaInterc
{
    public partial class fmMapa : Form
    {
        // Botón para volver al menú principal
        private Button btnBackMain;

        public fmMapa()
        {
            InitializeComponent();
            // Crear botón "Volver al menú" y añadirlo sobre el WebView
            btnBackMain = new Button();
            btnBackMain.Text = "Volver al menú";
            btnBackMain.Size = new Size(140, 36);
            btnBackMain.Location = new Point(12, 12);
            btnBackMain.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnBackMain.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            btnBackMain.Click += (s, e) => { try { this.Close(); } catch { } };
            // Estilo sutil y elegante: esquinas redondeadas, hover ligero
            btnBackMain.FlatStyle = FlatStyle.Flat;
            btnBackMain.FlatAppearance.BorderSize = 0;
            var baseColor = Color.FromArgb(245, 245, 245);
            btnBackMain.BackColor = baseColor;
            btnBackMain.ForeColor = Color.Black;
            bool hover = false;
            btnBackMain.MouseEnter += (s, e) => { hover = true; btnBackMain.Invalidate(); };
            btnBackMain.MouseLeave += (s, e) => { hover = false; btnBackMain.Invalidate(); };
            btnBackMain.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                var rect = new Rectangle(0, 0, btnBackMain.Width, btnBackMain.Height);
                using (var path = RoundedRect(rect, Math.Max(6, btnBackMain.Height / 4)))
                {
                    var color = hover ? ControlPaint.Light(baseColor) : baseColor;
                    using (var brush = new SolidBrush(color)) g.FillPath(brush, path);
                    using (var pen = new Pen(Color.FromArgb(200, 200, 200))) g.DrawPath(pen, path);
                }
                TextRenderer.DrawText(g, btnBackMain.Text, btnBackMain.Font, rect, btnBackMain.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };
            this.Controls.Add(btnBackMain);
            btnBackMain.BringToFront();
            //webViewmapa.Source = new Uri("https://www.google.com");
            
        }

        private GraphicsPath RoundedRect(Rectangle rect, int radius)
        {
            var path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(rect.Left, rect.Top, d, d, 180, 90);
            path.AddArc(rect.Right - d, rect.Top, d, d, 270, 90);
            path.AddArc(rect.Right - d, rect.Bottom - d, d, d, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void webViewmapa_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ruta = System.IO.Path.Combine(
        Application.StartupPath,
        "mapa.html"
    );
            //MessageBox.Show(ruta);

            webViewmapa.Source = new Uri(ruta);
        }
    }
}
