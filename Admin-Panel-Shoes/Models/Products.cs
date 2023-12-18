using System.ComponentModel.DataAnnotations;

namespace Admin_Panel_Shoes.Models;

public class Products 
{
    [Key]
    public int ProductsId { get; set; }

    public string ProductsImage { get; set; }

    public string ProcuctsName { get; set; }

    public string ProductsDescription { get; set; }

    public int ProductsPrice { get; set; }

    public string ProductsStar { get; set; }
}