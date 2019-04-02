namespace burger_shack.Models {
  public class Soda : Drink {
    public Soda (string name, decimal price, string description, string size, bool coldDrink) : base (name, price, description, size, coldDrink) { }
  }
}