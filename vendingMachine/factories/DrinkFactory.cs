using System;
using System.Collections.Generic;
using System.Text;
using vendingMachine.model;
using static vendingMachine.Program;

namespace vendingMachine.factories
{
    class DrinkFactory
    {
        public static IHotDrink CreateHotDrink(AvailableDrink DrinkName)
        {
            switch (DrinkName)
            {
                case AvailableDrink.Coffee:
                    return new BlackCoffee();
                case AvailableDrink.Tea:
                    return new Tea();
                case AvailableDrink.Latte:
                    return new Latte();
                default:
                    throw new ArgumentOutOfRangeException();
            }        
        }
    }
}
