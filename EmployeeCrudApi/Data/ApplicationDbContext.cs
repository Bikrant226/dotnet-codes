using EmployeeCrudApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCrudApi.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
