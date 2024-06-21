

using Shop.DAL.Core;

namespace SchoolApp.DAL.Core
{
    public class Person : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set;}
        public string? Phone { get; set;}
        public string? Email { get; set;}

    }
}
