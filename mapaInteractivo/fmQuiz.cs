namespace AlberSoft.mapaInteractivo
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    public partial class fmQuiz : Form
    {
        // Estado del quiz
        private readonly List<PreguntasYRespuestas.PlantillaParaPreguntas> preguntas = new();
        private int indiceActual = 0;
        private int puntuación = 0;
        private int tiempoRestante = 0;

        // Control de nivel y tiempos
        private readonly int nivelSeleccionado;
        private readonly int tiempoTotalPorNivel;        // segundos totales para el nivel
        private readonly int penalizacionPorIncorrecta;  // segundos a restar por respuesta incorrecta
        private bool perdido = false;

        // Recibe el nivel (1, 2 o 3) seleccionado en fmQuiz1
        public fmQuiz(int nivel)
        {
            InitializeComponent();

            // Guardar nivel y establecer tiempos según especificación:
            // fácil: 5 minutos (300s), intermedio: 3 minutos (180s), difícil: 2 minutos (120s)
            // penalizaciones: fácil 5s, intermedio 10s, difícil 15s
            nivelSeleccionado = nivel;
            tiempoTotalPorNivel = nivel switch
            {
                1 => 300,
                2 => 180,
                3 => 120,
                _ => 120
            };
            penalizacionPorIncorrecta = nivel switch
            {
                1 => 5,
                2 => 10,
                3 => 15,
                _ => 10
            };

            // Cargar las preguntas según el nivel
            preguntas.AddRange(PreguntasYRespuestas.ObtenerPreguntasPorNivel(nivel));

            // Inicializar tiempo total del nivel (tiempo no se reinicia por pregunta)
            tiempoRestante = tiempoTotalPorNivel;
            labelTiempo.Content = FormatearTiempo(tiempoRestante);

            // Iniciar temporizador del nivel (el evento Tick ya debe estar asociado en el diseñador)
            temporizadorPreguntas.Start();

            // Mostrar la primera pregunta
            MostrarPreguntaActual();
        }

        #region Función para reiniar/formatear el tiempo del label "labelTiempo"
        private static string FormatearTiempo(int segundos)
        {
            // retornamos un string
            return $"{segundos}s";
        }
        #endregion

        #region Función para controlar el tiempo del temporizador (tiempo total por nivel)
        private void ManejarTickTemporizador(object? sender, EventArgs e)
        {
            if (perdido) return;

            tiempoRestante--;
            if (tiempoRestante < 0) tiempoRestante = 0;
            labelTiempo.Content = FormatearTiempo(tiempoRestante);

            if (tiempoRestante == 0)
            {
                temporizadorPreguntas.Stop();
                MostrarPerdida("Se acabó el tiempo.");
            }
        }
        #endregion

        #region Función dónde definimos las preguntas y respuestas
        public static class PreguntasYRespuestas
        {
            #region Plantilla para las preguntas
            public class PlantillaParaPreguntas
            {
                public string Text { get; set; } = "";
                public string[] Options { get; set; } = Array.Empty<string>();
                public int CorrectIndex { get; set; } = 0;
            }
            #endregion

            #region Función para obtener PlantillaParaPreguntas según el nivel seleccionado por el usuario
            public static List<PlantillaParaPreguntas> ObtenerPreguntasPorNivel(int nivel)
            {
                var list = new List<PlantillaParaPreguntas>();

                if (nivel == 1)
                {
                    // Un espacio antes de cada elemento de la lista para q haya un espacio entre el icono de las respuestas y las respuestas 
                    #region Nivel fácil
                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué es un albergue?",
                        Options = new[] { " Un hospital", " Un lugar de alojamiento temporal", " Una escuela", " Un restaurante" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Para quiénes están destinados principalmente los albergues?",
                        Options = new[] { " Turistas de lujo", " Personas en situación vulnerable", " Empresarios", " Deportistas" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué servicio básico ofrece un albergue?",
                        Options = new[] { " Piscina", " Alojamiento", " Cine", " Gimnasio" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Los albergues suelen ser gratuitos o de bajo costo?",
                        Options = new[] { " No", " Solo para extranjeros", " Sí", " Solo los privados" },
                        CorrectIndex = 2
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué personas pueden acudir a un albergue?",
                        Options = new[] { " Personas sin hogar", " Solo niños", " Solo turistas", " Solo empleados" },
                        CorrectIndex = 0
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Un albergue puede brindar alimentación?",
                        Options = new[] { " No", " A veces", " Nunca", " Solo fines de semana" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Los albergues ayudan en casos de emergencia?",
                        Options = new[] { " No", " Solo en fiestas", " Sí", " Solo hospitales" },
                        CorrectIndex = 2
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Quién puede administrar un albergue?",
                        Options = new[] { " ONG", " Discotecas", " Bancos", " Centros comerciales" },
                        CorrectIndex = 0
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Un albergue es un lugar permanente para vivir?",
                        Options = new[] { " Sí", " No", " Siempre", " Solo para familias" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Los albergues promueven la solidaridad?",
                        Options = new[] { " No", " A veces", " Sí", " Nunca" },
                        CorrectIndex = 2
                    });
                }
                #endregion
                else if (nivel == 2)
                {
                    #region Nivel intermedio
                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Cuál es uno de los principales objetivos de un albergue?",
                        Options = new[] { " Generar ganancias", " Brindar alojamiento temporal", " Vender productos", " Ofrecer entretenimiento" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué tipo de personas suelen acudir a albergues en casos de desastres naturales?",
                        Options = new[] { " Turistas", " Personas afectadas", " Empresarios", " Estudiantes" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué institución suele apoyar la gestión de albergues en emergencias?",
                        Options = new[] { " Cruz Roja", " Bancos", " Tiendas comerciales", " Empresas privadas" },
                        CorrectIndex = 0
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué servicio adicional pueden ofrecer algunos albergues?",
                        Options = new[] { " Asistencia psicológica", " Venta de autos", " Cursos universitarios", " Publicidad" },
                        CorrectIndex = 0
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Los albergues pueden ser administrados por el Estado?",
                        Options = new[] { " No", " Solo por empresas", " Sí", " Solo por iglesias" },
                        CorrectIndex = 2
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué tipo de alojamiento suele tener un albergue?",
                        Options = new[] { " Habitaciones privadas de lujo", " Espacios compartidos", " Suites exclusivas", " Casas independientes" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué grupo vulnerable suele ser prioritario en los albergues?",
                        Options = new[] { " Adultos mayores y niños", " Empresarios", " Turistas extranjeros", " Funcionarios públicos" },
                        CorrectIndex = 0
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Cuál es una norma común dentro de los albergues?",
                        Options = new[] { " Respetar horarios y normas de convivencia", " Permanecer indefinidamente", " No seguir reglas", " Salir solo de noche" },
                        CorrectIndex = 0
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué factor es importante para la ubicación de un albergue?",
                        Options = new[] { " Zona segura", " Zona comercial", " Centro turístico", " Zona privada" },
                        CorrectIndex = 0
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Los albergues ayudan a la reintegración social?",
                        Options = new[] { " No", " Solo a turistas", " Sí", " Nunca" },
                        CorrectIndex = 2
                    });
                }
                #endregion
                else
                {
                    #region Nivel difícil
                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué tipo de albergue está diseñado para atender a personas desplazadas por desastres naturales?",
                        Options = new[] { " Albergue turístico", " Albergue temporal de emergencia", " Hostal privado", " Hotel comunitario" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Cuál es un criterio clave para habilitar un albergue temporal?",
                        Options = new[] { " Ubicación en zona de riesgo", " Acceso limitado", " Seguridad estructural", " Lejanía de servicios" },
                        CorrectIndex = 2
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué entidad en Ecuador coordina la gestión de albergues en emergencias?",
                        Options = new[] { " Ministerio de Turismo", " Servicio Nacional de Gestión de Riesgos", " Ministerio de Educación", " Banco Central" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué documento suele utilizarse para registrar a las personas que ingresan a un albergue?",
                        Options = new[] { " Contrato laboral", " Ficha de registro", " Pasaporte", " Formulario bancario" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué principio es fundamental para la convivencia en un albergue?",
                        Options = new[] { " Competencia", " Respeto y solidaridad", " Individualismo", " Privacidad absoluta" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué servicio es indispensable dentro de un albergue?",
                        Options = new[] { " Internet de alta velocidad", " Alimentación básica", " Tiendas comerciales", " Entretenimiento nocturno" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué tipo de personal suele apoyar en la administración de un albergue?",
                        Options = new[] { " Voluntarios y autoridades", " Solo empresarios", " Turistas", " Estudiantes universitarios obligatorios" },
                        CorrectIndex = 0
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué medida sanitaria es importante en los albergues?",
                        Options = new[] { " Hacinamiento", " Control de higiene y salud", " Falta de agua potable", " Ausencia de limpieza" },
                        CorrectIndex = 1
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Los albergues pueden ser permanentes?",
                        Options = new[] { " Siempre", " Nunca", " Dependiendo de su finalidad", " Solo en zonas turísticas" },
                        CorrectIndex = 2
                    });

                    list.Add(new PlantillaParaPreguntas
                    {
                        Text = "¿Qué derecho debe garantizarse a las personas alojadas en un albergue?",
                        Options = new[] { " Discriminación", " Acceso a servicios básicos", " Aislamiento total", " Pago obligatorio" },
                        CorrectIndex = 1
                    });
                    #endregion
                }
                return list;
            }
            #endregion
        }
        #endregion

        #region Función para mostrar los resultados al finalizar el quiz
        private void MostrarResultados()
        {
            // Si se llegó al final sin haber perdido => todas correctas => victoria
            if (!perdido && puntuación == preguntas.Count)
            {
                MessageBox.Show($"¡Has ganado! Puntuación: {puntuación} / {preguntas.Count}", "Victoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Has terminado. Puntuación: {puntuación} / {preguntas.Count}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Close();
        }
        #endregion

        #region Mostrar pérdida inmediata
        private void MostrarPerdida(string motivo)
        {
            perdido = true;
            MessageBox.Show($"{motivo}\nHas perdido el juego.", "Perdiste", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Close();
        }
        #endregion

        #region Función para mostrar las preguntas
        // Muestra la pregunta actual y asigna textos a los botones.
        private void MostrarPreguntaActual()
        {
            if (indiceActual < 0 || indiceActual >= preguntas.Count)
            {
                MostrarResultados();
                return;
            }

            var p = preguntas[indiceActual];

            // labelPregunta
            labelPregunta.Content = p.Text;

            // Asignar texto a botones (asegurarse del orden)
            btn1.Content = p.Options.Length > 0 ? p.Options[0] : "";
            btn2.Content = p.Options.Length > 1 ? p.Options[1] : "";
            btn3.Content = p.Options.Length > 2 ? p.Options[2] : "";
            btn4.Content = p.Options.Length > 3 ? p.Options[3] : "";

            // NOTA: No reiniciamos el temporizador por pregunta: el tiempo es total por nivel.
            // El temporizador ya está en marcha desde el constructor y se actualiza en ManejarTickTemporizador.
        }
        #endregion

        #region Función para saltar la pregunta
        private void SaltarPregunta_Click(object? sender, EventArgs e)
        {
            if (perdido) return;

            indiceActual++;
            if (indiceActual >= preguntas.Count)
            {
                temporizadorPreguntas.Stop();
                MostrarResultados();
            }
            else
            {
                MostrarPreguntaActual();
            }
        }
        #endregion

        #region Función para controlar la selección de una respuesta
        private void Opcion_Click(object? sender, EventArgs e)
        {
            if (indiceActual >= preguntas.Count || perdido) return;

            var p = preguntas[indiceActual];

            // Determinar qué botón fue clickeado y su índice
            int selected = sender switch
            {
                CuoreUI.Controls.cuiButton b when b == btn1 => 0,
                CuoreUI.Controls.cuiButton b when b == btn2 => 1,
                CuoreUI.Controls.cuiButton b when b == btn3 => 2,
                CuoreUI.Controls.cuiButton b when b == btn4 => 3,
                _ => -1,
            };

            if (selected == -1) return;

            // Respuesta correcta
            if (selected == p.CorrectIndex)
            {
                puntuación++;
                if (labelContadorRespuestasCorrectas != null)
                {
                    labelContadorRespuestasCorrectas.Content = $"Correctas: {puntuación}";
                }
                MessageBox.Show("¡Correcto!", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Avanzar
                indiceActual++;
                if (indiceActual >= preguntas.Count)
                {
                    temporizadorPreguntas.Stop();
                    MostrarResultados();
                }
                else
                {
                    MostrarPreguntaActual();
                }
            }
            else
            {
                // Aplicar penalización de tiempo y continuar con el quiz (no salir inmediatamente)
                tiempoRestante -= penalizacionPorIncorrecta;
                if (tiempoRestante < 0) tiempoRestante = 0;
                labelTiempo.Content = FormatearTiempo(tiempoRestante);

                // Mostrar mensaje indicando que está incorrecta y cuál es la respuesta correcta
                string respuestaCorrecta = (p.Options.Length > p.CorrectIndex && p.CorrectIndex >= 0)
                    ? p.Options[p.CorrectIndex].Trim()
                    : "No disponible";
                MessageBox.Show($"Respuesta incorrecta.\nRespuesta correcta: {respuestaCorrecta}\nSe han restado {penalizacionPorIncorrecta} segundos.", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                // Si el tiempo llegó a cero, terminar partida
                if (tiempoRestante == 0)
                {
                    temporizadorPreguntas.Stop();
                    MostrarPerdida("Se acabó el tiempo.");
                    return;
                }

                // Avanzar a la siguiente pregunta (no se incrementa la puntuación)
                indiceActual++;
                if (indiceActual >= preguntas.Count)
                {
                    temporizadorPreguntas.Stop();
                    MostrarResultados();
                }
                else
                {
                    MostrarPreguntaActual();
                }
            }
        }
        #endregion

        private void tablaGeneralFila2Derecha_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelPregunta_Load(object sender, EventArgs e)
        {

        }

        private void fmQuiz_Load(object sender, EventArgs e)
        {

        }

        private void Instrucciones_Click(object sender, EventArgs e)
        {
            fmInstruccionesQuiz ins = new fmInstruccionesQuiz(nivelSeleccionado);
            ins.ShowDialog();
        }
    }
}