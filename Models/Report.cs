namespace CajeroAPI.Models
{
    public class Report
    {
        private String name_report;
        private String description;
        private String url_template;
        private String sql_criteria;

        public Report(int id, string name_report, string description, string url_template, string sql_criteria)
        {
            this.Id = id;
            this.Name_report = name_report;
            this.Description = description;
            this.Url_template = url_template;
            this.Sql_criteria = sql_criteria;
        }

        public int Id { get; set; }
        public string Name_report { get => name_report; set => name_report = value; }
        public string Description { get => description; set => description = value; }
        public string Url_template { get => url_template; set => url_template = value; }
        public string Sql_criteria { get => sql_criteria; set => sql_criteria = value; }
    }
}
