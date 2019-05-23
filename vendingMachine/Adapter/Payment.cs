using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using vendingMachine.model;

namespace vendingMachine.Adapter
{
    interface Payment
    {
        bool Pay(string paymentID);
        void PrintPaymentDetails(IHotDrink drink);
    }
}
