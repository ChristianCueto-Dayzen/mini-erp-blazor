// Este código define la clase EmployeeService, encargada de manejar las operaciones relacionadas con los empleados.
// Implementa la interfaz IRepository, lo que permite una separación entre la definición de las operaciones
// y su implementación concreta.

using mini_erp.Entities;

namespace mini_erp.Repositories
{
    public class EmployeeService : IRepository
    {
        private List<Employee> Employees = new List<Employee>()
            {
                //Aqui se obtendrían los datos de la base de datos.
                new Employee { Name = "John Doe", Position = "Manager", Salary = 100, Email = "jdoe@domain.com" },
                new Employee { Name = "Jane Smith", Position = "Developer", Salary = 50, Email = "jsmith@domain.com" },
                new Employee { Name = "Emily Johnson", Position = "Designer", Salary = 10, Email = "ejohnson@domain.com" }
            };
        public List<Employee> GetEmployees()        
        {
            return Employees; //Devuelve la lista de empleados almacenada en memoria.
        }
        public List<Employee> SearchEmployees(EmployeeSearch emp)
        {
            List<Employee> searchResults = new List<Employee>();
            return emp.getOption() switch
            {
                "Name" => Employees.Where(e => e.Name.Contains(emp.getInput(), StringComparison.OrdinalIgnoreCase)).ToList(),
                "Position" => Employees.Where(e => e.Position.Contains(emp.getInput(), StringComparison.OrdinalIgnoreCase)).ToList(),
                "Email" => Employees.Where(e => e.Email.Contains(emp.getInput(), StringComparison.OrdinalIgnoreCase)).ToList(),
                _ => Employees
            };
        }
        public void DeleteEmployee(Employee employee)
        {
            Employees.Remove(employee);      
        }
        public void AddEmployee(Employee empleado)
        {
            Employees!.Add(new Employee
            {
                Name = empleado.Name,
                Position = empleado.Position,
                Salary = empleado.Salary,
                Email = empleado.Email
            });
        }

    }
}
