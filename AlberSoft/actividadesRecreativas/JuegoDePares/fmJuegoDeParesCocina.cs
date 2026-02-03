// System.Collections tiene la clase ArrayList que usamos
using System.Collections;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace AlberSoft.activadesRecreativas
{
    public partial class fmJuegoDeParesCocina : Form
    {
        #region Declaramos variables
        // Límite de tiempo en segundos
        private const int TimeLimitSeconds = 120;

        // Tiempo restante en la partida actual
        private int tiempoRestante;

        // Temporizador que cuenta el tiempo de la partida (1s)
        private Timer gameTimer;

        // Creamos una listas para gestionar las cartas enumeradas
        private List<int> cartasEnumeradas;
        // Creamos una lista para gestionar las cartas revueltas
        private List<int> cartasRevueltas;

        // Creamos una lista para las cartas seleccionadas temporalmente
        private ArrayList cartasSeleccionadas;

        // Creamos PictureBox temporales para las cartas seleccionadas
        private PictureBox cartaTemp1;
        private PictureBox cartaTemp2;

        // Contador de parejas encontradas
        private int parejasEncontradas = 0;

        // Random compartido para barajar correctamente
        private static readonly Random aleatorio = new Random();
        #endregion

        public fmJuegoDeParesCocina()
        {
            InitializeComponent();

            // Inicializar el temporizador del juego (cuenta regresiva)
            gameTimer = new Timer
            {
                Interval = 1000
            };
            gameTimer.Tick += GameTimer_Tick;
        }


        private void timer_Cartas(object sender, EventArgs e)
        {
            // Si existen cartas temporales, las giramos al reverso
            if (cartaTemp1 != null)
                cartaTemp1.Image = Properties.Resources.parteTraseraDeCartasCocina;
            if (cartaTemp2 != null)
                cartaTemp2.Image = Properties.Resources.parteTraseraDeCartasCocina;

            // Limpiar selección de cartas y cartas temporales para poder seguir jugando
            cartasSeleccionadas?.Clear();
            cartaTemp1 = null;
            cartaTemp2 = null;

            // Detener temporizador de volteo
            temporizador.Stop();
            temporizador.Enabled = false;
        }

        private void tableroGeneral_Paint(object sender, PaintEventArgs e)
        {
            // Este evento se deja vacío; el Diseñador lo genera si quieres dibujar manualmente
        }

        private void IniciarJuego()
        {
            // Detener temporizadores en curso
            temporizador.Stop();
            temporizador.Enabled = false;
            gameTimer.Stop();

            // Reiniciar contadores
            parejasEncontradas = 0;

            // Iniciar tiempo
            tiempoRestante = TimeLimitSeconds;
            try
            {
                label2.Content = $"Tiempo restante: {tiempoRestante}s";
            }
            catch { }

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
            // foreach recorre todos los controles dentro del tablero1
            foreach (Control c in tablero1.Controls)
            {
                // Si el control dentro del tablero1 es un PictureBox
                // le asignamos la imagen "parteTraseraDeCartasCocina" y Tag
                if (c is PictureBox pictureBox)
                {
                    pictureBox.Image = Properties.Resources.parteTraseraDeCartasCocina;
                    pictureBox.Enabled = true;
                    // Forzamos a tratar la propiedad Tag como un entero
                    pictureBox.Tag = indice++;
                }
            }

            // Limpiar selección temporal
            cartasSeleccionadas = new ArrayList();
            cartaTemp1 = null;
            cartaTemp2 = null;

            // Iniciar el temporizador de la partida
            gameTimer.Start();
        }

        private void fmJuegoDeParesCocina_Load(object sender, EventArgs e)
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

                    // Si se encuentran todas las parejas, avisar al usuario y detener temporizador de juego
                    if (parejasEncontradas >= 8)
                    {
                        gameTimer.Stop();
                        MessageBox.Show("¡Felicitaciones, has encontrado todas las parejas!");
                    }
                }
                else
                {
                    // No coinciden: guardamos temporales para voltearlas cuando suene el temporizador
                    cartaTemp1 = pictureBox1;
                    cartaTemp2 = pictureBox2;

                    // Iniciar temporizador para que el jugador vea las cartas antes de volver a girarlas
                    temporizador.Enabled = true;
                    temporizador.Start();
                }
            }
        }

        // Botón reinicio: vuelve a empezar la partida y reordena las cartas
        private void btnReinicio_Click(object? sender, EventArgs e)
        {
            // Reconfigura el juego (baraja, reinicia contadores y temporizadores)
            IniciarJuego();
            panel1.Enabled = true; // asegurar que el tablero esté habilitado

            // Asegurar todas las cartas en su parte trasera y habilitarlas
            foreach (Control c in tablero1.Controls)
            {
                if (c is PictureBox pb)
                {
                    pb.Image = Properties.Resources.parteTraseraDeCartasCocina;
                    pb.Enabled = true;
                }
            }

            // Limpiar estado temporal y detener temporizador por si acaso
            cartasSeleccionadas?.Clear();
            cartaTemp1 = null;
            cartaTemp2 = null;
            temporizador.Stop();
            temporizador.Enabled = false;

            // Asegurar que el temporizador de la partida esté en marcha tras el reinicio
            gameTimer.Start();
        }

        // Tick del temporizador de la partida (cuenta regresiva)
        private void GameTimer_Tick(object? sender, EventArgs e)
        {
            tiempoRestante--;
            try
            {
                label2.Content = $"Tiempo restante: {tiempoRestante}s";
            }
            catch { }

            if (tiempoRestante <= 0)
            {
                gameTimer.Stop();
                // Deshabilitar tablero y detener temporizador de volteo por si estaba activo
                panel1.Enabled = false;
                temporizador.Stop();
                temporizador.Enabled = false;

                MessageBox.Show("Se acabó el tiempo.", "Fin de la partida", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region Lógica del juego
        // Método que devuelve la imagen frontal según el número (0-7)
        private Bitmap RecuperarImagen(int numeroImagen)
        {
            switch (numeroImagen)
            {
                case 0:
                    return Properties.Resources.cartaHelado;
                case 1:
                    return Properties.Resources.cartaMatarta;
                case 2:
                    return Properties.Resources.cartaPanqueques;
                case 3:
                    return Properties.Resources.cartaTostadas;
                case 4:
                    return Properties.Resources.cartaAvena;
                case 5:
                    return Properties.Resources.cartaPescado;
                case 6:
                    return Properties.Resources.cartaPollo;
                case 7:
                    return Properties.Resources.cartaPolloBrocoli;
                default:
                    return Properties.Resources.parteTraseraDeCartasCocina;
            }
        }
        #endregion
    }
}
