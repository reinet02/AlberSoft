using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlberSoft.mapaInteractivo
{
    public partial class fmQuiz2 : Form
    {
        public fmQuiz2()
        {
            InitializeComponent();
        }

        public static class QuizData
        {
            #region Modelo de preguntas
            public class Preguntas
            {
                public string Text { get; set; } = "";
                public string[] Options { get; set; } = Array.Empty<string>();
                public int CorrectIndex { get; set; } = 0;
            }
            #endregion

            #region Función para obtener preguntas según el nivel seleccionado por el usuario
            public static List<Preguntas> GetPreguntassForLevel(int level)
            {
                var list = new List<Preguntas>();

                if (level == 1)
                {
                    // Nivel fácil: preguntas básicas sobre albergues
                    list.Add(new Preguntas
                    {
                        Text = "¿Qué es un albergue?",
                        Options = new[] { "Un hospital", "Un lugar de alojamiento temporal", "Una escuela", "Un restaurante" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Para quiénes están destinados principalmente los albergues?",
                        Options = new[] { "Turistas de lujo", "Personas en situación vulnerable", "Empresarios", "Deportistas" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué servicio básico ofrece un albergue?",
                        Options = new[] { "Piscina", "Alojamiento", "Cine", "Gimnasio" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Los albergues suelen ser gratuitos o de bajo costo?",
                        Options = new[] { "No", "Solo para extranjeros", "Sí", "Solo los privados" },
                        CorrectIndex = 2
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué personas pueden acudir a un albergue?",
                        Options = new[] { "Personas sin hogar", "Solo niños", "Solo turistas", "Solo empleados" },
                        CorrectIndex = 0
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Un albergue puede brindar alimentación?",
                        Options = new[] { "No", "A veces", "Nunca", "Solo fines de semana" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Los albergues ayudan en casos de emergencia?",
                        Options = new[] { "No", "Solo en fiestas", "Sí", "Solo hospitales" },
                        CorrectIndex = 2
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Quién puede administrar un albergue?",
                        Options = new[] { "ONG", "Discotecas", "Bancos", "Centros comerciales" },
                        CorrectIndex = 0
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Un albergue es un lugar permanente para vivir?",
                        Options = new[] { "Sí", "No", "Siempre", "Solo para familias" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Los albergues promueven la solidaridad?",
                        Options = new[] { "No", "A veces", "Sí", "Nunca" },
                        CorrectIndex = 2
                    });
                }
                else if (level == 2)
                {
                    // Nivel medio: conocimientos más específicos sobre albergues
                    list.Add(new Preguntas
                    {
                        Text = "¿Cuál es uno de los principales objetivos de un albergue?",
                        Options = new[] { "Generar ganancias", "Brindar alojamiento temporal", "Vender productos", "Ofrecer entretenimiento" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué tipo de personas suelen acudir a albergues en casos de desastres naturales?",
                        Options = new[] { "Turistas", "Personas afectadas", "Empresarios", "Estudiantes" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué institución suele apoyar la gestión de albergues en emergencias?",
                        Options = new[] { "Cruz Roja", "Bancos", "Tiendas comerciales", "Empresas privadas" },
                        CorrectIndex = 0
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué servicio adicional pueden ofrecer algunos albergues?",
                        Options = new[] { "Asistencia psicológica", "Venta de autos", "Cursos universitarios", "Publicidad" },
                        CorrectIndex = 0
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Los albergues pueden ser administrados por el Estado?",
                        Options = new[] { "No", "Solo por empresas", "Sí", "Solo por iglesias" },
                        CorrectIndex = 2
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué tipo de alojamiento suele tener un albergue?",
                        Options = new[] { "Habitaciones privadas de lujo", "Espacios compartidos", "Suites exclusivas", "Casas independientes" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué grupo vulnerable suele ser prioritario en los albergues?",
                        Options = new[] { "Adultos mayores y niños", "Empresarios", "Turistas extranjeros", "Funcionarios públicos" },
                        CorrectIndex = 0
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Cuál es una norma común dentro de los albergues?",
                        Options = new[] { "Respetar horarios y normas de convivencia", "Permanecer indefinidamente", "No seguir reglas", "Salir solo de noche" },
                        CorrectIndex = 0
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué factor es importante para la ubicación de un albergue?",
                        Options = new[] { "Zona segura", "Zona comercial", "Centro turístico", "Zona privada" },
                        CorrectIndex = 0
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Los albergues ayudan a la reintegración social?",
                        Options = new[] { "No", "Solo a turistas", "Sí", "Nunca" },
                        CorrectIndex = 2
                    });
                }
                else
                {
                    // Nivel difícil: preguntas más detalladas sobre albergues
                    list.Add(new Preguntas
                    {
                        Text = "¿Qué tipo de albergue está diseñado para atender a personas desplazadas por desastres naturales?",
                        Options = new[] { "Albergue turístico", "Albergue temporal de emergencia", "Hostal privado", "Hotel comunitario" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Cuál es un criterio clave para habilitar un albergue temporal?",
                        Options = new[] { "Ubicación en zona de riesgo", "Acceso limitado", "Seguridad estructural", "Lejanía de servicios" },
                        CorrectIndex = 2
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué entidad en Ecuador coordina la gestión de albergues en emergencias?",
                        Options = new[] { "Ministerio de Turismo", "Servicio Nacional de Gestión de Riesgos", "Ministerio de Educación", "Banco Central" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué documento suele utilizarse para registrar a las personas que ingresan a un albergue?",
                        Options = new[] { "Contrato laboral", "Ficha de registro", "Pasaporte", "Formulario bancario" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué principio es fundamental para la convivencia en un albergue?",
                        Options = new[] { "Competencia", "Respeto y solidaridad", "Individualismo", "Privacidad absoluta" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué servicio es indispensable dentro de un albergue?",
                        Options = new[] { "Internet de alta velocidad", "Alimentación básica", "Tiendas comerciales", "Entretenimiento nocturno" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué tipo de personal suele apoyar en la administración de un albergue?",
                        Options = new[] { "Voluntarios y autoridades", "Solo empresarios", "Turistas", "Estudiantes universitarios obligatorios" },
                        CorrectIndex = 0
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué medida sanitaria es importante en los albergues?",
                        Options = new[] { "Hacinamiento", "Control de higiene y salud", "Falta de agua potable", "Ausencia de limpieza" },
                        CorrectIndex = 1
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Los albergues pueden ser permanentes?",
                        Options = new[] { "Siempre", "Nunca", "Dependiendo de su finalidad", "Solo en zonas turísticas" },
                        CorrectIndex = 2
                    });

                    list.Add(new Preguntas
                    {
                        Text = "¿Qué derecho debe garantizarse a las personas alojadas en un albergue?",
                        Options = new[] { "Discriminación", "Acceso a servicios básicos", "Aislamiento total", "Pago obligatorio" },
                        CorrectIndex = 1
                    });
                }

                return list;
            }
            #endregion
        }
    }
}
