
using Shop.DAL.Core;

namespace SchoolApp.DAL.Entities
{
    public class Departament : BaseEntity
    {
        public int DepartamentId { get; set; }
        public string? Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator {  get; set; }

    }
}
