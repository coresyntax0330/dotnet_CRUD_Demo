namespace CrudDemo.Models
{
  public class Product
  {
    public int Id { get; set; } // Primary Key
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int Quantity { get; set; }
  }
}