using System;
using System.Collections.Generic;
using System.Text;
using vendingMachine.factories;
using vendingMachine.model;

namespace vendingMachine.Strategy
{
    class TeaStrategy : IAvailableDrinkStrategy
    {
        public IHotDrink CreateDrink()
        {
            IHotDrink Tea = DrinkFactory.CreateTea();
            bool confirmed = Tea.ConfirmPayment(Tea);
            if (confirmed)
            {
                Tea.Prepare();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect payment, try again.");
            }
            Console.Clear();
            return Tea;
        }
    }
}
