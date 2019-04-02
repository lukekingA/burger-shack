using System;
using System.Collections.Generic;
using burger_skack.Models;

namespace burger_shack.Models {
  public class Menu {
    public List<Entree> Entrees { get; private set; }

    public void PrintEntrees () {
      Entrees.ForEach (e => {
        System.Console.WriteLine ($"{e.Name} - {e.Price}");
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine ($"{e.Description}");
        Console.ResetColor ();
        System.Console.WriteLine ("\n");
      });
    }
    public void AddBurger (string name, decimal price, string description, bool cooked) {
      Burger adding = new Burger (name, price, description, cooked);
      Entrees.Add (adding);
    }

    public void AddSandwich (string name, decimal price, string description, bool cooked) {
      Sandwich adding = new Sandwich (name, price, description, cooked);
      Entrees.Add (adding);
    }

    public List<Drink> Drinks { get; private set; }

    public void PrintDrinks () {
      Drinks.ForEach (d => {
        System.Console.WriteLine ($"{d.Name}: {d.Size} - {d.Price}");
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine ($"{d.Description}");
        Console.ResetColor ();
        System.Console.WriteLine ("\n");
      });
    }
    public void AddSoda (string name, decimal price, string description, string size, bool coldDrink) {
      Soda adding = new Soda (name, price, description, size, coldDrink);
      Drinks.Add (adding);
    }

    public void AddCoffee (string name, decimal price, string description, string size, bool coldDrink) {
      Coffee adding = new Coffee (name, price, description, size, coldDrink);
      Drinks.Add (adding);
    }

    public void AddShake (string name, decimal price, string description, string size, bool coldDrink) {
      Shake adding = new Shake (name, price, description, size, coldDrink);
      Drinks.Add (adding);
    }

    public List<Side> Sides { get; private set; }

    public void PrintSides () {
      Sides.ForEach (s => {
        System.Console.WriteLine ($"{s.Name}: {s.Size} - {s.Price}");
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.WriteLine ($"{s.Description}");
        Console.ResetColor ();
        System.Console.WriteLine ("\n");
      });

    }

    public void AddSide (string name, decimal price, string description, string size) {
      Side adding = new Side (name, price, description, size);
    }
    public Menu () {
      List<Entree> Entrees = new List<Entree> ();
      Entrees.Add (new Burger ("Single", 3.00M, "Quarter pound beef pattie, letuce, tomato, pickles, onion, and special sauce on a bun.", true));
      Entrees.Add (new Burger ("Double", 4.00M, " Two Quarter pound beef patties, letuce, tomato, pickles, onion, and special sauce on a bun.", true));
      Entrees.Add (new Burger ("Double Cheese", 4.50M, " Two Quarter pound beef patties, letuce, tomato, pickles, onion, cheese, and special sauce on a bun.", true));
      Entrees.Add (new Sandwich ("Chicken", 4.50M, "Grilled Chicken Breast, letuce, tomato, onion, Swiss cheese, and special sauce on a bun.", false));
      Entrees.Add (new Sandwich ("Ham", 4.00M, "Honey Ham, letuce, tomato, onion, Swiss cheese, and special sauce on a bun.", false));

      List<Drink> Drinks = new List<Drink> ();
      Drinks.Add (new Soda ("Coke", 1.00M, "fountain drink", "small", true));
      Drinks.Add (new Soda ("Coke", 1.25M, "fountain drink", "medium", true));
      Drinks.Add (new Soda ("Coke", 1.50M, "fountain drink", "large", true));
      Drinks.Add (new Soda ("Dr Pepper", 1.00M, "fountain drink", "small", true));
      Drinks.Add (new Soda ("Dr Pepper", 1.25M, "fountain drink", "medium", true));
      Drinks.Add (new Soda ("Dr Pepper", 1.50M, "fountain drink", "large", true));
      Drinks.Add (new Soda ("Mt Dew", 1.00M, "fountain drink", "small", true));
      Drinks.Add (new Soda ("Mt Dew", 1.25M, "fountain drink", "medium", true));
      Drinks.Add (new Soda ("Mt Dew", 1.50M, "fountain drink", "large", true));

      Drinks.Add (new Shake ("Vanilla Shake", 2.00M, "shake", "medium", true));
      Drinks.Add (new Shake ("Vanilla Shake", 3.00M, "shake", "large", true));
      Drinks.Add (new Shake ("Chocolate Shake", 2.00M, "shake", "medium", true));
      Drinks.Add (new Shake ("Chocolate Shake", 3.00M, "shake", "large", true));
      Drinks.Add (new Shake ("Strawberry Shake", 2.00M, "shake", "medium", true));
      Drinks.Add (new Shake ("Strawberry Shake", 3.00M, "shake", "large", true));

      Drinks.Add (new Coffee ("Black", 1.00M, "Bottomless cup of coffee", "medium", false));
      Drinks.Add (new Coffee ("Ice Coffee", 1.50M, " Double Espresso, finely crushed ice, and cream", "medium", true));

      List<Side> Sides = new List<Side> ();
      Sides.Add (new Side ("French Fries", 1.50M, "Shoestring french fries double fried to perfection", "medium"));
      Sides.Add (new Side ("French Fries", 2.00M, "Shoestring french fries double fried to perfection", "large"));
      Sides.Add (new Side ("Tater-tots", 1.50M, "Tater-tots double fried to perfection", "medium"));
      Sides.Add (new Side ("Tater-tots", 2.00M, "Tater-tots double fried to perfection", "large"));
    }
  }
}