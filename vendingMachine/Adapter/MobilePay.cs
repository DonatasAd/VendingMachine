using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using vendingMachine.model;

namespace vendingMachine.Adapter
{
    class MobilePay
    {
        public bool PayWithMobilePay(string paymentID)
        {
            Console.Clear();
            Console.WriteLine("Mobile Pay payment confirmed.");
            Thread.Sleep(1500);
            return true;
        }
        public void PrintPaymentDetails(IHotDrink drink)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Your drink details are below :");
            Console.WriteLine("Drink Type: {0}\nDrink Size: {1}\nDrink Price: {2} DKK",
                drink.GetDrinkName, drink.GetDrinkSize, drink.GetDrinkPrice);
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("To pay for the drink you need to transfer money to MobilePay acount - 123456");
            Console.WriteLine("----------------------------------------------------");
            Console.Write("Enter transaction id to confirm your payment:");
        }
    }
}
