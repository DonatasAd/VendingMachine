using System;
using System.Collections.Generic;
using System.Text;
using vendingMachine.factories;
using vendingMachine.model;

namespace vendingMachine.Strategy
{
 
    class LatteStrategy : IAvailableDrinkStrategy
    {
        public IHotDrink CreateDrink()
        {
            IHotDrink Latte = DrinkFactory.CreateLatte();
            bool confirmed = Latte.ConfirmPayment(Latte);
            if (confirmed)
            {
                Latte.Prepare();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect payment, try again.");
            }
            Console.Clear();
            return Latte;
        }
    }
}
