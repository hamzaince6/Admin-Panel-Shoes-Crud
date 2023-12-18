using System.ComponentModel.DataAnnotations;

namespace Admin_Panel_Shoes.Models;

public class Services
{
    [Key]
    public int ServicesId { get; set; }

    public string ServicesIcon { get; set; }
    
    public string ServicesTitle { get; set; }

    public string ServicesDescription { get; set; }
}