using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AlberSoft.alojamientoEInventario
{
    public partial class TutorialCrucigrama : Form
    {
        private Bitmap[] tutorialImages;
        private int currentImageIndex = 0;

        public TutorialCrucigrama()
        {
            InitializeComponent();
            InitializeTutorialImages();

            // Los manejadores de Click ya están asignados en el Designer; sólo ajustar visibilidades

            // Visibilidades iniciales
            btnAtras.Visible = false;
            btnVolver.Visible = false;

            // Mostrar la primera imagen
            ShowImage(0);
        }

        private void InitializeTutorialImages()
        {
            // Elegir 5 imágenes del recursos
            tutorialImages = new Bitmap[]
            {
                AlberSoft.Properties.Resources.IntroCrucigrama,
                AlberSoft.Properties.Resources.SeleccioneCrucigrama,
                AlberSoft.Properties.Resources.JugabilidadPCrucigrama,
                AlberSoft.Properties.Resources.BotonesCrucigrama,
                AlberSoft.Properties.Resources.GraciasCrucigrama
            };
        }

        private void ShowImage(int index)
        {
            if (tutorialImages == null || tutorialImages.Length == 0) return;
            if (index < 0) index = 0;
            if (index >= tutorialImages.Length) index = tutorialImages.Length - 1;

            currentImageIndex = index;
            pctInformacion.Image = tutorialImages[index];

            // Ajustar estado de botones (visibilidad según índice)
            btnAtras.Visible = currentImageIndex > 0;
            btnSiguiente.Visible = currentImageIndex < tutorialImages.Length - 1;
            // Mostrar el botón Volver sólo en la última imagen
            btnVolver.Visible = currentImageIndex == tutorialImages.Length - 1;
        }

        private void btnSiguiente_Click(object? sender, EventArgs e)
        {
            ShowImage(currentImageIndex + 1);
        }

        private void btnAtras_Click(object? sender, EventArgs e)
        {
            ShowImage(currentImageIndex - 1);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
