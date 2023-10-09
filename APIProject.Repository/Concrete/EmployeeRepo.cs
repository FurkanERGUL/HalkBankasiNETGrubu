using APIProject.Entities;
using APIProject.Repository.Abstract;
using APIProject.Repository.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIProject.Repository.Concrete
{
    public class EmployeeRepo : IEmployeeRepo
    {
        private readonly AppDbContext _dbContext;

        public EmployeeRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Employee CreateEmployee(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            _dbContext.SaveChanges();
            return employee;
        }

        public void Delete(int id)
        {
            var employee = _dbContext.Employees.Find(id);
            if (employee!=null)
            {
                _dbContext.Employees.Remove(employee);
                _dbContext.SaveChanges();
            }
        }

        public List<Employee> GetAll()
        {
            return _dbContext.Employees.ToList();
        }

        public List<Employee> GetEmployeeByDepartment(string department)
        {
            return _dbContext.Employees.Where(d=>d.Department.ToLower().Contains(department.ToLower())).ToList();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _dbContext.Employees.FindAsync(id);
        }

        public Employee UpdateEmployee(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            _dbContext.SaveChanges(true);
            return employee;
        }
    }
}
