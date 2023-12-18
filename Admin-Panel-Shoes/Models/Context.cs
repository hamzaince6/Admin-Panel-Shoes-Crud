using Microsoft.EntityFrameworkCore;

namespace Admin_Panel_Shoes.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public Context()
        {
            
        }

        public DbSet<AdminLogin> AdminLogins { get; set; }
        public DbSet<Main> Mains { get; set; }
        public DbSet<MainSocialMediaIcon> MainSocialMediaIcons { get; set; }
        public DbSet<Products> ProductsEnumerable { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Customers> CustomersEnumerable { get; set; }
    }
}