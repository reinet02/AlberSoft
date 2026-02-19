using System;
using System.Collections.Generic;
using System.Linq;

namespace AlberSoft.capacitacionesIlustradas.Juego_de_cartas
{
    public class Mazo
    {
        private List<Carta> cartas;
        private Random rnd = new Random();

        public Mazo(IEnumerable<Carta>? inicial = null)
        {
            cartas = inicial?.ToList() ?? new List<Carta>();
        }

        public void Barajar() => cartas = cartas.OrderBy(_ => rnd.Next()).ToList();
        public void Agregar(Carta c) => cartas.Add(c);
        public Carta? Robar()
        {
            if (cartas.Count == 0) return null;
            // Robar una carta cualquiera (índice aleatorio) para evitar patrones predecibles
            int idx = rnd.Next(cartas.Count);
            var c = cartas[idx];
            cartas.RemoveAt(idx);
            return c;
        }
        public int Cantidad => cartas.Count;

        // Devuelve y vacía todas las cartas almacenadas en este mazo.
        public List<Carta> Vaciar()
        {
            var copia = cartas.ToList();
            cartas.Clear();
            return copia;
        }
    }
}
