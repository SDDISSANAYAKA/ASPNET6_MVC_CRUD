using ASPNET6_MVC_CRUD.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ASPNET6_MVC_CRUD.Data
{
    public class MVCDbContext : DbContext
    {
        public MVCDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
