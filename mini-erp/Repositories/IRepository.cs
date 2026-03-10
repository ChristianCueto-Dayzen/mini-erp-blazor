// Bridge pattern: IRepository es la interfaz que define las operaciones para manejar empleados,
// y EmployeeService es la implementación concreta de esa interfaz.
// Esto permite separar la lógica de negocio (EmployeeService) de la definición de las operaciones (IRepository),
// facilitando el mantenimiento y la escalabilidad del código.

using mini_erp.Entities;

namespace mini_erp.Repositories
{
    public interface IRepository
    {
        List<Employee> GetEmployees();
        void DeleteEmployee(Employee emp);
        void AddEmployee(Employee emp);
        List<Employee> SearchEmployees(string sOption, string searchInput);
    }
}