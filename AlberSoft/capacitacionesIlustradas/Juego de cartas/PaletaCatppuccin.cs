using System;
using System.Collections.Generic;
using System.Drawing;

namespace AlberSoft.capacitacionesIlustradas.Juego_de_cartas
{
    internal static class PaletaCatppuccin
    {
        // Colores de la paleta "Mocha" (valores hex extraídos de la paleta oficial)
        private static readonly string[] hexMocha = new[]
        {
            "#F5E0DC", // rosewater
            "#F2CDCD", // flamingo
            "#F5C2E7", // pink
            "#CBA6F7", // mauve
            "#F38BA8", // red
            "#EBA0AC", // maroon
            "#FAB387", // peach
            "#F9E2AF", // yellow
            "#A6E3A1", // green
            "#94E2D5", // teal
            "#89DCEB", // sky
            "#74C7EC", // sapphire
            "#89B4FA", // blue
            "#B4BEFE", // lavender
            "#CDD6F4", // text
            "#BAC2DE", // subtext1
        };

        private static readonly List<Color> palette;

        static PaletaCatppuccin()
        {
            palette = new List<Color>(hexMocha.Length);
            foreach (var h in hexMocha)
            {
                try { palette.Add(ColorTranslator.FromHtml(h)); } catch { palette.Add(Color.Magenta); }
            }
        }

        public static Color ColorParaCarta(int id)
        {
            if (palette.Count == 0) return Color.White;
            int idx = Math.Abs(id) % palette.Count;
            return palette[idx];
        }

        // Indica si un color de la paleta corresponde a "overlay0" o a un tono más oscuro
        // (según la posición en la lista `palette`). Se usa para decidir si el texto debe
        // dibujarse en color claro (p. ej. blanco) para mantener contraste.
        public static bool NecesitaTextoClaro(Color color)
        {
            if (palette == null || palette.Count == 0) return false;

            // buscar índice de overlay0 en la paleta
            int idxOverlay0 = -1;
            for (int i = 0; i < palette.Count; i++)
            {
                // overlay0 hex: #6C7086
                if (palette[i].ToArgb() == ColorTranslator.FromHtml("#6C7086").ToArgb())
                {
                    idxOverlay0 = i;
                    break;
                }
            }

            // buscar índice del color proporcionado
            int idxColor = palette.FindIndex(c => c.ToArgb() == color.ToArgb());

            if (idxColor >= 0)
            {
                if (idxOverlay0 >= 0)
                {
                    return idxColor >= idxOverlay0;
                }

                // Si overlay0 no está en la paleta (se eliminaron colores),
                // considerar como "oscuro" cualquiera en el tramo más oscuro de la paleta.
                // Usamos el 60% superior (los colores con índice más alto) como referencia.
                int umbralIdx = Math.Max(0, (int)Math.Floor(palette.Count * 0.6));
                return idxColor >= umbralIdx;
            }

            // fallback final: usar luminancia si no se pudo determinar por índice
            double luminancia = 0.299 * color.R + 0.587 * color.G + 0.114 * color.B;
            return luminancia <= 115.0;
        }

        public static Color ColorParaTexto(string key)
        {
            if (string.IsNullOrEmpty(key)) return ColorParaCarta(0);
            int hash = key.GetHashCode();
            int idx = Math.Abs(hash) % palette.Count;
            return palette[idx];
        }

        public static IReadOnlyList<Color> ObtenerPaletaMocha() => palette.AsReadOnly();
    }
}
