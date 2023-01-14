using Test.Application.Interfaces;

namespace Test.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {

        public IDepartmentsService DepartmentsService { get; }

        public UnitOfWork(IDepartmentsService departmentsService )
        {

            this.DepartmentsService = departmentsService;
        }

    }
}
