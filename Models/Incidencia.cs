namespace CajeroAPI.Models
{
    public class Incidencia{
        private int IdIncidencia;
        private String Description;
        private String Contacto;
        private String Email;
        private int telefono;
        private int tipo;

        public Incidencia(int idIncidencia, string description, string contacto, string email, int telefono, int tipo)
        {
            IdIncidencia1 = idIncidencia;
            Description1 = description;
            Contacto1 = contacto;
            Email1 = email;
            this.Telefono = telefono;
            this.Tipo = tipo;
        }

        public int IdIncidencia1 { get => IdIncidencia; set => IdIncidencia = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string Contacto1 { get => Contacto; set => Contacto = value; }
        public string Email1 { get => Email; set => Email = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
