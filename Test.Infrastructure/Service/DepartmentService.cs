using System.Net;
using Test.Application.Interfaces;
using Test.Models.Models;

namespace Test.Infrastructure.Service
{
    public class DepartmentService : IDepartmentsService
    {
        private readonly IDepartmentsRepo _departmentsRepo;
        public DepartmentService(IDepartmentsRepo departmentsRepo)
        {
            _departmentsRepo = departmentsRepo;
        }

        public ResultDto CreateDepartment(DepartmentsMst NewDepartment)
        {
            var data = _departmentsRepo.CreateDepartment(NewDepartment);

            return new ResultDto()
            {
                Details = data,
                Result = true,
                ResultMessage = "Success",
                Status = HttpStatusCode.OK
            };
        }

        public ResultDto GetAllDepartments()
        {
            var data = _departmentsRepo.GetAllDepartments();
            return new ResultDto()
            {
                Details = data,
                Result = true,
                ResultMessage = "Success",
                Status = HttpStatusCode.OK
            };
        }

        public ResultDto GetDepartmentById(int DepartmentId)
        {
            var data = _departmentsRepo.GetDepartmentById(DepartmentId);
            return new ResultDto()
            {
                Details = data,
                Result = true,
                ResultMessage = "Success",
                Status = HttpStatusCode.OK
            };
        }

        public ResultDto UpdateDepartment(DepartmentsMst NewDepartment)
        {
            var data = _departmentsRepo.UpdateDepartment(NewDepartment);
            return new ResultDto()
            {
                Details = data,
                Result = true,
                ResultMessage = "Success",
                Status = HttpStatusCode.OK
            };
        }
    }
}
