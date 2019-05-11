using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using vendingMachine.Adapter;
namespace vendingMachine.model
{
    public class MilkyDrinkDecorator : DrinkDecorator
    {
       

        public MilkyDrinkDecorator(IHotDrink decoratedDrink) : base(decoratedDrink)
        {
           // super(decoratedDrink);

        }

        public override int GetDrinkPrice(DrinkSizes drinkSiz)
        {
            throw new NotImplementedException();
        }

        public override void Prepare()
        {
            AddMilk(decoratedDrink);
            decoratedDrink.Prepare();
            
        }

        private void AddMilk(IHotDrink decoratedDrink)
        {
            Console.Clear();
            Console.WriteLine("Added milk to your drink.");
            Thread.Sleep(2000);
        }
    }


    
}