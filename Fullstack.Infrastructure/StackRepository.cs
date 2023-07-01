using FullStack.Application;
using FullStack.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullstack.Infrastructure
{
    public class StackRepository : FStackRepository
    {
       
        private readonly FullStackDbContext _fullStackDbContext;

        public StackRepository(FullStackDbContext fullStackDbContext)
        {
            _fullStackDbContext = fullStackDbContext;
        }

        public Employee CreateEmployee(Employee employee)
        {
            employee.Id=Guid.NewGuid();
            _fullStackDbContext.Employees.Add(employee);
            _fullStackDbContext.SaveChanges();
            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
            return _fullStackDbContext.Employees.ToList();
        }

        public  Employee GetEmployee(Guid id)
        {
           
            var employee = _fullStackDbContext.Employees.FirstOrDefault(x => x.Id == id);
            employee.Id = id;
            if (employee == null)
            {
                return null;
            }
            return employee;
        }
        
        public Employee UpdateEmployee(Guid id,Employee updateEmployeeRequest) {
            var employee = _fullStackDbContext.Employees.Find(id);
            if (employee == null)
            {
                return null;
            }
            employee.Name=updateEmployeeRequest.Name;
            employee.Email = updateEmployeeRequest.Email;
            employee.Phone = updateEmployeeRequest.Phone;
            employee.Salary = updateEmployeeRequest.Salary;
            employee.Department = updateEmployeeRequest.Department;
            _fullStackDbContext.SaveChanges();

            return employee;
        }

        public Employee DeleteEmployee(Guid id)
        {
            var employee = _fullStackDbContext.Employees.Find(id);
            if (employee == null)
            {
                return null;
            }
            _fullStackDbContext.Employees.Remove(employee);
            _fullStackDbContext.SaveChanges();
            return employee;
        }

    }
}
