

using SchoolApp.DAL.Models;

namespace SchoolApp.DAL.Interfaces
{
    public interface IDepartmentDb
    {
        List<DepartmentModel> GetDepartments();
        DepartmentModel GetDepartment(int departmentId);

        void SaveDepartment(DepartmentAddModel departmentAdd);
        void UpdateDepartment(DepartmentUpdateModel departmentAdd);
        void RemoveDepartment(DepartmentRemoveModel departmentAdd);
    }

}