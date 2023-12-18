using System.ComponentModel.DataAnnotations;

namespace Admin_Panel_Shoes.Models;

public class About 
{
    [Key]
    public int AboutId { get; set; }

    public string AboutMainImage { get; set; }

    public string AboutImage1 { get; set; }

    public string AboutImage2 { get; set; }

    public string AboutImage3 { get; set; }

    public string AboutImage4 { get; set; }

    public string AboutDescription { get; set; }
}