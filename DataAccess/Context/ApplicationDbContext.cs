using Entities.Concrete.TableModels;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = Localhost; Initial Catalog = CodinariumFinalProjecDb; Integrated Security = true; Trust Server Certificate = true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CheckOut> Checkouts { get; set; }
        public DbSet<ShoppingCard> ShoppingCards { get; set; }
    }
}
