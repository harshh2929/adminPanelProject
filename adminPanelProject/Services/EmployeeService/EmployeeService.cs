using adminPanelProject.Data;
using adminPanelProject.Entity;
using adminPanelProject.Models.Employee;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace adminPanelProject.Services.EmployeeService
{
    public class EmployeeService : IEmployeeService
    {
        private readonly DataContext _context;
        public EmployeeService(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Employee>> GetAllEmployeeAsync()
        {
            var employee = await _context.Employees.ToListAsync();

            return employee;
        }


        public async Task<List<Employee>> AddEmployee(EmployeePost employee)
        {
            var Adminobject = new Employee
            {
                Name = employee.Name,
                Salary = employee.Salary,
                Performance = employee.Performance,
                Address = employee.Address,
                Mobile = (long)employee.Mobile,
            };
            _context.Employees.Add(Adminobject);
            await _context.SaveChangesAsync();
            return await _context.Employees.ToListAsync();
        }
    }
}
