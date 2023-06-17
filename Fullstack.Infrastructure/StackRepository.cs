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
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee{Id=Guid.NewGuid(),Name="Aarav",Email="aarav@gmail.com",Phone=9998887766,Salary=123456,Department="Chemistry"},
            new Employee{Id=Guid.NewGuid(),Name="Arnav",Email="arnav@gmail.com",Phone=9998887765,Salary=123459,Department="Computer"}
        };
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
    }
}
