using System;

namespace burger_shack.Models {
  public class Meal {
    public string MakeMeal (Entree entree, Side side, Drink drink) {
      return ((entree.Price + side.Price + drink.Price) * .85M).ToString ("#.##");
    }

    public decimal MakeMeal (Food food) {
      return food.Price;
    }

    public decimal MakeMeal (Food food, Food alsoFood) {
      return food.Price + alsoFood.Price;
    }

  }
}