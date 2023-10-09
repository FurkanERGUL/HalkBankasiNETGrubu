using APIProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIProject.Repository.Abstract
{
    public interface IEmployeeRepo
    {
        public Employee CreateEmployee(Employee employee);
        public Employee UpdateEmployee(Employee employee);
        public void Delete(int id);
        public Task<Employee> GetEmployeeById(int id);
        public List<Employee> GetEmployeeByDepartment(string department);
        public List<Employee> GetAll();
        //
    }
}
