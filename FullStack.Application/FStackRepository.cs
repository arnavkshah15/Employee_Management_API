using FullStack.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStack.Application
{
    public interface FStackRepository
    {
        List<Employee> GetAllEmployees();
    }
}
