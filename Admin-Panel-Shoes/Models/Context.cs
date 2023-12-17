using System.Data.Entity;

namespace Admin_Panel_Shoes.Models;

public class Context : DbContext
{
    public DbSet<AdminLogin> AdminLogins { get; set; }
    public DbSet<Main> Mains { get; set; }
    public DbSet<MainSocialMediaIcon> MainSocialMediaIcons { get; set; }
    
}