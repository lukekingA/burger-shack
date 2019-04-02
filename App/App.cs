using System;
using burger_shack.Models;

namespace burger_shack {
  class App {

    public App () { }
    Menu menu = new Menu ();

    public void Order () {
      while (true) {
        Console.Clear ();

        System.Console.WriteLine ("Entrees");
        menu.PrintEntrees ();
        System.Console.WriteLine ("Sides");
        menu.PrintSides ();
        System.Console.WriteLine ("Drinks");
        menu.PrintDrinks ();
      }
    }
  }
}