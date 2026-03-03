using Microsoft.AspNetCore.Razor.TagHelpers;
using mini_erp.Components.Pages;
using mini_erp.Entities;

namespace mini_erp.Repositories
{
    public class EmployeeService : IRepository
    {
        private List<Employee> Employees = new List<Employee>()
            {
                new Employee { Name = "John Doe", Position = "Manager", Salary = 100f, Department = "Sales" },
                new Employee { Name = "Jane Smith", Position = "Developer", Salary = 50f, Department = "I+D" },
                new Employee { Name = "Emily Johnson", Position = "Designer", Salary = 10f, Department = "Marketing" }
            };
        public List<Employee> GetEmployees()
        {
            return Employees;
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
                Department = empleado.Department
            });
        }

    }
}
