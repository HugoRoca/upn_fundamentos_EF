namespace upn_fundamentos_EF.Enunciado2
{
    public class JuegoModel
    {
        public string Nombre { get; set; }
        public int Puntaje { get; set; }
        public bool Victoria { get; set; }

        public JuegoModel(string nombre, int puntaje, bool victoria)
        {
            Nombre = nombre;
            Puntaje = puntaje;
            Victoria = victoria;
        }

        public string VictoriaTexto => Victoria ? "Ganado" : "Perdido";
    }
}
