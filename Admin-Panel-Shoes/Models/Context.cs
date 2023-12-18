using Microsoft.EntityFrameworkCore;

namespace Admin_Panel_Shoes.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<AdminLogin> AdminLogins { get; set; }
        public DbSet<Main> Mains { get; set; }
        public DbSet<MainSocialMediaIcon> MainSocialMediaIcons { get; set; }
    }
}