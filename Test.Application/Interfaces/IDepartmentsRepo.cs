using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Models.Models;

namespace Test.Application.Interfaces
{
    public interface IDepartmentsRepo
    {
        public IEnumerable<DepartmentsMst> GetAllDepartments();
        public DepartmentsMst GetDepartmentById(int DepartmentId);
        public OutputDto CreateDepartment(DepartmentsMst NewDepartment);
        public OutputDto UpdateDepartment(DepartmentsMst NewDepartment);
    }
}
