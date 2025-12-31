using AlberSoft.alojamientoEInventario;
using System.Drawing.Drawing2D;

namespace AlberSoft
{
    public partial class fmMenu : Form
    {
        // embebido: significa que algo se muestra dentro de otro igual (por ejemplo: un formulario dentro de otro formulario)
        // Creamos 3 campos: panelContenido, formularioActual y manejadorCierreFormularioActual
        // ?: indica que el campo es referencia anulable (nullable reference), por ejemplo eso indica que panelContenido puede ser null

        // Declara el campo panelContenido (nullable)
        private Panel? panelContenido;

        // Declara el campo formularioActual (nullable)
        // formularioActual: referencia al formulario que ahora está visible dentro del panelContenido
        private Form? formularioActual;

        // Declara el campo manejadorCierreFormularioActual (nullable)
        private FormClosedEventHandler? manejadorCierreFormularioActual;

        // Ponemos el menu contextual dentro del menu flotante
        // ContextMenuStrip es una clase de Windows Forms para crear un menú contextual (menú flotante). Está en el Cuadro de herramientas
        // ContextMenuStrip? es una variable que contendrá el menú flotante
        private ContextMenuStrip? menuFlotante1;
        private ContextMenuStrip? menuFlotante2;

        // Creamos una función/método para cerrar toda la aplicación
        private void cerrarApp(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        // Inicialización principal
        public fmMenu()
        {
            // Carga los controles creados por el diseñador y prepara la ventana
            InitializeComponent();

            // Mostrar el nombre del usuario en la etiqueta "bienvenida"
            string usuario = variablesGlobales.usuario1;
            bienvenida.Content = "¡Bienvenido " + usuario + "!";

            // Cambiar el color de fondo de las PictureBox a transparente
            // Lo hacemos desde el código porque el diseñador no permite hacerlo directamente
            logo.BackColor = Color.Transparent;
            icon1.BackColor = Color.Transparent;
            icon2.BackColor = Color.Transparent;
            icon3.BackColor = Color.Transparent;
            icon4.BackColor = Color.Transparent;

            // Cambiar el color de fondo de los Labels a transparente
            // Lo hacemos desde el código porque el diseñador no permite hacerlo directamente
            op1.BackColor = Color.Transparent;
            op2.BackColor = Color.Transparent;
            op3.BackColor = Color.Transparent;
            op4.BackColor = Color.Transparent;

            ConfigurarContenido();

            // Nota: FormClosing viene por defecto en Windows Forms
            // (espacio de nombres System.Windows.Forms.Control, clase Control)

            // Nota: FormClosing es un evento que se dispara cuando el formulario se está cerrando

            // Nota: Al escribir FormClosing dentro de esta clase parcial llamada fmenu
            // decimos que el control es el formulario actual (fmMenu)

            // Nota: Con += estamos añadiendo la función/método cerrarApp al evento FormClosing
            // De este modo, cuando el formulario se cierre, se ejecutará cerrarApp

            // Idea: FormClosing es equivalente a this.FormClosing

            // Idea: FormClosing += (s, e) => Application.Exit(); es equivalente

            FormClosing += cerrarApp;
        }

        // ConfigurarContenido: asegura que existe el panel donde mostraremos los formularios
        private void ConfigurarContenido()
        {
            // Buscar si ya existe un panel llamado "panelContent".
            if (Controls["panelContent"] is Panel existente)
            {
                // Si ya existe, lo reutilizamos
                // Lo reutilizamos para evitar crear múltiples paneles si ConfigurarContenido se llama varias veces
                panelContenido = existente;
                return;
            }

            // Creamos un panel (control) llamado panelContenido
            // Nota: Panel es una clase de Windows Forms (espacio de nombres System.Windows.Forms)
            panelContenido = new Panel();

            #region Configuramos las propiedades básicas del panel antes creado
            panelContenido.Name = "panelContent";
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.BackColor = SystemColors.ControlLightLight;
            #endregion

            // Nota: La clase Form viene por defecto en Windows Forms
            // (espacio de nombres System.Windows.Forms)

            // Nota: Controls es una propiedad de la clase Form
            // la cual que contiene todos los controles del formulario
            // Al ser escrita dentro de la clase parcial fmMenu
            // Controls se referirá a los controles del formulario fmMenu

            // Nota: .Add agrega un control al formulario fmMenu
            // porque lo escribimos dentro de la clase parcial fmMenu
            // En este caso agregamos el control llamado panelContenido
            Controls.Add(panelContenido);

            #region Hacemos que cada vez que el usuario cambie el tamaño de la ventana se ajuste el panel llamado panelContenido
            // Nota: Resize viene por defecto en Windows Forms
            // (espacio de nombres System.Windows.Forms.Control, clase Control)

            // Nota: Resize es un evento que se dispara cuando cambia el tamaño del control
            // el control en este caso es el formulario actual (fmMenu)

            // Nota: Al escribir Resize dentro de esta clase parcial llamada fmenu
            // decimos que el control es el formulario actual (fmMenu)

            // Idea: Resize es equivalente a this.Resize

            // Nota: Con += estamos añadiendo al evento Resize la función/método AjustarPanel
            // De este modo, cuando el formulario fmMenu cambie de tamaño, se ejecutará AjustarPanel

            // Nota: Lambda (=>) recibe (s, e) porque Resize espera un evento
            // EventHandler (Controlador de eventos)
            // pero dentro de la lambda ignoramos esos parámetros y llamamos a AjustarPanel() (que no toma argumentos)
            Resize += (s, e) => AjustarPanel();
            #endregion

            #region Traer al frente el PictureBox llamado logo y el Label llamado bienvenida para que no queden ocultos por el panel
            try
            {
                // Buscar el control llamado "logo" en la colección Controls
                // Nota: Controls["logo"]` devuelve null si no existe.
                // Nota: El patrón `is Control logoCtrl` prueba el tipo y asigna la referencia a `logoCtrl`.
                // Nota: Si existe, `BringToFront()` coloca ese control sobre los demás en el mismo contenedor.
                if (Controls["logo"] is Control logoCtrl) logoCtrl.BringToFront();

                // Buscar el control llamado "bienvenida" y, si existe, traerlo al frente.
                if (Controls["bienvenida"] is Control bienvenidaCtrl) bienvenidaCtrl.BringToFront();

                // Ajustar índices de los controles para fijar un z-order conocido.
                // Nota: SetChildIndex(control, index) coloca Control en la posición "index" dentro
                // de la colección Controls; 0 es el fondo y los índices mayores están por encima
                // Aquí intentamos asegurar un orden concreto: leftPanel (panel lateral) primero,
                // luego logo, luego bienvenida y finalmente panelContenido al final

                if (Controls["panel1"] is Control leftPanel)
                {
                    try { Controls.SetChildIndex(leftPanel, 0); } catch { /* ignorar si falla */ }
                }

                if (Controls["logo"] is Control logoCtrl2)
                {
                    try { Controls.SetChildIndex(logoCtrl2, 1); } catch { /* ignorar si falla */ }
                }

                if (Controls["bienvenida"] is Control bienvenidaCtrl2)
                {
                    try { Controls.SetChildIndex(bienvenidaCtrl2, 2); } catch { /* ignorar si falla */ }
                }

                // Poner panelContenido al final (encima del resto)
                // Nota: Usamos 'Controls.Count - 1' para
                // colocar el panel en la posición más alta de la colección, garantizando que ocupe
                // el área principal sin quedar debajo de otros controles cuando sea necesario.
                try { Controls.SetChildIndex(panelContenido, this.Controls.Count - 1); } catch { /* ignorar si falla */ }
            }
            catch
            {
                // Si ocurre cualquier excepción durante la reordenación la ignoramos porque no es crítico:
                // el programa puede seguir funcionando aunque la reordenación falle en tiempo de ejecución.
            }
            #endregion
        }

        #region Ajuste de dimensiones
        // AjustarPanel: método sencillo que asegura que el panel ocupa la parte correcta
        private void AjustarPanel()
        {
            // Llamar al método que sitúa el panel a la derecha del panel lateral si existe
            AjustarPanelContenido();
        }

        // Ajusta la posición y tamaño de panelContenido para quedar a la derecha del panel lateral
        private void AjustarPanelContenido()
        {
            if (panelContenido == null)
            {
                return;
            }

            if (this.Controls["panel1"] is Control leftPanel)
            {
                if (leftPanel.Dock != DockStyle.Left)
                {
                    leftPanel.Dock = DockStyle.Left;
                    leftPanel.Width = Math.Max(200, leftPanel.Width);
                }

                panelContenido.Dock = DockStyle.None;
                var x = leftPanel.Left + leftPanel.Width;
                var w = Math.Max(0, this.ClientSize.Width - x);
                panelContenido.Bounds = new Rectangle(x, 0, w, this.ClientSize.Height);
                panelContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                try
                {
                    try { this.Controls.SetChildIndex(leftPanel, 0); } catch { }
                    if (this.Controls["logo"] is Control logoCtrl) try { this.Controls.SetChildIndex(logoCtrl, 1); } catch { }
                    if (this.Controls["bienvenida"] is Control bienvenidaCtrl) try { this.Controls.SetChildIndex(bienvenidaCtrl, 2); } catch { }
                    try { this.Controls.SetChildIndex(panelContenido, this.Controls.Count - 1); } catch { }
                }
                catch { }
            }
            else
            {
                panelContenido.Dock = DockStyle.Fill;
            }
        }
        #endregion

        #region Lógica principal para abrir un child
        // abrirFormularioHijo: muestra un formulario dentro del panelContenido
        private void abrirFormularioHijo(Form nuevo)
        {
            // 1) Si no tenemos panel aún, asegurarnos de crearlo
            if (panelContenido == null)
            {
                ConfigurarContenido();
            }

            // Asegurarnos de ajustar el panel antes de operar
            AjustarPanelContenido();

            // 2) Cerrar con seguridad el formulario que ya estaba abierto (si existe)
            var anterior = formularioActual;
            var manejadorAnterior = manejadorCierreFormularioActual;
            if (anterior != null)
            {
                if (manejadorAnterior != null)
                {
                    try { anterior.FormClosed -= manejadorAnterior; } catch { }
                }

                try
                {
                    anterior.Close();
                    if (!anterior.IsDisposed) anterior.Dispose();
                }
                catch { }

                if (ReferenceEquals(formularioActual, anterior)) formularioActual = null;
                manejadorCierreFormularioActual = null;
            }

            // 3) Ocultar elementos de la pantalla principal (si deseas)
            try { if (logo != null) logo.Visible = false; } catch { }
            try { if (bienvenida != null) bienvenida.Visible = false; } catch { }

            // 4) Crear y registrar un manejador sencillo para cuando el formulario nuevo se cierre
            manejadorCierreFormularioActual = (s, e) =>
            {
                try { if (logo != null) logo.Visible = true; } catch { }
                try { if (bienvenida != null) bienvenida.Visible = true; } catch { }

                if (ReferenceEquals(formularioActual, nuevo)) formularioActual = null;

                try { nuevo.FormClosed -= manejadorCierreFormularioActual!; } catch { }
                manejadorCierreFormularioActual = null;
            };

            nuevo.FormClosed += manejadorCierreFormularioActual!; // registrar

            // 5) Insertar el formulario en el panel (modo embebido)
            formularioActual = nuevo;
            nuevo.TopLevel = false; // importante: decir que no es una ventana independiente
            nuevo.FormBorderStyle = FormBorderStyle.None; // sin borde para que parezca parte de la ventana
            nuevo.Dock = DockStyle.Fill; // ocupar todo el panel

            panelContenido!.Controls.Clear(); // limpiar lo que haya en el panel
            panelContenido.Controls.Add(nuevo); // añadir el formulario como control del panel
            nuevo.Show(); // hacerlo visible

            // 6) Ajustes finales si hace falta
            AjustarPanelContenido();
        }
        #endregion

        #region Creamos un evento para mostrar un mensaje al usuario
        private void noAsignado_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Formulario no asignado");
        }
        #endregion

