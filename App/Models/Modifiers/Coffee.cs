namespace burger_shack.Models {
  public class Coffee : Drink {
    public Coffee (string name, decimal price, string description, string size, bool coldDrink) : base (name, price, description, size, coldDrink) { }
  }
}