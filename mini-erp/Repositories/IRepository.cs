using mini_erp.Entities;

namespace mini_erp.Repositories
{
    public interface IRepository
    {

        List<Employee> GetEmployees();
        void DeleteEmployee(Employee emp);
        void AddEmployee(Employee emp);
    }
}
