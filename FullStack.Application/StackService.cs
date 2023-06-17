using FullStack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStack.Application
{
    public class StackService : FStackService
    {
        private readonly FStackRepository _fStackRepository;

        public StackService(FStackRepository fStackRepository)
        {
            _fStackRepository = fStackRepository;
        }

        public Employee CreateEmployee(Employee employee)
        {
            _fStackRepository.CreateEmployee(employee);
            return employee;
        }

        public List<Employee> GetAllEmployees()
        {
            var employees=_fStackRepository.GetAllEmployees();
            return employees;
        }
    }
}
