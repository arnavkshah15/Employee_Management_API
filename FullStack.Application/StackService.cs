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

        public Employee GetEmployee(Guid id)
        {
            var employee=_fStackRepository.GetEmployee(id);
            return employee;
        }
        public Employee UpdateEmployee(Guid id, Employee updateEmployeeRequest)
        {
            var employee= _fStackRepository.UpdateEmployee(id, updateEmployeeRequest);
            return employee;
        }
    }
}
