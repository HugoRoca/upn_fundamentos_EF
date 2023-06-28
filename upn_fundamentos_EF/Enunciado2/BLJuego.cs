using System.Collections.Generic;
using System.IO;

namespace upn_fundamentos_EF.Enunciado2
{
    public class BLJuego
    {
        private const string FileName = "base_de_informacion.txt";
        private List<JuegoModel> juegos = new List<JuegoModel>();
        private int puntajeTotal = 0;

        public void LoadGameData()
        {
            if (File.Exists(FileName))
            {
                using (StreamReader reader = new StreamReader(FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        if (parts.Length == 3)
                        {
                            string gameName = parts[0];
                            int punt = int.Parse(parts[1]);
                            bool victoria = bool.Parse(parts[2]);

                            JuegoModel juego = new JuegoModel(gameName, punt, victoria);
                            juegos.Add(juego);
                            puntajeTotal += victoria ? 100 : -20;
                        }
                    }
                }
            }
        }

        public List<JuegoModel> ObtenerJuegos()
        {
            return juegos;
        }

        public int ObtenerPuntos()
        {
            return puntajeTotal;
        }

        public void AsignarPuntos(int puntos)
        {
            puntajeTotal += puntos;
        }

        public void GuardarJuego(JuegoModel juego)
        {
            using (StreamWriter writer = new StreamWriter(FileName, true, encoding: System.Text.Encoding.UTF8))
            {
                writer.WriteLine(juego.Nombre + "," + juego.Puntaje + "," + juego.Victoria);
            }
        }
    }
}
