using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AlberSoft.capacitacionesIlustradas.Juego_de_cartas
{
    internal static class RecordsManager
    {
        private static readonly string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "AlberSoft", "capacitacionesIlustradas");
        private static readonly string file = Path.Combine(folder, "records.json");

        private static Dictionary<int, int> CargarDatos()
        {
            try
            {
                if (!File.Exists(file)) return new Dictionary<int, int>();
                var txt = File.ReadAllText(file);
                return JsonSerializer.Deserialize<Dictionary<int, int>>(txt) ?? new Dictionary<int, int>();
            }
            catch { return new Dictionary<int, int>(); }
        }

        private static void GuardarDatos(Dictionary<int, int> datos)
        {
            try
            {
                Directory.CreateDirectory(folder);
                var txt = JsonSerializer.Serialize(datos);
                File.WriteAllText(file, txt);
            }
            catch { }
        }

        public static int? GetRecord(int nivel)
        {
            var d = CargarDatos();
            if (d.TryGetValue(nivel, out var v)) return v;
            return null;
        }

        public static bool UpdateRecordIfBetter(int nivel, int segundos)
        {
            var d = CargarDatos();
            if (d.TryGetValue(nivel, out var actual))
            {
                if (segundos < actual)
                {
                    d[nivel] = segundos;
                    GuardarDatos(d);
                    return true;
                }
                return false;
            }
            else
            {
                d[nivel] = segundos;
                GuardarDatos(d);
                return true;
            }
        }
    }
}
