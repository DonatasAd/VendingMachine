using System;
using System.Collections.Generic;
using vendingMachine.factories;
using vendingMachine.model;
using vendingMachine.Strategy;

namespace vendingMachine
{
    public class Program
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
                try
                {
                    AvailableDrink DrinkName = (AvailableDrink)Enum.Parse(typeof(AvailableDrink), Console.ReadLine().ToLower(), true);
                    Context.CreateDrink(DrinkName);
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Wrong input please enter valid drink name. ");
                }
                
                

            }         
        }
    }
}