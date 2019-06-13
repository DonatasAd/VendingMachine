using System;
using System.Collections.Generic;
using System.Text;

namespace vendingMachine.model
{
    class Latte : IHotDrink
    {
        public Latte()
        {
            _drinkName = "Latte";
            _drinkSize = ReadDrinkSize();
            _drinkPrice = CalculateDrinkPrice(_drinkSize);
        }
        public override int CalculateDrinkPrice(DrinkSizes drinkSize)
        {
            switch (drinkSize)
            {
                case DrinkSizes.small:
                    return 15;
                case DrinkSizes.medium:
                    return 18;
                case DrinkSizes.large:
                    return 25;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public override void Prepare()
        {  
            string[] steps = { "Grinding some beans...", "Pouring Latte coffe in the cup...", "Latte Coffe is Ready." };
            PrintPrepareSteps(steps);
        }

    }
}
