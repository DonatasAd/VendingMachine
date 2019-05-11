using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using vendingMachine.Adapter;
namespace vendingMachine.model
{
    abstract class IHotDrink
    {
        protected string _drinkName;
        protected int _drinkPrice;
        protected DrinkSizes _drinkSize;
        public enum DrinkSizes
        {
            small,
            medium,
            large
        }
        public abstract void Prepare();
        public string DrinkName
        {
            get { return _drinkName; }
        }

        public int DrinkPrice
        {
            get { return _drinkPrice; }
        }

        public DrinkSizes DrinkSize
        {
            get { return _drinkSize; }
        }
        public abstract int GetDrinkPrice(DrinkSizes drinkSiz);

        public bool ConfirmPayment(IHotDrink drink)
        {
            //Payment With Coins
           Payment payment = new Payment();
            payment.PrintPaymentDetails(drink);
            string paymentId = Console.ReadLine().ToLower();
            return new Payment().Pay(paymentId);

            //// Payment With Mobile Pay
            //Payment payment = new MobilePayAdapter();
            //payment.PrintPaymentDetails(drink);
            //string paymentId = Console.ReadLine().ToLower();
            //return new MobilePayAdapter().Pay(paymentId);  
        }
        public void PrintPrepareSteps(string[] steps)
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------------------");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.Clear();
                Console.WriteLine(steps[i]);
                Thread.Sleep(1500);
            }
            Console.Clear();
            Console.WriteLine("Thank you for using chosing us :)");
            Thread.Sleep(3000);
            Console.WriteLine("----------------------------------------------------");
        }
        public DrinkSizes ReadDrinkSize()
        {
            while (true)
            {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Please select drink size:");
                Console.WriteLine("1. Small");
                Console.WriteLine("2. Medium");
                Console.WriteLine("3. Large");
                Console.WriteLine("----------------------------------------------------");
                Console.Write("Enter the size of the drink you would like to buy: ");
                try
                {
                    return (DrinkSizes)Enum.Parse(typeof(DrinkSizes), Console.ReadLine().ToLower(), true);
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Incorrect input, try again.");
                    Console.WriteLine("----------------------------------------------------");
                }
            }
        }
    }
}