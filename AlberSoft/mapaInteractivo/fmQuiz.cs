using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace AlberSoft.mapaInteractivo
{
    public partial class fmQuiz : Form
    {
        #region Campos para el quiz reutilizable
        // Nivel actual (1,2,3)
        private int currentLevel = 1;

        // Preguntas del nivel cargadas
        private List<QuizData.Question> questions = new List<QuizData.Question>();

        // Indice de la pregunta actual (0..9)
        private int currentQuestionIndex = 0;

        // Puntuacion
        private int score = 0;

        // Controles dinamicos para mostrar pregunta y opciones
        private Label lblQuestion;
        private Button[] optionButtons;
        // Indice de la opción seleccionada actualmente (-1 = ninguna)
        private int selectedOption = -1;
        private Button btnNext;
        // (opcional) botón dentro del panel para volver al menú del juego si se necesita
        private Button btnBack;
        // Seguimiento hover para opciones (usado por el estilo opcional)
        private HashSet<int> hoveredOptions = new HashSet<int>();
        // Seguimiento hover para botones de navegación
        private HashSet<Button> hoveredNavButtons = new HashSet<Button>();
        // Color de selección elegante
        private readonly Color selectionColor = Color.FromArgb(30, 130, 210);
        // Botón para volver al menú principal desde la pantalla de selección de nivel
        private Button btnBackMain;
        // Botón para volver al menú del juego (desde dentro del quiz)
        private Button btnReturnGameMenu;
        // Panel flotante que contiene el quiz (mejora visual)
        private Panel panelQuiz;
        // Titulo del quiz que muestra el nivel y numero de pregunta
        private Label lblTitle;
        // Etiqueta para retroalimentacion dentro del panel
        private Label lblFeedback;
        // Temporizador para mostrar la retroalimentacion unos milisegundos antes de la siguiente pregunta
        private System.Windows.Forms.Timer feedbackTimer;

        // Margen alrededor del panel y espacio mínimo
        private const int PanelMargin = 12;
        private const int MinPanelWidth = 400;
        private const int MinPanelHeight = 300;
        #endregion

        public fmQuiz()
        {
            InitializeComponent();
            // Inicializar controles del quiz cuando se crea la ventana
            InicializarQuizControls();

            // Suscribir programáticamente los Click del diseñador a los manejadores existentes.
            // Esto evita tener que editar el .Designer.cs y resuelve cuando los nombres difieren.
            try { if (bntfacil != null) bntfacil.Click += bntfacil_Click; } catch { }
            try { if (bnmedio != null) bnmedio.Click += button1_Click; } catch { }
            try { if (bndificil != null) bndificil.Click += button2_Click; } catch { }
        }

        // Aplica estilo a botones de navegación (volver / siguiente)
        private void ApplyElegantNavButton(Button btn, Color bg, Color fg)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = bg;
            btn.ForeColor = fg;

            btn.MouseEnter += (s, e) => { hoveredNavButtons.Add(btn); btn.Invalidate(); };
            btn.MouseLeave += (s, e) => { hoveredNavButtons.Remove(btn); btn.Invalidate(); };

            btn.Paint += (s, e) =>
            {
                var b = s as Button;
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Rectangle rect = new Rectangle(0, 0, b.Width, b.Height);
                int radius = Math.Max(6, b.Height / 4);

                Color baseColor = b.BackColor;
                if (hoveredNavButtons.Contains(b)) baseColor = ControlPaint.Light(baseColor);

                using (var path = RoundedRect(rect, radius))
                using (var brush = new SolidBrush(baseColor))
                {
                    g.FillPath(brush, path);
                }

                using (var pen = new Pen(Color.FromArgb(200, 200, 200)))
                using (var path = RoundedRect(rect, radius))
                {
                    g.DrawPath(pen, path);
                }

                TextRenderer.DrawText(g, b.Text, b.Font, rect, b.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };
        }

        // Aplica estilo elegante y handlers para un botón de opción
        private void ApplyElegantStyle(Button btn, int index)
        {
            // Quitamos el fondo transparente por defecto y pintaremos manualmente
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            // Eventos para hover visual
            btn.MouseEnter += (s, e) => { hoveredOptions.Add(index); btn.Invalidate(); };
            btn.MouseLeave += (s, e) => { hoveredOptions.Remove(index); btn.Invalidate(); };

            // Dibujar con esquinas redondeadas y gradiente suave
            btn.Paint += (s, e) =>
            {
                var b = s as Button;
                var g = e.Graphics;
                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Determinar estado
                bool isSelected = selectedOption == index;
                bool isHovered = hoveredOptions.Contains(index);

                Rectangle rect = new Rectangle(0, 0, b.Width, b.Height);
                int radius = Math.Max(8, b.Height / 6);

                Color baseColor = Color.White;
                if (isSelected) baseColor = selectionColor;
                else if (isHovered) baseColor = Color.FromArgb(245, 250, 255);

                // Gradiente ligero
                using (var path = RoundedRect(rect, radius))
                using (var brush = new LinearGradientBrush(rect, ControlPaint.Light(baseColor), ControlPaint.Dark(baseColor), LinearGradientMode.Vertical))
                {
                    g.FillPath(brush, path);
                }

                // Border
                using (var pen = new Pen(Color.FromArgb(200, 200, 200)))
                {
                    using (var path = RoundedRect(rect, radius))
                    {
                        g.DrawPath(pen, path);
                    }
                }

                // Texto: dibujar centrado
                TextRenderer.DrawText(g, b.Text, b.Font, rect, isSelected ? Color.White : b.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };
        }

        // Crea un GraphicsPath de un rectángulo con esquinas redondeadas
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

        private void bntfacil_Click(object sender, EventArgs e)
        {
            // Cargar preguntas del nivel 1 y mostrar el primer conjunto
            StartLevel(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Nivel medio (boton 2)
            StartLevel(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Nivel difícil (boton 3)
            StartLevel(3);
        }

        #region Metodos para controlar el quiz
        // Inicializar controles UI que se reutilizaran para los 3 niveles
        private void InicializarQuizControls()
        {
            // Crear panel flotante (estética)
            panelQuiz = new Panel();
            panelQuiz.Size = new Size(760, 420);
            panelQuiz.BorderStyle = BorderStyle.FixedSingle;
            panelQuiz.BackColor = Color.FromArgb(250, 250, 250);
            panelQuiz.Visible = false; // oculto hasta iniciar
            panelQuiz.Padding = new Padding(12);
            // Centrar cuando se muestre
            panelQuiz.Anchor = AnchorStyles.None;
            this.Controls.Add(panelQuiz);

            // Titulo del quiz (nivel + numero de pregunta)
            lblTitle = new Label();
            lblTitle.AutoSize = false;
            lblTitle.Size = new Size(panelQuiz.ClientSize.Width - 24, 48);
            lblTitle.Location = new Point(12, 8);
            lblTitle.Font = new Font("Segoe UI", 18, FontStyle.Bold);
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelQuiz.Controls.Add(lblTitle);

            // Label para la pregunta (dentro del panel)
            lblQuestion = new Label();
            lblQuestion.AutoSize = false;
            lblQuestion.Size = new Size(panelQuiz.ClientSize.Width - 24, 120);
            lblQuestion.Location = new Point(12, lblTitle.Bottom + 8);
            lblQuestion.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelQuiz.Controls.Add(lblQuestion);

            // Botones de opciones (dentro del panel) - paleta fija como Kahoot
            optionButtons = new Button[4];
            Color[] palette = new[] {
                Color.FromArgb(124, 62, 196), // morado
                Color.FromArgb(56, 173, 64),  // verde
                Color.FromArgb(255, 170, 51), // naranja/amarillo
                Color.FromArgb(56, 151, 255)  // azul
            };
            for (int i = 0; i < 4; i++)
            {
                var btn = new Button();
                btn.Location = new Point(12, lblQuestion.Bottom + 12 + i * 48);
                btn.Size = new Size(panelQuiz.ClientSize.Width - 24, 40);
                btn.Tag = i;
                btn.Click += OptionButton_Click;
                btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Segoe UI", 13, FontStyle.Bold);
                btn.BackColor = palette[i];
                btn.ForeColor = Color.White;
                btn.Padding = new Padding(12);
                // ligero efecto al pasar el mouse (solo brillo)
                int idx = i;
                btn.MouseEnter += (s, e) => { btn.BackColor = ControlPaint.Light(palette[idx]); };
                btn.MouseLeave += (s, e) => { if (selectedOption != idx) btn.BackColor = palette[idx]; };
                panelQuiz.Controls.Add(btn);
                optionButtons[i] = btn;
            }

            // Etiqueta para retroalimentación
            lblFeedback = new Label();
            lblFeedback.AutoSize = false;
            lblFeedback.Size = new Size(panelQuiz.ClientSize.Width - 24, 36);
            lblFeedback.Location = new Point(12, optionButtons[3].Bottom + 8);
            lblFeedback.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            lblFeedback.TextAlign = ContentAlignment.MiddleCenter;
            lblFeedback.Visible = false;
            panelQuiz.Controls.Add(lblFeedback);

            // Boton siguiente (dentro del panel)
            btnNext = new Button();
            btnNext.Text = "Siguiente";
            btnNext.Size = new Size(140, 40);
            btnNext.Location = new Point(panelQuiz.ClientSize.Width - 12 - btnNext.Width, panelQuiz.ClientSize.Height - 56);
            btnNext.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnNext.Font = new Font("Segoe UI", 11, FontStyle.Regular);
            btnNext.Click += BtnNext_Click;
            panelQuiz.Controls.Add(btnNext);
            // Aplicar estilo elegante al boton siguiente (primario)
            ApplyElegantNavButton(btnNext, selectionColor, Color.White);

            // (no button inside the quiz panel to return; navigation handled from outer menu)

            // Timer para retroalimentacion visual
            feedbackTimer = new System.Windows.Forms.Timer();
            feedbackTimer.Interval = 1100; // ms
            feedbackTimer.Tick += FeedbackTimer_Tick;

            // Reubicamos el panel cuando la forma cambia de tamaño
            this.Resize += (s, e) => CenterPanel();

            // Botón para volver al menú principal (visible en la pantalla inicial de selección de nivel)
            btnBackMain = new Button();
            btnBackMain.Text = "Volver al menú principal";
            btnBackMain.Size = new Size(160, 36);
            btnBackMain.Location = new Point(12, this.ClientSize.Height - 56);
            btnBackMain.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnBackMain.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            btnBackMain.Click += (s, e) => { try { this.Close(); } catch { } };
            this.Controls.Add(btnBackMain);
            ApplyElegantNavButton(btnBackMain, Color.FromArgb(245, 245, 245), Color.Black);

            // Botón para volver al menú del juego (visible durante el quiz)
            btnReturnGameMenu = new Button();
            btnReturnGameMenu.Text = "Volver al menú del juego";
            btnReturnGameMenu.Size = new Size(160, 36);
            btnReturnGameMenu.Location = new Point(12, this.ClientSize.Height - 56);
            btnReturnGameMenu.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnReturnGameMenu.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            btnReturnGameMenu.Click += (s, e) => { try { EndLevel(); } catch { } };
            this.Controls.Add(btnReturnGameMenu);
            ApplyElegantNavButton(btnReturnGameMenu, Color.FromArgb(245, 245, 245), Color.Black);
            btnReturnGameMenu.Visible = false;
        }

        private void StartLevel(int level)
        {
            currentLevel = level;
            questions = QuizData.GetQuestionsForLevel(level);
            currentQuestionIndex = 0;
            score = 0;
            // Ocultar botones de nivel para que no interfieran con el quiz
            try { bntfacil.Visible = false; } catch { }
            try { bnmedio.Visible = false; } catch { }
            try { bndificil.Visible = false; } catch { }

            // Ajustar tamaño y posición del panel para ocupar casi toda la ventana
            CenterPanel();

            // Asegurar que el panel y sus controles sean visibles y estén al frente
            panelQuiz.Visible = true;
            panelQuiz.BringToFront();
            lblTitle.Visible = true;
            lblQuestion.Visible = true;
            foreach (var rb in optionButtons) { rb.Enabled = true; rb.Visible = true; }
            btnNext.Visible = true;
            if (btnBack != null) btnBack.Visible = true;
            lblFeedback.Visible = false;

            // Ocultar botón de volver al menú principal mientras se juega
            if (btnBackMain != null) btnBackMain.Visible = false;
            if (btnReturnGameMenu != null) btnReturnGameMenu.Visible = true;

            // Cambiar estilo de colores y texto segun nivel
            switch (level)
            {
                case 1:
                    panelQuiz.BackColor = Color.FromArgb(235, 255, 235);
                    lblTitle.BackColor = Color.FromArgb(200, 255, 200);
                    lblTitle.ForeColor = Color.DarkGreen;
                    break;
                case 2:
                    panelQuiz.BackColor = Color.FromArgb(255, 250, 230);
                    lblTitle.BackColor = Color.FromArgb(255, 240, 200);
                    lblTitle.ForeColor = Color.SaddleBrown;
                    break;
                default:
                    panelQuiz.BackColor = Color.FromArgb(255, 240, 240);
                    lblTitle.BackColor = Color.FromArgb(255, 220, 220);
                    lblTitle.ForeColor = Color.DarkRed;
                    break;
            }

            lblTitle.Text = $"Quiz - Nivel {level}";
            MostrarPreguntaActual();
        }

        // Centrar y redimensionar el panel del quiz dentro del formulario
        private void CenterPanel()
        {
            if (panelQuiz == null) return;

            // Deseamos panel grande: casi el 100% del cliente menos márgenes
            int desiredW = Math.Max(MinPanelWidth, this.ClientSize.Width - PanelMargin * 2);
            int desiredH = Math.Max(MinPanelHeight, this.ClientSize.Height - PanelMargin * 2);

            // Calculamos área ocupada por los botones para evitar solapamiento
            Rectangle buttonsRect = Rectangle.Empty;
            try
            {
                var c1 = bntfacil;
                var c2 = bnmedio;
                var c3 = bndificil;
                if (c1 != null && c1.Visible) buttonsRect = buttonsRect.IsEmpty ? c1.Bounds : Rectangle.Union(buttonsRect, c1.Bounds);
                if (c2 != null && c2.Visible) buttonsRect = buttonsRect.IsEmpty ? c2.Bounds : Rectangle.Union(buttonsRect, c2.Bounds);
                if (c3 != null && c3.Visible) buttonsRect = buttonsRect.IsEmpty ? c3.Bounds : Rectangle.Union(buttonsRect, c3.Bounds);
            }
            catch { /* controles podrían no existir en diseño en tiempo de ejecución */ }

            // Posición centrada por defecto
            int x = Math.Max(PanelMargin, (this.ClientSize.Width - desiredW) / 2);
            int y = Math.Max(PanelMargin, (this.ClientSize.Height - desiredH) / 2);

            var candidate = new Rectangle(x, y, desiredW, desiredH);

            // Si el panel solaparía los botones, ajustamos para reservar su espacio
            if (!buttonsRect.IsEmpty && candidate.IntersectsWith(buttonsRect))
            {
                // Si los botones están mayormente a la izquierda, colocamos panel a la derecha del grupo de botones
                if (buttonsRect.Left < this.ClientSize.Width / 2)
                {
                    int newX = buttonsRect.Right + PanelMargin;
                    int newW = this.ClientSize.Width - newX - PanelMargin;
                    desiredW = Math.Max(MinPanelWidth, newW);
                    x = Math.Max(PanelMargin, newX);
                }
                else
                {
                    // botones a la derecha -> dejamos el panel a la izquierda
                    int newW = buttonsRect.Left - PanelMargin - PanelMargin;
                    desiredW = Math.Max(MinPanelWidth, newW);
                    x = PanelMargin;
                }

                // Recalcular y centrar verticalmente
                y = Math.Max(PanelMargin, (this.ClientSize.Height - desiredH) / 2);
            }

            // Asegurar que el panel no desborde la ventana
            if (x + desiredW > this.ClientSize.Width - PanelMargin) desiredW = Math.Max(MinPanelWidth, this.ClientSize.Width - PanelMargin - x);
            if (y + desiredH > this.ClientSize.Height - PanelMargin) desiredH = Math.Max(MinPanelHeight, this.ClientSize.Height - PanelMargin - y);

            panelQuiz.Size = new Size(desiredW, desiredH);
            panelQuiz.Location = new Point(x, y);

            // Ahora re-layout de los controles internos para llenar ese espacio
            LayoutPanelContents();
        }

        // Ajusta tamaños y fuentes de los controles dentro del panel según el tamaño actual
        private void LayoutPanelContents()
        {
            if (panelQuiz == null) return;

            // Calcular tamaños de fuente relativos al alto del panel
            int titleFontSize = Math.Max(16, panelQuiz.Height / 18);
            int questionFontSize = Math.Max(12, panelQuiz.Height / 26);
            int optionFontSize = Math.Max(12, panelQuiz.Height / 32);
            int feedbackFontSize = Math.Max(11, panelQuiz.Height / 36);
            int btnFontSize = Math.Max(10, panelQuiz.Height / 40);

            lblTitle.Font = new Font("Segoe UI", titleFontSize, FontStyle.Bold);
            lblTitle.Size = new Size(panelQuiz.ClientSize.Width - 24, (int)(titleFontSize * 2.2));
            lblTitle.Location = new Point(12, 8);

            lblQuestion.Font = new Font("Segoe UI", questionFontSize, FontStyle.Bold);
            lblQuestion.Size = new Size(panelQuiz.ClientSize.Width - 24, Math.Max(80, panelQuiz.ClientSize.Height / 5));
            lblQuestion.Location = new Point(12, lblTitle.Bottom + 8);

            // Reposicionar las opciones debajo de la pregunta distribuidas equitativamente
            int optionsTop = lblQuestion.Bottom + 12;
            int optionHeight = Math.Max(36, (panelQuiz.ClientSize.Height - optionsTop - 140) / 4);
            for (int i = 0; i < optionButtons.Length; i++)
            {
                var rb = optionButtons[i];
                rb.Font = new Font("Segoe UI", optionFontSize, FontStyle.Regular);
                rb.Size = new Size(panelQuiz.ClientSize.Width - 24, optionHeight);
                rb.Location = new Point(12, optionsTop + i * (optionHeight + 8));
            }

            lblFeedback.Font = new Font("Segoe UI", feedbackFontSize, FontStyle.Regular);
            lblFeedback.Size = new Size(panelQuiz.ClientSize.Width - 24, 36);
            lblFeedback.Location = new Point(12, optionButtons[3].Bottom + 8);

            btnNext.Font = new Font("Segoe UI", btnFontSize, FontStyle.Regular);
            btnNext.Size = new Size(Math.Min(160, panelQuiz.ClientSize.Width / 6), Math.Max(36, panelQuiz.ClientSize.Height / 14));
            btnNext.Location = new Point(panelQuiz.ClientSize.Width - 12 - btnNext.Width, panelQuiz.ClientSize.Height - btnNext.Height - 12);

            // Ajustar posicion del boton volver
            if (btnBack != null)
            {
                btnBack.Font = new Font("Segoe UI", btnFontSize, FontStyle.Regular);
                btnBack.Size = new Size(Math.Min(160, panelQuiz.ClientSize.Width / 6), Math.Max(36, panelQuiz.ClientSize.Height / 14));
                btnBack.Location = new Point(12, panelQuiz.ClientSize.Height - btnBack.Height - 12);
            }
        }

        private void MostrarPreguntaActual()
        {
            if (currentQuestionIndex < 0 || currentQuestionIndex >= questions.Count) return;
            var q = questions[currentQuestionIndex];
            lblQuestion.Text = q.Text;
            // Reset selección
            selectedOption = -1;
            for (int i = 0; i < 4; i++)
            {
                optionButtons[i].Text = q.Options.Length > i ? q.Options[i] : string.Empty;
                optionButtons[i].Enabled = true;
                optionButtons[i].BackColor = Color.White;
                optionButtons[i].ForeColor = Color.Black;
                optionButtons[i].FlatAppearance.BorderColor = Color.FromArgb(220, 220, 220);
            }
            // Actualizar texto del boton siguiente (si es la ultima pregunta)
            if (currentQuestionIndex == questions.Count - 1)
                btnNext.Text = "Finalizar";
            else
                btnNext.Text = "Siguiente";
            // Actualizar titulo para mostrar el numero de pregunta
            lblTitle.Text = $"Nivel {currentLevel} — Pregunta {currentQuestionIndex + 1}/{questions.Count}";
        }

        private void OptionButton_Click(object? sender, EventArgs e)
        {
            // Marcar visualmente la opción seleccionada (solo una)
            if (sender is not Button btn) return;
            try
            {
                selectedOption = Convert.ToInt32(btn.Tag);
            }
            catch { selectedOption = -1; }

            // Resaltar selección: bordes en la opción seleccionada
            for (int i = 0; i < optionButtons.Length; i++)
            {
                var b = optionButtons[i];
                if (i == selectedOption)
                {
                    b.FlatAppearance.BorderSize = 3;
                    b.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 255, 120);
                }
                else
                {
                    b.FlatAppearance.BorderSize = 0;
                }
            }
        }

        private void BtnNext_Click(object? sender, EventArgs e)
        {
            // Comprobar respuesta seleccionada
            int selected = selectedOption;

            if (selected == -1)
            {
                MessageBox.Show("Por favor selecciona una opción antes de continuar.");
                return;
            }

            var q = questions[currentQuestionIndex];
            bool correcto = selected == q.CorrectIndex;
            if (correcto) score++;

            // Mostrar retroalimentación visual en el panel
            lblFeedback.Text = correcto ? "Correcto" : $"Incorrecto. Respuesta: {q.Options[q.CorrectIndex]}";
            lblFeedback.ForeColor = correcto ? Color.Green : Color.Red;
            lblFeedback.Visible = true;

            // Resaltar respuestas (opcional)
            optionButtons[q.CorrectIndex].ForeColor = Color.Green;
            if (!correcto) optionButtons[selected].ForeColor = Color.Red;

            // Deshabilitar opciones hasta que avance
            foreach (var rb in optionButtons) rb.Enabled = false;
            btnNext.Enabled = false;

            // Esperar un momento y luego avanzar (timer)
            feedbackTimer.Start();
        }

        // Timer: al terminar la espera avanzamos
        private void FeedbackTimer_Tick(object? sender, EventArgs e)
        {
            feedbackTimer.Stop();

            currentQuestionIndex++;
            if (currentQuestionIndex >= questions.Count)
            {
                // fin del nivel
                MessageBox.Show($"Nivel {currentLevel} terminado. Puntuación: {score}/{questions.Count}");
                EndLevel();
            }
            else
            {
                // Preparar siguiente pregunta
                btnNext.Enabled = true;
                lblFeedback.Visible = false;
                MostrarPreguntaActual();
            }
        }

        // Restaurar la UI al terminar un nivel
        private void EndLevel()
        {
            // Mostrar botones de nivel
            try { bntfacil.Visible = true; } catch { }
            try { bnmedio.Visible = true; } catch { }
            try { bndificil.Visible = true; } catch { }

            // Ocultar controles del quiz
            panelQuiz.Visible = false;
            lblQuestion.Visible = false;
            foreach (var rb in optionButtons) rb.Visible = false;
            btnNext.Visible = false;
            if (btnBack != null) btnBack.Visible = false;
            if (lblFeedback != null) lblFeedback.Visible = false;

            // Mostrar botón volver al menú principal cuando no se está dentro del panel del quiz
            if (btnBackMain != null) btnBackMain.Visible = true;
            if (btnReturnGameMenu != null) btnReturnGameMenu.Visible = false;
        }
        #endregion

        private void fmQuiz_Load(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object? sender, EventArgs e)
        {
            // Si estamos dentro de un nivel (panel visible) volvemos al menú del juego (niveles)
            try { feedbackTimer?.Stop(); } catch { }
            try
            {
                if (panelQuiz != null && panelQuiz.Visible)
                {
                    // Volver al menu del juego: restaurar botones de nivel y ocultar el panel
                    EndLevel();
                }
                else
                {
                    // Si el panel no está visible (ya en el menú del juego), cerrar para volver al menu principal
                    this.Close();
                }
            }
            catch
            {
                try { this.Close(); } catch { }
            }
        }

        private void fmQuiz_Load_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}