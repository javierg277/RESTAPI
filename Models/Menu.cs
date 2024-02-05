namespace CajeroAPI.Models
{
    public class Menu{
        private int id;
        private int IdAplicacion;
        private int IdEtiqueta;
        private int Posicion;
        private String Activo;
        private int nivel;
        private String parametro1;
        private String parametro2;
        private String logo;

        public Menu(int id, int idAplicacion, int idEtiqueta, int posicion, string activo, int nivel, string parametro1, string parametro2, string logo)
        {
            this.Id = id;
            IdAplicacion1 = idAplicacion;
            IdEtiqueta1 = idEtiqueta;
            Posicion1 = posicion;
            Activo1 = activo;
            this.Nivel = nivel;
            this.Parametro1 = parametro1;
            this.Parametro2 = parametro2;
            this.Logo = logo;
        }

        public int Id { get => id; set => id = value; }
        public int IdAplicacion1 { get => IdAplicacion; set => IdAplicacion = value; }
        public int IdEtiqueta1 { get => IdEtiqueta; set => IdEtiqueta = value; }
        public int Posicion1 { get => Posicion; set => Posicion = value; }
        public string Activo1 { get => Activo; set => Activo = value; }
        public int Nivel { get => nivel; set => nivel = value; }
        public string Parametro1 { get => parametro1; set => parametro1 = value; }
        public string Parametro2 { get => parametro2; set => parametro2 = value; }
        public string Logo { get => logo; set => logo = value; }
    }
}
