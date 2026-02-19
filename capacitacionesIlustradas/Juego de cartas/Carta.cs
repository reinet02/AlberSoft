using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace AlberSoft.capacitacionesIlustradas.Juego_de_cartas
{
    public class Carta
    {
        public int Id { get; }
        public string Nombre { get; }
        public Image? Imagen { get; }

        public Carta(int id, string nombre, Image? imagen)
        {
            Id = id;
            Nombre = nombre;
            Imagen = imagen;
        }

        public override string ToString() => Nombre;
    }
}
