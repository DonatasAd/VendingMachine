using System;
using System.Collections.Generic;
using System.Text;

namespace vendingMachine.model
{
    class BlackCoffee : IHotDrink
    {
        public BlackCoffee()
        {
            _drinkName = "Coffee";
            _drinkSize = ReadDrinkSize();
            _drinkPrice = GetDrinkPrice(_drinkSize);
        }
        public override int GetDrinkPrice(DrinkSizes drinkSize)
        {
            switch (drinkSize)
            {
                case DrinkSizes.small:
                    return 10;
                case DrinkSizes.medium:
                    return 13;
                case DrinkSizes.large:
                    return 18;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public override void Prepare()
        {
            string[] steps = { "Grinding some beans...", "Pouring coffe in the cup...", "Coffe is Ready." };
            PrintPrepareSteps(steps);
        }
    }
}
