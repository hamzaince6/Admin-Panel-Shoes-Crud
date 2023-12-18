using System.ComponentModel.DataAnnotations;

namespace Admin_Panel_Shoes.Models;

public class AdminLogin 
{
    [Key]
    public int AdminLoginId { get; set; }

    public string AdnminLoginUser { get; set; }

    public string AdminLoginPassword { get; set; }
    
}