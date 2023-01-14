namespace Test.Application.Interfaces
{
    public interface IUnitOfWork
    {
        public IDepartmentsService DepartmentsService { get; }
    }
}