        #region Crear menú flotante 1
        // ContextMenuStrip es un menú que está en las herramientas de Windows Forms, pero aquí fue programado manualmente para ser mejorado
        private ContextMenuStrip CrearMenuFlotante1()
        {
            // Crear el menú flotante en una variable llamada menu
            var menu1 = new ContextMenuStrip();

            #region Definir propiedades del menú flotante 1
            //  Mostrar margen para las imágenes del menú flotante
            menu1.ShowImageMargin = true;
            // Definir el tamaño de las imágenes del  menú flotante
            // Nota: Es ancho x alto
            menu1.ImageScalingSize = new Size(63, 53);
            // Definir la fuente del  menú flotante
            // Ajustar el tamaño de la fuente a X puntos
            // FontFamily mantiene la familia de la fuente actual que esté usando el menú flotante
            menu1.Font = new Font(menu1.Font.FontFamily, 16F);
            #endregion

            #region Arreglo que contiene las etiquetas para cada item del menú flotante 1
            string[] labels1 = {
                "Alojamiento",
                "Asignación de Camas",
                "Inventario de Ropa",
                "Inventario de Comida"
            };
            #endregion

            #region Arreglo que contiene las rutas de iconos para cada item del menú flotante 1
            string[] iconPaths1 = {
                // rutas absolutas, las rutas relativas no funcionan (ajusta según tu proyecto)
                @"C:\Users\antho\OneDrive - keug\Informática\Programación\C#\Programas en C#\AlberSoft\AlberSoft-3\imgs\alojamientoEInventario\iconos\alojamiento_icon1.png",
                @"C:\Users\antho\OneDrive - keug\Informática\Programación\C#\Programas en C#\AlberSoft\AlberSoft-3\imgs\alojamientoEInventario\iconos\asignaciónDeCamas_icon1.png",
                @"C:\Users\antho\OneDrive - keug\Informática\Programación\C#\Programas en C#\AlberSoft\AlberSoft-3\imgs\alojamientoEInventario\iconos\inventarioDeRopa_icon1.png",
                @"C:\Users\antho\OneDrive - keug\Informática\Programación\C#\Programas en C#\AlberSoft\AlberSoft-3\imgs\alojamientoEInventario\iconos\inventarioDeComida_icon1.png"
            };
            #endregion

            #region for para crear cada item del menú con su etiqueta e icono
            for (int i = 0; i < labels1.Length; i++)
            {
                var item = new ToolStripMenuItem(labels1[i]);

                try
                {
                    var iconPath = iconPaths1.Length > i ? iconPaths1[i] : null;
                    if (!string.IsNullOrWhiteSpace(iconPath) && File.Exists(iconPath))
                    {
                        item.Image = Image.FromFile(iconPath);
                        item.ImageScaling = ToolStripItemImageScaling.SizeToFit;
                    }
                }
                catch { }

                #region Cambios - manejador simple por etiqueta
                // Explicación simple:
                // - Capturamos la etiqueta en la variable `label`.
                // - Asignamos un lambda corto a `item.Click` que abre el formulario
                //   correspondiente o muestra el mensaje "no asignado".
                // Así es fácil de entender y extender para principiantes.
                var label = labels1[i];
                item.Click += (s, e) =>
                {
                    if (label == "Inventario de Ropa")
                    {
                        abrirFormularioHijo(new fmInventarioDeRopa());
                    }
                    else
                    {
                        noAsignado_Click(s, e);
                    }
                };
                #endregion

                menu1.Items.Add(item);
            }

            #endregion

            return menu1;
        }
        #endregion

