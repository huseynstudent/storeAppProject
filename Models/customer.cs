using StoreAppProject.Enums;

namespace StoreAppProject.Models;

public class Customer : baseModel
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public Gender Gender { get; set; }
    public List<Order> Orders { get; set; }
}