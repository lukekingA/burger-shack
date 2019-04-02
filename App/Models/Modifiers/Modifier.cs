namespace burger_shack.Models {
  public abstract class Modifier : Food {
    public Modifier (string name, decimal price, string description, string size) : base (name, price, description) {
      Size = size;
    }

    public string Size { get; set; }

  }
}