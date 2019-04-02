namespace burger_shack.Models {
  public abstract class Drink : Modifier {
    public Drink (string name, decimal price, string description, string size, bool coldDrink) : base (name, price, description, size) {
      ColdDrink = coldDrink;
    }

    public bool ColdDrink { get; set; }

  }
}