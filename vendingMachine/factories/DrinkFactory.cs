using System;
using System.Collections.Generic;
using System.Text;
using vendingMachine.model;

namespace vendingMachine.factories
{
    class DrinkFactory
    {
        public static IHotDrink CreateBlackCoffee()
        {
            return new BlackCoffee();
        }
        public static IHotDrink CreateTea()
        {
            return new Tea();
        }
        public static IHotDrink CreateLatte()
        {
            return new Latte();
        }
    }
}
