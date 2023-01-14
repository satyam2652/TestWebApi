using Test.Models.Models;

namespace Test.Application.Interfaces
{
    public interface IDepartmentsService
    {
        public ResultDto GetAllDepartments();
        public ResultDto GetDepartmentById(int DepartmentId);
        public ResultDto CreateDepartment(DepartmentsMst NewDepartment);
        public ResultDto UpdateDepartment(DepartmentsMst NewDepartment);
    }
}
