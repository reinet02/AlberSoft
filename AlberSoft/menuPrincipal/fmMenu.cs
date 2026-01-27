using AlberSoft.activadesRecreativas;
using AlberSoft.actividadesRecreativas;
using AlberSoft.Alojamiento_e_Inventario;
using AlberSoft.alojamientoEInventario;
using AlberSoft.capacitacionesIlustradas;
using AlberSoft.mapaInteractivo;
using AsignarCamas;
using CrucigramaPt1;

namespace AlberSoft
{
    public partial class fmMenu : Form
    {
        // Ponemos el menu contextual dentro del menu flotante
        // ContextMenuStrip es una clase de Windows Forms para crear un menú contextual (menú flotante). Está en el Cuadro de herramientas
        // ContextMenuStrip? es una variable que contendrá el menú flotante
        private ContextMenuStrip? menuFlotante1;
        private ContextMenuStrip? menuFlotante2;
        private ContextMenuStrip? menuFlotante3;
        private ContextMenuStrip? menuFlotante4;

        // Inicialización principal
        public fmMenu()
        {
            // Carga los controles creados por el diseñador y prepara la ventana
            InitializeComponent();

            // Cuando el formulario se cierre, se cerrará el programa

            // Nota: FormClosing viene por defecto en Windows Forms

            // FormClosing es un evento que se dispara cuando el formulario se está cerrando

            // Nota: FormClosing es equivalente a this.FormClosing

            // Advertencia: esto es necesario para evitar que la aplicación siga corriendo en segundo plano

            FormClosing += (s, e) => Application.Exit();
        }

        #region Función para cargar un formulario dentro de un panel
        // Carga un formulario dentro del panel "panel2"
        private void abrirFormularioHijo(Form frm)
        {
            try
            {
                // Limpiar controles existentes en el panel
                this.panel2.Controls.Clear();

                // Preparar el formulario para mostrarse embebido
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;

                // Añadir y mostrar
                this.panel2.Controls.Add(frm);
                frm.Show();
            }
            catch (Exception)
            {
                // En caso de error, mostrar mensaje simple (se puede mejorar)
                MessageBox.Show("No se pudo cargar el formulario.");
            }
        }
        #endregion

        #region Cargar por defecto un formulario dentro de un panel
        private void fmMenu_Load(object sender, EventArgs e)
        {
            try
            {
                abrirFormularioHijo(new menuPrincipal.fmBienvenida());
            }
            catch { }
        }
        #endregion

        #region Intenta cargar la primera imagen existente entre varios nombres de recursos (iconos de los menus flotantes)
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

        #region Creamos una función para mostrar un mensaje al usuario
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
                "Inventario de Ropa",
                "Inventario de Comida",
                "Asignación de Camas",
                "Crucigrama"
            };
            #endregion

            #region Nombres de recursos esperados en Properties.Resources para los iconos del menú 1
            // Añade estas imágenes en Project > Properties > Resources y usa exactamente los nombres.
            string[] resourceNames1 = {
                "inventarioDeRopa_icon1",
                "inventarioDeComida_icon1",
                "asignaciónDeCamas_icon1",
                "crucigrama_icon1"
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
                        abrirFormularioHijo(new fmInventarioRopa());
                    }
                    else if (label == "Inventario de Comida")
                    {
                        abrirFormularioHijo(new fmInventarioComida());
                    }
                    else if (label == "Asignación de Camas")
                    {
                        abrirFormularioHijo(new fmAsignacionCamas());
                    }
                    else if (label == "Crucigrama")
                    {
                        abrirFormularioHijo(new fmCrucigrama());
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
                "Protocolos en Caso de Desastres Naturales",
                "Juego formativo"
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
                "capacitacionesIcon4",
                "juegoOrdenarImgsIcon5"
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
                    else if (label == "Prevención de Enfermedades Comunes")
                    {
                        // abrirFormularioHijo(new fmEnfermedadesComunes());
                    }
                    else if (label == "Protocolos en Caso de Incendios")
                    {
                        // abrirFormularioHijo(new fmProtocolosIncendios());
                    }
                    else if (label == "Protocolos en Caso de Desastres Naturales")
                    {
                        // abrirFormularioHijo(new fmDesastresNaturales());
                    }
                    else if (label == "Juego formativo")
                    {
                        abrirFormularioHijo(new fmJuegoOrdenarImgs());
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
                "Taller de Reciclaje",
                "Cocina Comunitaria",
                "Huerto Comunitario",
                "Juego de Pares"
            };
            #endregion

            #region Nombres de recursos esperados en Properties.Resources para los iconos del menú 1
            // Añade estas imágenes en Project > Properties > Resources y usa exactamente los nombres.
            string[] resourceNames3 = {
                "tallerDeReciclajeIcon1",
                "cocinaComunitariaIcon1",
                "huertoComunitarioIcon1",
                "juegoDeParesIcon1"
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
                // - Capturamos la etiqueta en la variable `label`.
                // - Asignamos un lambda corto a `item.Click` que abre el formulario
                //   correspondiente o muestra el mensaje "no asignado"
                var label = labels3[i];
                item.Click += (s, e) =>
                {
                    if (label == "Taller de Reciclaje")
                    {
                        abrirFormularioHijo(new fmCocinaComunitaria());
                    }
                    else if (label == "Cocina Comunitaria")
                    {
                        abrirFormularioHijo(new fmCocinaComunitaria());
                    }
                    else if (label == "Huerto Comunitario")
                    {
                        abrirFormularioHijo(new fmCocinaComunitaria());
                    }
                    else if (label == "Juego de Pares")
                    {
                        abrirFormularioHijo(new fmNivelesDificultad());
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
                        abrirFormularioHijo(new fmMapaEcuador());
                    }
                    else if (label == "Quiz")
                    {
                        abrirFormularioHijo(new fmQuiz1());
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

        private void op2_Load(object sender, EventArgs e)
        {

        }

        private void op4_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