        #region Manejador común para items del menú flotante 1
        // Manejador que decide qué formulario abrir según el Tag del ToolStripMenuItem
        private void MostrarMenu1Item_Click(object? sender, EventArgs e)
        {
            if (sender is not ToolStripMenuItem item) return;

            var key = (item.Tag as string) ?? string.Empty;

            // Normalizamos la clave para evitar problemas con mayúsculas, espacios o acentos
            var keyNormalized = key.Trim();

            switch (keyNormalized)
            {
                case "Inventario de Ropa":
                    // Abrir el formulario de inventario de ropa
                    abrirFormularioHijo(new fmInventarioDeRopa());
                    break;

                case "Alojamiento":
                    // Si tuvieras un formulario para Alojamiento podrías abrirlo aquí;
                    // por ahora mostramos el mensaje genérico
                    noAsignado_Click(sender, e);
                    break;

                case "Asignación de Camas":
                    noAsignado_Click(sender, e);
                    break;

                case "Inventario de Comida":
                    noAsignado_Click(sender, e);
                    break;

                default:
                    noAsignado_Click(sender, e);
                    break;
            }
        }
        #endregion

        #region Creamos un evento para mostrar el menú flotante 1
        private void icon1_MouseClick(object sender, MouseEventArgs e)
        {
            // Ignorar si no es clic izquierdo
            if (e.Button != MouseButtons.Left) return;

            if (sender is not PictureBox pb) return;

            if (menuFlotante1 == null) menuFlotante1 = CrearMenuFlotante1();

            if (menuFlotante1.Visible) menuFlotante1.Close();
            else
            {
                var showPoint = new Point(0, pb.Height);
                menuFlotante1.Show(pb, showPoint);
            }
        }
        #endregion

