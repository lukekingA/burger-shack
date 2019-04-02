namespace burger_shack.Models {
  public class Entree : Food {
    public bool Cooked { get; set; }
    public Entree (string name, decimal price, string description, bool cooked) : base (name, price, description) {
      Cooked = cooked;
    }
  }
}