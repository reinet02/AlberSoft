// System.Collections tiene la clase ArrayList que usamos
using System.Collections;

namespace AlberSoft.activadesRecreativas
{
    public partial class fmJuegoDeParesReciclaje : Form
    {
        #region Declaramos variables
        // Número máximo de intentos permitidos
        private const int MaxIntentos = 32;

        // Creamos una listas para gestionar las cartas enumeradas
        private List<int> cartasEnumeradas;
        // Creamos una lista para gestionar las cartas revueltas
        private List<int> cartasRevueltas;

        // Creamos una lista para las cartas seleccionadas temporalmente
        private ArrayList cartasSeleccionadas;

        // Creamos PictureBox temporales para las cartas seleccionadas
        private PictureBox cartaTemp1;
        private PictureBox cartaTemp2;

        // Contador de intentos realizados
        private int intentos = 0;
        // Contador de parejas encontradas
        private int parejasEncontradas = 0;

        // Random compartido para barajar correctamente
        private static readonly Random aleatorio = new Random();
        #endregion

        public fmJuegoDeParesReciclaje()
        {
            InitializeComponent();
        }


        private void timer_Cartas(object sender, EventArgs e)
        {
            // Si existen cartas temporales, las giramos al reverso
            if (cartaTemp1 != null)
                cartaTemp1.Image = Properties.Resources.parteTraseraDeCartasReciclaje;
            if (cartaTemp2 != null)
                cartaTemp2.Image = Properties.Resources.parteTraseraDeCartasReciclaje;

            // Limpiar selección de cartas y cartas temporales para poder seguir jugando
            cartasSeleccionadas?.Clear();
            cartaTemp1 = null;
            cartaTemp2 = null;

            // Detener temporizador
            temporizador.Stop();
            temporizador.Enabled = false;
        }

        private void tableroGeneral_Paint(object sender, PaintEventArgs e)
        {
            // Este evento se deja vacío; el Diseñador lo genera si quieres dibujar manualmente
        }

        private void IniciarJuego()
        {
            // Detener cualquier temporizador en curso
            temporizador.Stop();
            temporizador.Enabled = false;

            // Reiniciar contadores
            intentos = 0;
            parejasEncontradas = 0;
            label2.Content = "Intentos fallidos: 0";

            // Crear lista de parejas duplicadas
            cartasEnumeradas = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                cartasEnumeradas.Add(i);
                cartasEnumeradas.Add(i);
            }

            // Barajar la lista usando aleatorio compartido
            cartasRevueltas = cartasEnumeradas.OrderBy(_ => aleatorio.Next()).ToList();

            int indice = 0;
            // forach recorre todos los controles dentro del tablero1
            foreach (Control c in tablero1.Controls)
            {
                // Si el control dentro del tablero1 es un PictureBox
                // le asignamos la imagen "parteTraseraDeCartasCocina" 
                if (c is PictureBox pictureBox)
                {
                    // Forzamos a tratar la propiedad Tag como un entero
                    pictureBox.Tag = indice++;
                }
            }

            // Limpiar selección temporal
            cartasSeleccionadas = new ArrayList();
            cartaTemp1 = null;
            cartaTemp2 = null;
        }

        private void fmJuegoDeParesReciclaje_Load(object sender, EventArgs e)
        {
            IniciarJuego();
        }

