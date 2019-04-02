using System;
using burger_shack.Models;

namespace burger_skack.Models {
  public class Sandwich : Entree {
    public Sandwich (string name, decimal price, string description, bool cooked) : base (name, price, description, cooked) { }
  }
}