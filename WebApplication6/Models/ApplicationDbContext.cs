using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace WebApplication6.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", false)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}