        // Función asignado a cada carta (PictureBox)
        private void carta_Click(object? sender, EventArgs e)
        {
            // Comprobaciones básicas
            if (!(sender is PictureBox pictureBox)) return; // si no es PictureBox, no procesamos clicks
            if (!panel1.Enabled) return; // si el panel está deshabilitado, no procesamos clicks
            if (!pictureBox.Enabled) return; // si la PictureBox (carta) está deshabilitada, no procesamos clicks

            // Inicializar la lista de seleccionadas si es la primera vez
            if (cartasSeleccionadas == null) cartasSeleccionadas = new ArrayList();

            // Evitar seleccionar la misma carta dos veces
            // si ya está en la lista de seleccionadas, no hacer nada
            if (cartasSeleccionadas.Contains(pictureBox)) return;

            // Obtener índice en el tablero desde Tag
            int indice = pictureBox.Tag is int t ? t : 0;
            // si el índice es inválido, no hacer nada
            if (cartasRevueltas == null || indice < 0 || indice >= cartasRevueltas.Count) return;

            // Mostrar la imagen frontal correspondiente al número guardado en cartasRevueltas
            int numero = cartasRevueltas[indice];
            pictureBox.Image = RecuperarImagen(numero);

            // Añadir a la selección actual
            cartasSeleccionadas.Add(pictureBox);

            // Si hay dos cartas seleccionadas, comprobar si coinciden
            if (cartasSeleccionadas.Count == 2)
            {
                var pictureBox1 = (PictureBox)cartasSeleccionadas[0];
                var pictureBox2 = (PictureBox)cartasSeleccionadas[1];

                int i1 = pictureBox1.Tag is int tt1 ? tt1 : 0;
                int i2 = pictureBox2.Tag is int tt2 ? tt2 : 0;
                int n1 = cartasRevueltas[i1];
                int n2 = cartasRevueltas[i2];

                if (n1 == n2)
                {
                    // Coinciden: dejamos las cartas descubiertas y deshabilitadas
                    pictureBox1.Enabled = false;
                    pictureBox2.Enabled = false;
                    cartasSeleccionadas.Clear();
                    parejasEncontradas++;

                    // Si se encuentran todas las parejas, avisar al usuario
                    if (parejasEncontradas >= 8)
                        MessageBox.Show("¡Felicitaciones, has encontrado todas las parejas!");
                }
                else
                {
                    // No coinciden: guardamos temporales para voltearlas cuando suene el temporizador
                    cartaTemp1 = pictureBox1;
                    cartaTemp2 = pictureBox2;

                    // Incrementamos contador de intentos (intentos)
                    intentos++;
                    // Actualizamos la etiqueta de intentos
                    label2.Content = $"Intentos fallidos: {intentos}";

                    // Si llegamos al máximo de intentos, podemos deshabilitar el tablero
                    if (intentos >= MaxIntentos)
                    {
                        panel1.Enabled = false;
                        MessageBox.Show("Se acabaron los intentos.", "Intentos agotados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    // Iniciar temporizador para que el jugador vea las cartas antes de volver a girarlas
                    temporizador.Enabled = true;
                    temporizador.Start();
                }
            }
        }

        // Botón reinicio: vuelve a empezar la partida y reordena las cartas
        private void btnReinicio_Click(object? sender, EventArgs e)
        {
            // Reconfigura el juego (baraja, reinicia contadores)
            IniciarJuego();
            panel1.Enabled = true; // asegurar que el tablero esté habilitado

            // Poner todas las cartas en su parte trasera y habilitarlas
            foreach (Control c in tablero1.Controls)
            {
                if (c is PictureBox pb)
                {
                    pb.Image = Properties.Resources.parteTraseraDeCartasReciclaje;
                    pb.Enabled = true;
                }
            }

            // Limpiar estado temporal y detener temporizador por si acaso
            cartasSeleccionadas?.Clear();
            cartaTemp1 = null;
            cartaTemp2 = null;
            temporizador.Stop();
            temporizador.Enabled = false;
        }

        #region Lógica del juego
        // Método que devuelve la imagen frontal según el número (0-7)
        private Bitmap RecuperarImagen(int numeroImagen)
        {
            switch (numeroImagen)
            {
                case 0:
                    return Properties.Resources.cartaReciclajeGeneral1;
                case 1:
                    return Properties.Resources.cartaReciclajeGeneral2;
                case 2:
                    return Properties.Resources.cartaReciclajeMetales;
                case 3:
                    return Properties.Resources.cartaReciclajeOrgánicos;
                case 4:
                    return Properties.Resources.cartaReciclajePapel;
                case 5:
                    return Properties.Resources.cartaReciclajePeligrosos;
                case 6:
                    return Properties.Resources.cartaReciclajePlástico;
                case 7:
                    return Properties.Resources.cartaReciclajeVidrio;
                default:
                    return Properties.Resources.parteTraseraDeCartasReciclaje;
            }
        }
        #endregion
    }
}
