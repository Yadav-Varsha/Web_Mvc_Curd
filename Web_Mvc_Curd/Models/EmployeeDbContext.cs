using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Web_Mvc_Curd.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext(DbContextOptions options): base(options)
        
        {
            
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
