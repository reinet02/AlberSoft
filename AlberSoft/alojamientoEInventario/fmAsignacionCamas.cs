using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace AsignarCamas
{
    public partial class fmAsignacionCamas : Form
    {
        // Representa el estado de una cama
        enum BedState { Libre, Ocupada, Mantenimiento, Reservada }

        // Representa una cama con sus propiedades y referencias UI
        #region clase bed
        class Bed
        {
            public int Id { get; set; }
            public BedState State { get; set; } = BedState.Libre;
            public string PersonName { get; set; } = string.Empty;
            public Panel PanelRef { get; set; }
            public Label LabelNumber { get; set; }
            public Label LabelState { get; set; }
        }
        #endregion

        // datos para serialización
        // serializacion : id, state, personName
        #region clase bedDto
        private class BedDto
        {
            public int Id { get; set; }
            public BedState State { get; set; }
            public string PersonName { get; set; } = string.Empty;
        }
        #endregion

        // Mapa de camas por id
        private readonly Dictionary<int, Bed> beds = new();
        private int? selectedBedId = null;

        // Ruta de guardado (AsignarCamas\beds.json)
        #region ruta guardado
        private readonly string saveFilePath;

        public fmAsignacionCamas()
        {
            InitializeComponent();

            var appFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "AsignarCamas");
            if (!Directory.Exists(appFolder)) Directory.CreateDirectory(appFolder);
            saveFilePath = Path.Combine(appFolder, "beds.json");
        }
        #endregion

        private void AsignacionCamas_Load(object? sender, EventArgs e)
        {
            // Lista de panels en el orden de 1..12
            var panelList = new List<Panel>
            {
                panel1, panel2, panel3, panel4,
                panel8, panel7, panel6, panel5,
                panel12, panel11, panel10, panel9
            };
            // La posición en la lista determina el número de cama (1..12)
            for (int i = 0; i < panelList.Count; i++)
            {
                int bedId = i + 1;
                var p = panelList[i];

                // Encuentra labels dentro del panel; el label con Y menor será el número, el otro el estado.
                var labels = p.Controls.OfType<Label>().OrderBy(l => l.Location.Y).ToArray();
                Label labelNumber = labels.Length > 0 ? labels[0] : new Label();
                Label labelState = labels.Length > 1 ? labels[1] : new Label();

                // Crear objeto Bed y almacenarlo
                var bed = new Bed
                {
                    Id = bedId,
                    PanelRef = p,
                    LabelNumber = labelNumber,
                    LabelState = labelState,
                    State = BedState.Libre
                };

                beds[bedId] = bed;

                // Asigna textos iniciales
                labelNumber.Text = $"Cama {bedId}";
                labelState.Text = $"{bed.State}";

                // Almacenar id en Tag y suscribir eventos de click
                p.Tag = bedId;
                p.Click += Panel_Click;

                // También suscribir a los controles hijos para capturar clicks
                foreach (Control c in p.Controls)
                    c.Click += Panel_Click;

                UpdatePanelUI(bedId);
            }

            lblCamaSelect.Text = "Ninguna cama seleccionada";
            textBox1.ReadOnly = true; // muestra nombre actual

            // Cargar datos persistidos si existen
            LoadBeds();
        }

        private void Panel_Click(object? sender, EventArgs e)
        {
            Control? src = sender as Control;
            if (src == null) return;

            // Si se clicó una etiqueta dentro del panel, subir al panel
            Panel? panel = src as Panel ?? src.Parent as Panel;
            if (panel == null) return;

            if (panel.Tag is not int bedId) return;
            SelectBed(bedId);
        }

        // Maneja la selección de una cama
        private void SelectBed(int bedId)
        {
            selectedBedId = bedId;
            var bed = beds[bedId];
            lblCamaSelect.Text = $"Cama seleccionada: {bedId}";
            textBox1.Text = bed.PersonName;
            comboBox1.SelectedIndex = (int)bed.State;
            // Indicar selección con un borde más grueso (resaltar)
            foreach (var b in beds.Values)
                b.PanelRef.BorderStyle = BorderStyle.FixedSingle;
            beds[bedId].PanelRef.BorderStyle = BorderStyle.Fixed3D;
        }

        // Actualizacion del panel según el estado de la cama
        private void UpdatePanelUI(int bedId)
        {
            var bed = beds[bedId];
            var p = bed.PanelRef;
            // Colores según estado
            p.BackColor = bed.State switch
            {
                BedState.Libre => Color.LightGreen,
                BedState.Ocupada => Color.IndianRed,
                BedState.Mantenimiento => Color.Khaki,
                BedState.Reservada => Color.LightBlue,
                _ => SystemColors.Control
            };
            // Actualizar label de estado y número (manteniendo centrado)
            if (bed.LabelNumber != null)
            {
                bed.LabelNumber.Text = $"Cama {bed.Id}";
                bed.LabelNumber.TextAlign = ContentAlignment.MiddleCenter;
                bed.LabelNumber.AutoSize = false;
            }
            if (bed.LabelState != null)
            {
                bed.LabelState.Text = bed.State.ToString();
                bed.LabelState.TextAlign = ContentAlignment.MiddleCenter;
                bed.LabelState.AutoSize = false;
            }
            // Si está ocupada mostrar nombre en tooltip
            if (!string.IsNullOrWhiteSpace(bed.PersonName))
                ToolTipFor(bed.PanelRef).SetToolTip(bed.PanelRef, $"Ocupante: {bed.PersonName}");
            else
                ToolTipFor(bed.PanelRef).SetToolTip(bed.PanelRef, $"{bed.State}");
        }

        // Reutilizable: ToolTip por panel (evita crear muchas instancias)
        private readonly Dictionary<Panel, ToolTip> tooltips = new();
        private ToolTip ToolTipFor(Panel p)
        {
            if (!tooltips.ContainsKey(p))
            {
                var tt = new ToolTip();
                tt.IsBalloon = false;
                tooltips[p] = tt;
            }
            return tooltips[p];
        }

        // Botón asignar: aplica estado y nombre (si aplica)
        private void btnAsignar_Click(object sender, EventArgs e)
        {
            if (selectedBedId is not int bedId)
            {
                MessageBox.Show("Seleccione una cama primero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var bed = beds[bedId];
            if (comboBox1.SelectedIndex < 0) return;
            var newState = (BedState)comboBox1.SelectedIndex;

            // Si se asigna como Ocupada, requerimos nombre en textBox2
            var nombre = textBox2.Text.Trim();
            if (newState == BedState.Ocupada && string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Ingrese el nombre de la persona para asignar la cama.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bed.State = newState;
            bed.PersonName = newState == BedState.Ocupada ? nombre : string.Empty;

            UpdatePanelUI(bedId);
            textBox1.Text = bed.PersonName;
            // Limpiar textBox2 después de asignar
            textBox2.Text = string.Empty;
            MessageBox.Show($"Cama {bedId} actualizada a '{bed.State}'.", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Guardar cambios inmediatamente
            SaveBeds();
        }

        // liberar cama (poner Libre y borrar nombre)
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (selectedBedId is not int bedId)
            {
                MessageBox.Show("Seleccione una cama primero.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var bed = beds[bedId];
            bed.State = BedState.Libre;
            bed.PersonName = string.Empty;
            UpdatePanelUI(bedId);
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.SelectedIndex = (int)BedState.Libre;
            MessageBox.Show($"Cama {bedId} liberada.", "Hecho", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Guardar cambios inmediatamente
            SaveBeds();
        }

        // Guardar al cerrar la ventana
        private void AsignacionCamas_FormClosing(object? sender, FormClosingEventArgs e)
        {
            SaveBeds();
        }

        // Serializa y guarda en disco
        #region guardar camas
        private void SaveBeds()
        {
            try
            {
                var dtoList = beds.Values.Select(b => new BedDto
                {
                    Id = b.Id,
                    State = b.State,
                    PersonName = b.PersonName
                }).ToList();

                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Converters = { new JsonStringEnumConverter() }
                };

                var json = JsonSerializer.Serialize(dtoList, options);
                File.WriteAllText(saveFilePath, json);
            }
            catch (Exception ex)
            {
                // No interrumpir la app, pero informar en caso de fallo de IO
                MessageBox.Show($"Error guardando datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        // Carga datos desde disco y aplica al estado actual de los objetos Bed (UI ya creada)
        #region cargar camas
        private void LoadBeds()
        {
            try
            {
                if (!File.Exists(saveFilePath)) return;

                var options = new JsonSerializerOptions
                {
                    Converters = { new JsonStringEnumConverter() }
                };

                var json = File.ReadAllText(saveFilePath);
                var dtoList = JsonSerializer.Deserialize<List<BedDto>>(json, options);
                if (dtoList == null) return;

                foreach (var dto in dtoList)
                {
                    if (!beds.ContainsKey(dto.Id)) continue;
                    var bed = beds[dto.Id];
                    bed.State = dto.State;
                    bed.PersonName = dto.PersonName ?? string.Empty;
                    UpdatePanelUI(dto.Id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando datos guardados: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion
    }
}
