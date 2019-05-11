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
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Do you want milk in your drink? ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("1.Yes\n2.No ");
            Console.WriteLine("----------------------------------------------------");

            Console.Write("please input your answer: ");
            string answer = Console.ReadLine().ToLower();

            bool confirmed = Coffee.ConfirmPayment(Coffee);

            if (confirmed)
            {
                if (answer.Equals("yes"))
                {
                    IHotDrink coffeeWithMilk = new MilkyDrinkDecorator(Coffee);
                    coffeeWithMilk.Prepare();
                }
                else
                {
                    Coffee.Prepare();
                }
                            
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
