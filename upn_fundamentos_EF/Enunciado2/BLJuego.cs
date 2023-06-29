using System.Collections.Generic;
using System.IO;

namespace upn_fundamentos_EF.Enunciado2
{
    public class BLJuego
    {
        private const string f_FileName = "base_de_informacion.txt";
        private List<JuegoModel> f_juegos = new List<JuegoModel>();
        private int f_puntajeTotal = 0;

        public void CargarDatos()
        {
            if (!File.Exists(f_FileName)) return;
            using (StreamReader f_reader = new StreamReader(f_FileName))
            {
                string f_line;
                while ((f_line = f_reader.ReadLine()) != null)
                {
                    string[] f_parts = f_line.Split(',');
                    if (f_parts.Length == 3)
                    {
                        string f_gameName = f_parts[0];
                        int f_punt = int.Parse(f_parts[1]);
                        bool f_victoria = bool.Parse(f_parts[2]);

                        JuegoModel f_juego = new JuegoModel(f_gameName, f_punt, f_victoria);
                        f_juegos.Add(f_juego);
                        f_puntajeTotal += f_victoria ? 100 : -20;
                    }
                }
            }
        }

        public List<JuegoModel> ObtenerJuegos()
        {
            return f_juegos;
        }

        public int ObtenerPuntos()
        {
            return f_puntajeTotal;
        }

        public void AsignarPuntos(int f_puntos)
        {
            f_puntajeTotal += f_puntos;
        }

        public void GuardarJuego(JuegoModel f_juego)
        {
            using (StreamWriter f_writer = new StreamWriter(f_FileName, true,
                encoding: System.Text.Encoding.UTF8))
            {
                f_writer.WriteLine(f_juego.f_Nombre + "," + f_juego.f_Puntaje + "," + f_juego.f_Victoria);
            }
        }
    }
}
