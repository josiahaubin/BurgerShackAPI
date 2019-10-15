using System.ComponentModel.DataAnnotations;
using burgerapi.Interfaces;

namespace burgerapi.Models
{
  public class Burger : IItem
  {
    public Burger()
    {
    }

    [Required]
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public string Id { get; set; }

    public Burger(string name, string description, double price)
    {
      Name = name;
      Description = description;
      Price = price;
    }
  }
}