using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Admin_Panel_Shoes.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }


        public DbSet<AdminLogin> AdminLogins { get; set; }
        public DbSet<Main> Mains { get; set; }
        public DbSet<Products> ProductsEnumerable { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Customers> CustomersEnumerable { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<FormLogin> FormLogin { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}