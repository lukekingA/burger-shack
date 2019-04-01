namespace burger_shack.Models

{
  public abstract class Food {
    public string Name { get; private set; }

    public float Price { get; private set; }

    public Food (string name, float price) {
      Name = name;
      Price = price;
    }

  }
}