namespace burger_shack.Models {
  class Modifier : Food {
    public string Size { get; set; }
    public Modifier (string name, float price, string size) : base (name, price) {
      Size = size;
    }
  }
}