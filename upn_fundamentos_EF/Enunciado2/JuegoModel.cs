namespace upn_fundamentos_EF.Enunciado2
{
    public class JuegoModel
    {
        public string f_Nombre { get; set; }
        public int f_Puntaje { get; set; }
        public bool f_Victoria { get; set; }

        public JuegoModel(string f_nombre, int f_puntaje, bool f_victoria)
        {
            f_Nombre = f_nombre;
            f_Puntaje = f_puntaje;
            f_Victoria = f_victoria;
        }

        public string f_VictoriaTexto => f_Victoria ? "Ganado" : "Perdido";
    }
}
