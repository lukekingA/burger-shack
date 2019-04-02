using System;
using burger_shack.Models;

namespace burger_skack.Models {
  public class Burger : Entree {
    public Burger (string name, decimal price, string description, bool cooked) : base (name, price, description, cooked) { }
  }
}