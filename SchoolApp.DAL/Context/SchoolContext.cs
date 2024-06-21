
using Microsoft.EntityFrameworkCore;
using SchoolApp.DAL.Entities;

namespace SchoolApp.DAL.Context
{
    public class SchoolContext : DbContext
    {
        #region"Constructor"
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {

        }
        #endregion
        #region"DbSets"
        public DbSet<Departament> Deparments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        #endregion
    }
}
