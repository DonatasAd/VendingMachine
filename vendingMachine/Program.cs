using System;
using System.Collections.Generic;
using vendingMachine.factories;
using vendingMachine.model;

namespace vendingMachine
{
    class Program
    {
        public enum AvailableDrink
        {
            Coffee, Tea, Latte
        }
        static void Main()
        {
            while (true)
            {               
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Please select drink:");
                var Drinks = (AvailableDrink[])Enum.GetValues(typeof(AvailableDrink));
                for (int i = 0; i < Drinks.Length; i++)
                {
                    Console.WriteLine(i + 1 + " - " + Drinks[i]);
                }
                Console.WriteLine("----------------------------------------------------");
                Console.Write("Enter the drink name you would like to buy: ");
                string DrinkName = Console.ReadLine().ToLower();
                Console.Clear();
                     
                Console.Clear();
                bool confirmed;
                switch (DrinkName)
                {
                    case "tea":

                        IHotDrink Tea = DrinkFactory.CreateTea();
                        confirmed = Tea.ConfirmPayment(Tea);
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
                        break;
                    case "coffee":
                        IHotDrink Coffee = DrinkFactory.CreateBlackCoffee();
                        confirmed = Coffee.ConfirmPayment(Coffee);
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
                        break;
                    case "latte":
                        IHotDrink Latte = DrinkFactory.CreateLatte();
                        confirmed = Latte.ConfirmPayment(Latte);
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
                        break;
                }
            }         
        }
    }
}