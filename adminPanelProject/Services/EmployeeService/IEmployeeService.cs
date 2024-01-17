using adminPanelProject.Entity;
using adminPanelProject.Models.Employee;

namespace adminPanelProject.Services.EmployeeService
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetAllEmployeeAsync();

        Task<List<Employee>> AddEmployee(EmployeePost employee);


    }
}
