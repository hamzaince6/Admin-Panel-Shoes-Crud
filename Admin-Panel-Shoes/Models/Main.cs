using System.ComponentModel.DataAnnotations;

namespace Admin_Panel_Shoes.Models;

public class Main 
{
    [Key]
    public int MainId { get; set; }
    public string MainTitle { get; set; }
    public string MainDescription { get; set; }
    public string MainImage { get; set; }
    public string MainSocialMediaIconName { get; set; }
    public string MainSocialMediaIconLink { get; set; }
}