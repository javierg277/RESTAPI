namespace CajeroAPI.Models
{
    public class Report_Criteria{
        private int id;
        private string Type;
        private string Operator;
        private string Description;
        private string sql;
        private string SQL_SOURCE;
        private int ID_Report;
        private int Order_Number;

        public Report_Criteria(int id, string type, string @operator, string description, string sql, string sQL_SOURCE, int iD_Report, int order_Number)
        {
            this.Id = id;
            Type1 = type;
            Operator1 = @operator;
            Description1 = description;
            this.Sql = sql;
            SQL_SOURCE1 = sQL_SOURCE;
            ID_Report1 = iD_Report;
            Order_Number1 = order_Number;
        }

        public int Id { get => id; set => id = value; }
        public string Type1 { get => Type; set => Type = value; }
        public string Operator1 { get => Operator; set => Operator = value; }
        public string Description1 { get => Description; set => Description = value; }
        public string Sql { get => sql; set => sql = value; }
        public string SQL_SOURCE1 { get => SQL_SOURCE; set => SQL_SOURCE = value; }
        public int ID_Report1 { get => ID_Report; set => ID_Report = value; }
        public int Order_Number1 { get => Order_Number; set => Order_Number = value; }
    }

}
