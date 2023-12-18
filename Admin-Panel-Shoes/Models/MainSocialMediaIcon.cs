using System.ComponentModel.DataAnnotations;

namespace Admin_Panel_Shoes.Models;

public class MainSocialMediaIcon 
{
    [Key]
    public int MainSocialMediaIconId { get; set; }

    public string MainSocialMediaIconName { get; set; }

    public string MainSocialMediaIconLink { get; set; }
}