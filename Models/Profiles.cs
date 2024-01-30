namespace CajeroAPI.Models
{
    public class Profiles
    {

        private int id;
        private string Description;
        private int status;

        public Profiles(int id, string description, int status)
        {
            this.id = id;
            Description = description;
            this.status = status;
        }

        public int Id { get => id; set => id = value; }
        public string Description1 { get => Description; set => Description = value; }
        public int Status { get => status; set => status = value; }
    }
    
}
