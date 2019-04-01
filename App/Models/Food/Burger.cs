using System;
using burger_shack.Models;

namespace burger_skack.Models {
  public class Burger : Food {
    public string Description { get; private set; }
    public Burger (string name, float price, string description) : base (name, price) {
      Description = description;
    }
  }
}