

namespace SchoolApp.DAL.Models
{
    public class ModelBase
    {
        public string? Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator { get; set; }
    }
}
