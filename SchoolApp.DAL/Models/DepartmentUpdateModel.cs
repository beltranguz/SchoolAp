
namespace SchoolApp.DAL.Models
{
    public class DepartmentUpdateModel : ModelBase
    {
        public int DepartmentId { get; set; }
        public DateTime ModifyDate { get; set; }
        public int ModifyUser {  get; set; }

    }
}
