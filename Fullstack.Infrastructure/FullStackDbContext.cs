using FullStack.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fullstack.Infrastructure
{
    public class FullStackDbContext:DbContext
    {
        public FullStackDbContext(DbContextOptions<FullStackDbContext> options):base(options)
        {
            
        }

        public DbSet<Employee> Employees{ get; set; }

    }
    
}
