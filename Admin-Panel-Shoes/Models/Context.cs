using Microsoft.EntityFrameworkCore;
using DbContext = System.Data.Entity.DbContext;

namespace Admin_Panel_Shoes.Models;

public class Context : DbContext
{
    protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=Shoes-Db-Crud; integrated security=true");
    }
    
    public System.Data.Entity.DbSet<AdminLogin> AdminLogins { get; set; }
    public System.Data.Entity.DbSet<Main> Mains { get; set; }
    public System.Data.Entity.DbSet<MainSocialMediaIcon> MainSocialMediaIcons { get; set; }
    
}

