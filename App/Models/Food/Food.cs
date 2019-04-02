namespace burger_shack.Models

{
  public abstract class Food {
    public string Name { get; private set; }

    public decimal Price { get; private set; }

    public string Description { get; set; }

    public Food (string name, decimal price, string description) {
      Name = name;
      Price = price;
      Description = description;
    }

  }
}