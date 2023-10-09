using APIProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIProject.Services.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAllEmployees();
        Task<Employee> GetEmployeesById(int id);
        List<Employee> GetEmployeesByDepartment(string department);
        Employee CreateEmployee(Employee employee);
        Employee UpdateEmployee(Employee employee);
        void DeleteEmployee(int id);
        List<Employee> GetEmployeesWhere(IEnumerable<Employee> source, Func<Employee, bool> WhereExp);
    }
}
