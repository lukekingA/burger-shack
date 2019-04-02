namespace burger_shack.Models {
  public class Shake : Drink {
    public Shake (string name, decimal price, string description, string size, bool coldDrink) : base (name, price, description, size, coldDrink) { }
  }
}