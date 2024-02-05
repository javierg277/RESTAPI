namespace CajeroAPI.Models
{
    public class Alertas{
        private int IdMaquina;
        private int EstadoAlerta;
        private int TipoIncidencia;
        private int Alerafecha;
        private int Alerahora;
        private String OBS;
        private DateTime FechaResolucion;
        private DateTime HoraResolucion;

        public Alertas(int idMaquina, int estadoAlerta, int tipoIncidencia, int alerafecha, int alerahora, string oBS, DateTime fechaResolucion, DateTime horaResolucion)
        {
            IdMaquina1 = idMaquina;
            EstadoAlerta1 = estadoAlerta;
            TipoIncidencia1 = tipoIncidencia;
            Alerafecha1 = alerafecha;
            Alerahora1 = alerahora;
            OBS1 = oBS;
            FechaResolucion1 = fechaResolucion;
            HoraResolucion1 = horaResolucion;
        }

        public int IdMaquina1 { get => IdMaquina; set => IdMaquina = value; }
        public int EstadoAlerta1 { get => EstadoAlerta; set => EstadoAlerta = value; }
        public int TipoIncidencia1 { get => TipoIncidencia; set => TipoIncidencia = value; }
        public int Alerafecha1 { get => Alerafecha; set => Alerafecha = value; }
        public int Alerahora1 { get => Alerahora; set => Alerahora = value; }
        public string OBS1 { get => OBS; set => OBS = value; }
        public DateTime FechaResolucion1 { get => FechaResolucion; set => FechaResolucion = value; }
        public DateTime HoraResolucion1 { get => HoraResolucion; set => HoraResolucion = value; }
    }
}
