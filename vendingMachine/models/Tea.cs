using System;
using System.Collections.Generic;
using System.Text;

namespace vendingMachine.model
{
    class Tea : IHotDrink
    {
        public Tea()
        {
            _drinkName = "Tea";
            _drinkSize = ReadDrinkSize();
            _drinkPrice = GetDrinkPrice(_drinkSize);
        }
        public override int GetDrinkPrice(DrinkSizes drinkSize)
        {
            switch (drinkSize)
            {
                case DrinkSizes.small:
                    return 5;
                case DrinkSizes.medium:
                    return 8;
                case DrinkSizes.large:
                    return 10;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public override void Prepare()
        {
            string[] steps = { "Putting in tea bag...", "Pouring boiling water in the cup...", "Adding lemon...", "Tea is Ready." };
            PrintPrepareSteps(steps);
        }

    }
}
