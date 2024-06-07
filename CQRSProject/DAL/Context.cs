using Microsoft.EntityFrameworkCore;

namespace CQRSProject.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-17Q1DFV\\SQLEXPRESS; initial Catalog = DbCqrs; integrated Security = true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
