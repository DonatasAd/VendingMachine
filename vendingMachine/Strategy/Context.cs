using System;
using System.Collections.Generic;
using System.Text;
using vendingMachine.model;
using static vendingMachine.Program;

namespace vendingMachine.Strategy
{
    public class Context
    {
        #region Members

        private static Dictionary<AvailableDrink, IAvailableDrinkStrategy> _strategies =
            new Dictionary<AvailableDrink, IAvailableDrinkStrategy>();

        #endregion

        #region Ctor

        static Context()
        {
            _strategies.Add(AvailableDrink.Coffee, new BlackCoffeeStrategy());
            _strategies.Add(AvailableDrink.Latte, new LatteStrategy());
            _strategies.Add(AvailableDrink.Tea, new TeaStrategy());
        }

        #endregion

        #region Methods

        public static IHotDrink CreateDrink(AvailableDrink title)
        {
           return _strategies[title].CreateDrink();
        }

        #endregion
    }
}
