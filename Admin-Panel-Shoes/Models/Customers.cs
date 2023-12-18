using System.ComponentModel.DataAnnotations;

namespace Admin_Panel_Shoes.Models;

public class Customers 
{
    [Key]
    public int CustomersId { get; set; }
    
    public string CustomersImage { get; set; }
    
    public string CustomersTitle { get; set; }

    public string CustomersStar { get; set; }

    public string CustomersDescription { get; set; }
    
}