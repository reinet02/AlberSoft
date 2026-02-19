// System.Collections tiene la clase ArrayList que usamos
using System.Collections;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace AlberSoft.activadesRecreativas
{
    public partial class fmJuegoDeParesReciclaje : Form
    {
        #region Declaramos variables
        // Límite de tiempo en segundos
        private const int TimeLimitSeconds = 60;

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

        public fmJuegoDeParesReciclaje()
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

            // El temporizador se iniciará cuando el jugador gire la primera carta
            // (se inicia en `carta_Click` para que el tiempo empiece al primer movimiento)
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

            // Iniciar el temporizador de la partida al primer movimiento (primer volteo)
            if (gameTimer != null && !gameTimer.Enabled && tiempoRestante == TimeLimitSeconds)
            {
                gameTimer.Start();
            }

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
                    {
                        // Parar temporizadores y bloquear el tablero: fin del juego
                        try { gameTimer?.Stop(); } catch { }
                        try { temporizador?.Stop(); temporizador.Enabled = false; } catch { }
                        panel1.Enabled = false;

                       

                        // Asegurar que el tiempo mostrado no siga decrementando
                        tiempoRestante = 0;
                        try { label2.Content = $"Tiempo restante: {tiempoRestante}s"; } catch { }

                        MessageBox.Show("¡Felicitaciones, encontraste todas las parejas, ahora ayúdanos a que el reciclaje y la naturaleza sean siempre el dúo perfecto. ¡Sigue brillando y reciclando! 🌱💚\"", "¡Victoria para ti y para la Tierra! 🏆\r\n\r\n", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // El temporizador de la partida no se inicia aquí: se arrancará al primer volteo de carta
        }

        // Tick del temporizador de la partida (cuenta regresiva)
        private void GameTimer_Tick(object? sender, EventArgs e)
        {
            if (tiempoRestante > 0)
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

                MessageBox.Show("En la naturaleza, el tiempo es sagrado. No logramos completar todos los pares esta vez, pero la buena noticia es que siempre hay una nueva oportunidad para hacerlo mejor. ¿Te animas a otra ronda? ♻️", "¡Uuuy, se nos acabó el tiempo! 🕒🍃", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

        private void label2_Load(object sender, EventArgs e)
        {

        }

        private void btnsolucionfacil_Click(object sender, EventArgs e)
        {
            // Sólo permitir mostrar la solución si el tiempo ha expirado
            if (tiempoRestante > 0)
            {
                MessageBox.Show("La solución sólo está disponible cuando se termina el tiempo, asi que termina el juego ¡NO TE RINDAS!", "Información (>‿◠)✌", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (cartasRevueltas == null)
            {
                MessageBox.Show("No hay un juego en curso.", "Información 👀", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            
            }

            // Mostrar todas las cartas (frontal) y deshabilitarlas para que el usuario vea la solución
            foreach (Control c in tablero1.Controls)
            {
                if (c is PictureBox pb)
                {
                    int indice = pb.Tag is int t ? t : -1;
                    if (indice >= 0 && indice < cartasRevueltas.Count)
                    {
                        pb.Image = RecuperarImagen(cartasRevueltas[indice]);
                    }
                    pb.Enabled = false;
                }
            }

            // Detener temporizadores por si acaso y deshabilitar el panel
            try { gameTimer?.Stop(); } catch { }
            try { temporizador?.Stop(); temporizador.Enabled = false; } catch { }
            panel1.Enabled = false;

            MessageBox.Show("Se ha mostrado la solución.", "Solución ʕ•́ᴥ•̀ʔっ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}

