using Microsoft.EntityFrameworkCore;

namespace AjaxProject.DAL
{
    public class Context:DbContext
    {
        protected readonly IConfiguration _configuration;

        public Context(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
        }
        public DbSet<Employee> Employees { get; set; }
    }
}