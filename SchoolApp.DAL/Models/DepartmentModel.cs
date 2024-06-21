

namespace SchoolApp.DAL.Models
{
    public class DepartmentModel : ModelBase
    {
        public int DepartmentId { get; set; }

        public DateTime CreationDate { get; set; }
        public int CreateUser { get; set; }

    }
}
