
namespace StoreAppProject.Models;

public class Order : baseModel
{
    public double TotalPrice { get; set; }
    public List<Product> Products { get; set; }
}
