using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AlberSoft.capacitacionesIlustradas.Juego_de_cartas
{
    [ToolboxItem(true)]
    [ToolboxBitmap(typeof(ControlCarta))]
    public partial class ControlCarta : UserControl
    {
        public ControlCarta()
        {
            InitializeComponent();

            // Evitar que el layout del contenedor fuerce tamaño inesperado
            AutoSize = false;
            SetStyle(ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
        }

        // Proporciones para adaptar el layout al tamaño del contenedor
        private float proporcionAltoTitulo = 0.12f; // 12% del alto para el título por defecto
        private float proporcionAltoImagen = 0.56f; // 56% del alto para la imagen por defecto

        [Category("Distribución"), Description("Porción del alto dedicada al título (0..1).")]
        [DefaultValue(0.12f)]
        public float ProporcionAltoTitulo
        {
            get => proporcionAltoTitulo;
            set
            {
                proporcionAltoTitulo = Math.Max(0f, Math.Min(1f, value));
                ActualizarDistribucion();
            }
        }

        [Category("Distribución"), Description("Porción del alto dedicada a la imagen (0..1).")]
        [DefaultValue(0.56f)]
        public float ProporcionAltoImagen
        {
            get => proporcionAltoImagen;
            set
            {
                proporcionAltoImagen = Math.Max(0f, Math.Min(1f, value));
                ActualizarDistribucion();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            ActualizarDistribucion();
        }

        private void ActualizarDistribucion()
        {
            // mínimos razonables para evitar controles demasiado pequeños
            const int minTitulo = 16;
            const int minImagen = 40;

            if (etiquetaTitulo != null)
            {
                int altoTitulo = Math.Max(minTitulo, (int)Math.Round(Height * ProporcionAltoTitulo));
                etiquetaTitulo.Height = altoTitulo;
                // Ajustar tamaño de fuente del título proporcionalmente al alto del control
                try
                {
                    var fuenteActual = etiquetaTitulo.Font ?? this.Font;
                    // Calcular tamaño base de fuente a partir del alto del propio título.
                    // Usar valores más pequeños para reducir el tamaño de la fuente por defecto.
                    float tamBase = Math.Max(6f, Math.Min(10f, etiquetaTitulo.Height * 0.2f));

                    // Reducir tamaño si el texto no cabe en el ancho disponible
                    string texto = etiquetaTitulo.Text ?? string.Empty;
                    int disponible = Math.Max(8, etiquetaTitulo.ClientSize.Width - etiquetaTitulo.Padding.Horizontal - 4);

                    float tamPrueba = tamBase;
                    Font? fuenteNueva = null;
                    // decrementar en pasos de 0.5 para mejor ajuste
                    while (tamPrueba >= 6f)
                    {
                        using (var fnt = new Font(fuenteActual.FontFamily, tamPrueba, fuenteActual.Style))
                        {
                            var size = TextRenderer.MeasureText(texto, fnt);
                            if (size.Width <= disponible || tamPrueba <= 7f)
                            {
                                fuenteNueva = new Font(fnt.FontFamily, fnt.Size, fnt.Style);
                                break;
                            }
                        }
                        tamPrueba -= 0.5f;
                    }

                    if (fuenteNueva != null && Math.Abs((etiquetaTitulo.Font?.Size ?? 0f) - fuenteNueva.Size) > 0.25f)
                    {
                        etiquetaTitulo.Font = fuenteNueva;
                    }
                    else
                    {
                        fuenteNueva?.Dispose();
                    }
                }
                catch
                {
                    // si algo falla con la fuente, no interrumpir el render
                }
            }

            if (imagenPrincipal != null)
            {
                int altoImagen = Math.Max(minImagen, (int)Math.Round(Height * ProporcionAltoImagen));
                imagenPrincipal.Height = altoImagen;
            }
        }

        // Note: se eliminó la lógica de proporciones. El control utiliza tamaños y docking
        // definidos desde el diseñador. Cualquier ajuste visual debe realizarse en el diseñador.

        // --- Propiedades visibles en el diseñador (existentes) ---
        [Category("Carta"), Description("Título que se muestra en la parte superior de la carta.")]
        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Titulo
        {
            get => etiquetaTitulo?.Text ?? string.Empty;
            set
            {
                if (etiquetaTitulo != null) etiquetaTitulo.Text = value ?? string.Empty;
            }
        }

        // campo para saber si la imagen actual la poseemos y debemos disponerla
        private bool imagenPropia = false;

        [Category("Carta"), Description("Imagen principal de la carta.")]
        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Image Imagen
        {
            get => imagenPrincipal?.Image;
            set
            {
                if (imagenPrincipal == null) return;

                var anterior = imagenPrincipal.Image;
                if (ReferenceEquals(anterior, value)) return;

                // asignar una copia (si value != null) para evitar usar una instancia compartida
                imagenPrincipal.Image = value != null ? new Bitmap(value) : null;

                // marcar que la imagen ahora es propiedad del control (se debe disponer)
                imagenPropia = imagenPrincipal.Image != null;

                // disponer la anterior solo si era nuestra copia
                if (anterior != null && imagenPropia == false)
                {
                    // si la anterior no era propia quizá no debiéramos disponerla;
                    // en este ejemplo suponemos que anterior fue creada/poseída por este control
                    anterior.Dispose();
                }
                else
                {
                    // si anterior fue una copia nuestra, siempre podemos disponerla
                    anterior?.Dispose();
                }
            }
        }

        [Category("Carta"), Description("Descripción o texto de la carta.")]
        [Browsable(true), DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string Descripcion
        {
            get => textoDescripcion?.Text ?? string.Empty;
            set
            {
                if (textoDescripcion != null) textoDescripcion.Text = value ?? string.Empty;
            }
        }

        // añadidas en la modificación
        [Browsable(false)]
        public Carta? Modelo { get; private set; }

        public void VincularModelo(Carta modelo)
        {
            Modelo = modelo;
            Titulo = modelo.Nombre;
            Imagen = modelo.Imagen;
            // Descripcion = modelo.Descripcion; // si existe
        }

        // Permite establecer el color visual de la carta (fondo del control,
        // fondo del título y de la imagen) para aplicar paletas temáticas.
        public void EstablecerColor(Color color)
        {
            try
            {
                this.BackColor = color;
                if (etiquetaTitulo != null) etiquetaTitulo.BackColor = color;
                if (imagenPrincipal != null) imagenPrincipal.BackColor = color;

                // Decidir color de texto: si el color proviene de la paleta y está en o
                // por debajo de "overlay0" usar texto claro. Si no, PaletaCatppuccin
                // hará fallback por luminancia.
                Color colorTexto = PaletaCatppuccin.NecesitaTextoClaro(color) ? Color.White : Color.Black;

                if (etiquetaTitulo != null) etiquetaTitulo.ForeColor = colorTexto;
                if (textoDescripcion != null)
                {
                    textoDescripcion.ForeColor = colorTexto;

                    // Ajustar fondo de la descripción para mantener contraste y legibilidad.
                    if (colorTexto == Color.White)
                    {
                        // fondo más oscuro que el color base
                        int r = Math.Max(0, color.R - 40);
                        int g = Math.Max(0, color.G - 40);
                        int b = Math.Max(0, color.B - 40);
                        textoDescripcion.BackColor = Color.FromArgb(r, g, b);
                    }
                    else
                    {
                        // fondo más claro que el color base
                        int r = Math.Min(255, color.R + 80);
                        int g = Math.Min(255, color.G + 80);
                        int b = Math.Min(255, color.B + 80);
                        textoDescripcion.BackColor = Color.FromArgb(r, g, b);
                    }
                }
            }
            catch { }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                componentes?.Dispose();
                // sólo disponer la imagen si fue creada/poseída por este control
                if (imagenPropia)
                    imagenPrincipal?.Image?.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
