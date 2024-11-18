using Entities.Concrete.TableModels;
using Entities.Concrete.TableModels.Membership;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace DataAccess.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, int, ApplicationUserLogin, ApplicationUserRole, ApplicationUserClaim, ApplicationUserToken, ApplicationRoleClaim>
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
