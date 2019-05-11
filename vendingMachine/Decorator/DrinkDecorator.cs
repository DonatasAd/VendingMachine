using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using vendingMachine.Adapter;
namespace vendingMachine.model
{
    public abstract class DrinkDecorator : IHotDrink
    {
        protected IHotDrink decoratedDrink;

		public DrinkDecorator(IHotDrink decoratedDrink)
        {
            this.decoratedDrink = decoratedDrink;
        }

		public override void Prepare()
        {
            decoratedDrink.Prepare();
        }

    }
}