using AlberSoft.alojamientoEInventario;

#region Notas
// Nota: FormClosing viene por defecto en Windows Forms
// (espacio de nombres System.Windows.Forms.Control, clase Control)

// Nota: FormClosing es un evento que se dispara cuando el formulario se está cerrando

// Nota: Al escribir FormClosing dentro de esta clase parcial llamada fmenu
// decimos que el control es el formulario actual (fmMenu)

// Nota: Con += estamos añadiendo la función/método cerrarApp al evento FormClosing
// De este modo, cuando el formulario se cierre, se ejecutará cerrarApp

// Idea: FormClosing es equivalente a this.FormClosing

// Idea: FormClosing += (s, e) => Application.Exit(); es equivalente

#endregion

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
        private ContextMenuStrip? menuFlotante3;
        private ContextMenuStrip? menuFlotante4;

        #region Creamos una función/método para cerrar toda la aplicación
        private void cerrarApp(object? sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        // Inicialización principal
        public fmMenu()
        {
            // Carga los controles creados por el diseñador y prepara la ventana
            InitializeComponent();

            // Mostrar el nombre del usuario en la etiqueta "bienvenida"
            string usuario = variablesGlobales.usuario1;
            bienvenida.Content = "¡Bienvenido " + usuario + "!";

            ConfigurarContenido();

            FormClosing += cerrarApp;
        }

        #region ConfigurarContenido: asegura que existe el panel donde mostraremos los formularios
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

            #region Crear panelContenido y añadirlo oculto en la zona derecha (explicación simple para estudiantes)
            // Explicación simple:
            // - Creamos `panelContenido` y lo colocamos en el TableLayoutPanel derecho si existe.
            // - Lo dejamos oculto (Visible = false) al inicio para que el `logo` y otros controles del diseñador se vean.
            if (Controls["tableroALaDerechaDePanel1"] is TableLayoutPanel rightLayout)
            {
                rightLayout.Controls.Add(panelContenido, 0, 0);
                try { rightLayout.SetRowSpan(panelContenido, 1); } catch { }
                panelContenido.Dock = DockStyle.Fill;
                panelContenido.Visible = false; // oculto hasta abrir un child
            }
            else
            {
                Controls.Add(panelContenido);
                panelContenido.Dock = DockStyle.Fill;
                panelContenido.Visible = false;
            }
            #endregion

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

                // Si panelContenido está directamente en Controls habría que ajustar z-order,
                // pero ahora preferimos colocarlo dentro de `tableroALaDerechaDePanel1`.
                // Mantener esta operación por compatibilidad si no existe el layout derecho.
                try { Controls.SetChildIndex(panelContenido, 0); } catch { }
            }
            catch
            {
                // Si ocurre cualquier excepción durante la reordenación la ignoramos porque no es crítico:
                // el programa puede seguir funcionando aunque la reordenación falle en tiempo de ejecución.
            }
            #endregion
        }
        #endregion

        #region Helper: intenta cargar la primera imagen existente entre varios nombres de recurso
        private System.Drawing.Image? LoadResourceImage(params string[] names)
        {
            foreach (var name in names.Where(n => !string.IsNullOrWhiteSpace(n)))
            {
                try
                {
                    var obj = Properties.Resources.ResourceManager.GetObject(name!);
                    if (obj is System.Drawing.Image img) return img;
                }
                catch { }
            }

            return null;
        }
        #endregion

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

            var leftPanel = this.Controls.Find("panel1", true).FirstOrDefault() as Control;
            if (leftPanel != null)
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
                    // Poner el panelContenido al fondo para que el panel lateral y otros controles queden encima.
                    try { this.Controls.SetChildIndex(panelContenido, 0); } catch { }

                    // Traer al frente los controles que deben quedar visibles (panel lateral, logo, bienvenida)
                    try { leftPanel.BringToFront(); } catch { }
                    var logoCtrl = this.Controls.Find("logo", true).FirstOrDefault() as Control;
                    if (logoCtrl != null) try { logoCtrl.BringToFront(); } catch { }
                    var bienvenidaCtrl = this.Controls.Find("bienvenida", true).FirstOrDefault() as Control;
                    if (bienvenidaCtrl != null) try { bienvenidaCtrl.BringToFront(); } catch { }
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

            #region No ocultar el contenido del diseñador inmediatamente
            // Para estudiantes: quitar estas líneas evita que el `logo` y `bienvenida` desaparezcan
            // antes de que el formulario hijo esté correctamente mostrado. Si lo quieres ocultar,
            // hazlo solamente después de verificar que el child se creó sin errores.
            // try { if (logo != null) logo.Visible = false; } catch { }
            // try { if (bienvenida != null) bienvenida.Visible = false; } catch { }
            #endregion

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

            #region Insertar formulario embebido (no eliminar tableLayoutPanel)
            // Explicación para estudiantes:
            // - Queremos mostrar un formulario dentro de `panelContenido`.
            // - No borramos todos los controles del panel porque eso eliminaba tus TableLayoutPanel.
            // - Solo quitamos otros formularios embebidos antiguos (si había) y añadimos el nuevo.
            nuevo.TopLevel = false; // indicar que no es una ventana independiente
            nuevo.FormBorderStyle = FormBorderStyle.None; // quitar bordes para que parezca parte del formulario padre
            nuevo.Dock = DockStyle.Fill; // que ocupe todo el espacio del panel

            if (panelContenido != null)
            {
                // Buscar y eliminar solo controles que sean formularios (para no tocar layouts fijos)
                foreach (var f in panelContenido.Controls.OfType<Form>().ToArray())
                {
                    try
                    {
                        panelContenido.Controls.Remove(f);
                        if (!f.IsDisposed) f.Dispose();
                    }
                    catch { }
                }

                // Si el panel no está colocado aún en el formulario, añadirlo ahora
                if (panelContenido.Parent == null)
                {
                    if (this.Controls["tableroALaDerechaDePanel1"] is TableLayoutPanel right)
                    {
                        right.Controls.Add(panelContenido, 0, 0);
                        try { right.SetRowSpan(panelContenido, 2); } catch { }
                        panelContenido.Dock = DockStyle.Fill;
                    }
                    else
                    {
                        Controls.Add(panelContenido);
                        panelContenido.Dock = DockStyle.Fill;
                    }
                }

                // Añadir el formulario nuevo y asegurar visibilidad
                panelContenido.Controls.Add(nuevo);
                panelContenido.Visible = true;
                // Evitar traer el panelContenido al frente para no tapar el panel lateral.
                // En su lugar traemos al frente los controles que deben permanecer visibles.
                try {
                    var left = this.Controls.Find("panel1", true).FirstOrDefault() as Control;
                    if (left != null) left.BringToFront();
                    var logoCtrl = this.Controls.Find("logo", true).FirstOrDefault() as Control;
                    if (logoCtrl != null) logoCtrl.BringToFront();
                    var bienvenidaCtrl = this.Controls.Find("bienvenida", true).FirstOrDefault() as Control;
                    if (bienvenidaCtrl != null) bienvenidaCtrl.BringToFront();
                } catch { }
            }

            formularioActual = nuevo; // guardar referencia del formulario activo
            nuevo.BringToFront();
            nuevo.Show(); // hacerlo visible
            #endregion

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

            #region Nombres de recursos esperados en Properties.Resources para los iconos del menú 1
            // Añade estas imágenes en Project > Properties > Resources y usa exactamente los nombres.
            string[] resourceNames1 = {
                "alojamiento_icon1",
                "asignaciónDeCamas_icon1",
                "inventarioDeRopa_icon1",
                "inventarioDeComida_icon1"
            };
            #endregion

            #region for para crear cada item del menú con su etiqueta e icono
            for (int i = 0; i < labels1.Length; i++)
            {
                var item = new ToolStripMenuItem(labels1[i]);

                    try
                    {
                        var resName = resourceNames1.Length > i ? resourceNames1[i] : string.Empty; // antes era null
                        var img = LoadResourceImage(resName);
                        if (img != null)
                        {
                            item.Image = img;
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

            #region Nombres de recursos esperados en Properties.Resources para los iconos del menú 2
            // Añade estas imágenes en Project > Properties > Resources y usa exactamente los nombres.
            // Si ya tienes un recurso llamado "capacitacionesIlustrativas_icon" en Resources.resx
            // lo usamos como fallback para todos los items.
            string[] resourceNames2 = {
                "capacitacionesIcon1",
                "capacitacionesIcon2",
                "capacitacionesIcon3",
                "capacitacionesIcon4"
            };
            #endregion

            #region for para crear cada item del menú con su etiqueta e icono
            for (int i = 0; i < labels2.Length; i++)
            {
                var item = new ToolStripMenuItem(labels2[i]);

                    try
                    {
                        var resName = resourceNames2.Length > i ? resourceNames2[i] : string.Empty; // antes era null
                        var img = LoadResourceImage(resName);
                        if (img != null)
                        {
                            item.Image = img;
                            item.ImageScaling = ToolStripItemImageScaling.SizeToFit;
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

        #region Crear menú flotante 3
        // ContextMenuStrip es un menú que está en las herramientas de Windows Forms, pero aquí fue programado manualmente para ser mejorado
        private ContextMenuStrip CrearMenuFlotante3()
        {
            // Crear el menú flotante en una variable llamada menu
            var menu3 = new ContextMenuStrip();

            #region Definir propiedades del menú flotante 3
            //  Mostrar margen para las imágenes del menú flotante
            menu3.ShowImageMargin = true;
            // Definir el tamaño de las imágenes del  menú flotante
            // Nota: Es ancho x alto
            menu3.ImageScalingSize = new Size(63, 53);
            // Definir la fuente del  menú flotante
            // Ajustar el tamaño de la fuente a X puntos
            // FontFamily mantiene la familia de la fuente actual que esté usando el menú flotante
            menu3.Font = new Font(menu3.Font.FontFamily, 16F);
            #endregion

            #region Arreglo que contiene las etiquetas para cada item del menú flotante 1
            string[] labels3 = {
                "Taller de reciclaje",
                "Cocina comunitaria",
                "Huerto comunitario"
            };
            #endregion

            #region Nombres de recursos esperados en Properties.Resources para los iconos del menú 1
            // Añade estas imágenes en Project > Properties > Resources y usa exactamente los nombres.
            string[] resourceNames3 = {
                "tallerDeReciclajeIcon1",
                "cocinaComunitariaIcon1",
                "huertoComunitarioIcon1"
            };
            #endregion

            #region for para crear cada item del menú con su etiqueta e icono
            for (int i = 0; i < labels3.Length; i++)
            {
                var item = new ToolStripMenuItem(labels3[i]);

                try
                {
                    var resName = resourceNames3.Length > i ? resourceNames3[i] : string.Empty; // antes era null
                    var img = LoadResourceImage(resName);
                    if (img != null)
                    {
                        item.Image = img;
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
                var label = labels3[i];
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

                menu3.Items.Add(item);
            }

            #endregion

            return menu3;
        }
        #endregion

        #region Creamos un evento para mostrar el menú flotante 3
        private void icon3_MouseClick(object sender, MouseEventArgs e)
        {
            // Ignorar si no es clic izquierdo
            if (e.Button != MouseButtons.Left) return;

            if (sender is not PictureBox pb) return;

            if (menuFlotante3 == null) menuFlotante3 = CrearMenuFlotante3();

            if (menuFlotante3.Visible) menuFlotante3.Close();
            else
            {
                var showPoint = new Point(0, pb.Height);
                menuFlotante3.Show(pb, showPoint);
            }
        }
        #endregion

        #region Crear menú flotante 4
        // ContextMenuStrip es un menú que está en las herramientas de Windows Forms, pero aquí fue programado manualmente para ser mejorado
        private ContextMenuStrip CrearMenuFlotante4()
        {
            var menu4 = new ContextMenuStrip();
            menu4.ShowImageMargin = true;
            menu4.ImageScalingSize = new Size(63, 53);
            menu4.Font = new Font(menu4.Font.FontFamily, 16F);

            string[] labels4 = {
                "Mapa Interactivo",
                "Quiz"
            };

            // Nombres de recursos esperados en Properties.Resources para los iconos del menú 4
            string[] resourceNames4 = {
                "mapaInteractivoIcon1",
                "quizIcon2"
            };

            for (int i = 0; i < labels4.Length; i++)
            {
                var item = new ToolStripMenuItem(labels4[i]);

                try
                {
                    var resName = resourceNames4.Length > i ? resourceNames4[i] : string.Empty; // antes era null
                    var img = LoadResourceImage(resName);
                    if (img != null)
                    {
                        item.Image = img;
                        item.ImageScaling = ToolStripItemImageScaling.SizeToFit;
                    }
                }
                catch { /* ignorar si falta recurso */ }

                var label = labels4[i];
                item.Click += (s, e) =>
                {
                    if (label == "Mapa Interactivo")
                    {
                        //abrirFormularioHijo(new fmMapa());
                    }
                    else
                    {
                        noAsignado_Click(s, e);
                    }
                };

                menu4.Items.Add(item);
            }

            return menu4;
        }
        #endregion

        #region Creamos un evento para mostrar el menú flotante 4
        private void icon4_MouseClick(object sender, MouseEventArgs e)
        {
            // Ignorar si no es clic izquierdo
            if (e.Button != MouseButtons.Left) return;

            if (sender is not PictureBox pb) return;

            if (menuFlotante4 == null) menuFlotante4 = CrearMenuFlotante4();

            if (menuFlotante4.Visible) menuFlotante4.Close();
            else
            {
                var showPoint = new Point(0, pb.Height);
                menuFlotante4.Show(pb, showPoint);
            }
        }
        #endregion

        private void fmMenu_Load(object sender, EventArgs e)
        {

        }

        private void op2_Load(object sender, EventArgs e)
        {

        }

        private void op4_Load(object sender, EventArgs e)
        {

        }
    }
}