        #region Crear menú flotante 2
        // ContextMenuStrip es un menú que está en las herramientas de Windows Forms, pero aquí fue programado manualmente para ser mejorado
        private ContextMenuStrip CrearMenuFlotante2()
        {
            // Crear el menú flotante en una variable llamada menu
            var menu2 = new ContextMenuStrip();

            #region Definir propiedades del menú flotante
            //  Mostrar margen para las imágenes del menú flotante
            menu2.ShowImageMargin = true;
            // Definir el tamaño de las imágenes del  menú flotante
            // Nota: Es ancho x alto
            menu2.ImageScalingSize = new Size(63, 53);
            // Definir la fuente del  menú flotante
            // Ajustar el tamaño de la fuente a X puntos
            // FontFamily mantiene la familia de la fuente actual que esté usando el menú flotante
            menu2.Font = new Font(menu2.Font.FontFamily, 16F);
            #endregion

            #region Arreglo que contiene las etiquetas para cada item del menú flotante
            string[] labels2 = {
                "Primeros Auxilios",
                "Prevención de Enfermedades Comunes",
                "Protocolos en Caso de Incendios",
                "Protocolos en Caso de Desastres Naturales"
            };
            #endregion

            #region Arreglo que contiene las rutas de iconos para cada item del menú flotante
            string[] iconPaths2 = {
                // rutas absolutas, las rutas relativas no funcionan (ajusta según tu proyecto)
                @"C:\Users\antho\OneDrive - keug\Informática\Programación\C#\Programas en C#\AlberSoft\AlberSoft-3\imgs\capacitacionesIlustrativas\iconos\capacitacionesIcon1.png",
                @"C:\Users\antho\OneDrive - keug\Informática\Programación\C#\Programas en C#\AlberSoft\AlberSoft-3\imgs\capacitacionesIlustrativas\iconos\capacitacionesIcon2.png",
                @"C:\Users\antho\OneDrive - keug\Informática\Programación\C#\Programas en C#\AlberSoft\AlberSoft-3\imgs\capacitacionesIlustrativas\iconos\capacitacionesIcon3.png",
                @"C:\Users\antho\OneDrive - keug\Informática\Programación\C#\Programas en C#\AlberSoft\AlberSoft-3\imgs\capacitacionesIlustrativas\iconos\capacitacionesIcon4.png"
            };
            #endregion

            #region for para crear cada item del menú con su etiqueta e icono
            for (int i = 0; i < labels2.Length; i++)
            {
                var item = new ToolStripMenuItem(labels2[i]);

                try
                {
                    var iconPath = iconPaths2.Length > i ? iconPaths2[i] : null;
                    if (!string.IsNullOrWhiteSpace(iconPath) && File.Exists(iconPath))
                    {
                        item.Image = Image.FromFile(iconPath);
                        item.ImageScaling = ToolStripItemImageScaling.SizeToFit; // o no asignes, SizeToFit es el útil
                    }
                }
                catch { }

                #region Cambios - manejador simple por etiqueta
                // Explicación simple:
                // - Capturamos la etiqueta en la variable `label`.
                // - Asignamos un lambda corto a `item.Click` que abre el formulario
                //   correspondiente o muestra el mensaje "no asignado".
                var label = labels2[i];
                item.Click += (s, e) =>
                {
                    if (label == "Primeros Auxilios")
                    {
                        abrirFormularioHijo(new fmPrimerosAuxilios());
                    }
                    else
                    {
                        noAsignado_Click(s, e);
                    }
                };
                #endregion

                menu2.Items.Add(item);
            }

            #endregion

            return menu2;
        }
        #endregion

