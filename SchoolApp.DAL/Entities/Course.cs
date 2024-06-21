using Shop.DAL.Core;

namespace SchoolApp.DAL.Entities
{
    public  class Course : BaseEntity
    {
        public int CourseID { get; set; }
        public string? Title { get; set; }

        public int Credits { get; set; }

        public int DepartmentID { get; set; }
    }
}
