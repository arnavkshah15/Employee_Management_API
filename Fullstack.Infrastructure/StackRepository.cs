using FullStack.Application;
using FullStack.Domain;
using System;
using System.Collections.Generic;
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
    }
}
