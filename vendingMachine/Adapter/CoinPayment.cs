using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using vendingMachine.model;

namespace vendingMachine.Adapter
{
    class CoinPayment : Payment
    {
        public bool Pay(string paymentID)
        {
            Console.Clear();
            Console.WriteLine("Coins accepted");
            Thread.Sleep(1500);
            return true;
        }
        public void PrintPaymentDetails(IHotDrink drink)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Your drink details are below :");
            Console.WriteLine("Drink Type: {0}\nDrink Size: {1}\nDrink Price: {2} DKK",
                drink.DrinkName, drink.DrinkSize, drink.DrinkPrice);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("To pay for the drink please insert coins.");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Insert Coin:");
        }
    }
}
