namespace burgerapi.Interfaces
{
  public interface IItem
  {
    string Name { get; set; }
    string Description { get; set; }
    double Price { get; set; }
  }
}