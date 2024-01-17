using adminPanelProject.Entity;
using adminPanelProject.Models.Login;
using adminPanelProject.Models.Signup;
using Microsoft.EntityFrameworkCore;

namespace adminPanelProject.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=adminPanelProject;Trusted_Connection=true;TrustServerCertificate=true;");
        }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Signup> Signup { get; set; }
        public DbSet<Login> Login { get; set; }

    }
}
