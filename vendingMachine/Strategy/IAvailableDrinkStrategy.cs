using System;
using System.Collections.Generic;
using System.Text;
using vendingMachine.model;

namespace vendingMachine.Strategy
{
    interface IAvailableDrinkStrategy
    {
        IHotDrink CreateDrink();
    }
}