        #region Creamos un evento para mostrar el menú flotante 2
        private void icon2_MouseClick(object sender, MouseEventArgs e)
        {
            // Ignorar si no es clic izquierdo
            if (e.Button != MouseButtons.Left) return;

            if (sender is not PictureBox pb) return;

            if (menuFlotante2 == null) menuFlotante2 = CrearMenuFlotante2();

            if (menuFlotante2.Visible) menuFlotante2.Close();
            else
            {
                var showPoint = new Point(0, pb.Height);
                menuFlotante2.Show(pb, showPoint);
            }
        }
        #endregion

        #region Bordes redondeados a los botones
        // Método de ejemplo para aplicar bordes redondeados a un control (opcional)
        private void AplicarBordes(Control ctrl, int radio)
        {
            var r = Math.Max(0, radio);
            var rect = new Rectangle(0, 0, ctrl.Width, ctrl.Height);
            using var p = new GraphicsPath();
            p.AddArc(rect.X, rect.Y, r, r, 180, 90);
            p.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            p.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            p.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            p.CloseFigure();
            ctrl.Region = new Region(p);
        }
        #endregion

        #region Manejadores vacíos creador por el Diseñador de Windows Forms
        // Pequeños manejadores vacíos que vienen del diseñador (no tocar a menos que sepas lo que haces)
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void cuiLabel1_Load(object sender, EventArgs e) { }
        #endregion

    }
}