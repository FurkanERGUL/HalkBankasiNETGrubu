using APIProject.Entities;
using APIProject.Repository.Abstract;
using APIProject.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIProject.Services.Concrete
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepo _empRepo;
        public EmployeeService(IEmployeeRepo empRepo)
        {
            _empRepo = empRepo;
        }

        public Employee CreateEmployee(Employee employee)
        {
            if (employee is not null)
            return _empRepo.CreateEmployee(employee);   
            else
            throw new Exception("Employee null olamaz");
        }

        public void DeleteEmployee(int id)
        {
            if (id != 0)
            _empRepo.Delete(id);
            else
            throw new Exception("Silme işleminde id boş olamaz.");
        }

        public List<Employee> GetAllEmployees()
        {
            return _empRepo.GetAll();
        }

        public List<Employee> GetEmployeesByDepartment(string department)
        {
            if (department!=null)
                return _empRepo.GetEmployeeByDepartment(department);
            else
                throw new Exception("Departman ismi boş olamaz");
            
            
        }

        public Task<Employee> GetEmployeesById(int id)
        {
            if (id > 0)
                return _empRepo.GetEmployeeById(id);
            else
                throw new Exception("Id boş olamaz");
        }

        public List<Employee> GetEmployeesWhere(IEnumerable<Employee> source, Func<Employee, bool> WhereExp)
        {
            var data = source.Where(WhereExp);
            return data.ToList();
        }

        public Employee UpdateEmployee(Employee employee)
        {
            return _empRepo.UpdateEmployee(employee);
        }
    }
}
