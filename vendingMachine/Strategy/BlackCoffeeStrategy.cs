using System;
using System.Collections.Generic;
using System.Text;
using vendingMachine.factories;
using vendingMachine.model;

namespace vendingMachine.Strategy
{
    class BlackCoffeeStrategy : IAvailableDrinkStrategy
    {
        public IHotDrink CreateDrink()
        {
            IHotDrink Coffee = DrinkFactory.CreateBlackCoffee();
            bool confirmed = Coffee.ConfirmPayment(Coffee);
            if (confirmed)
            {
                Coffee.Prepare();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect payment, try again.");
            }
            Console.Clear();
            return Coffee;
        }
    }
}
