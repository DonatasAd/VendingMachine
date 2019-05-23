using System;
using System.Collections.Generic;
using System.Text;
using vendingMachine.model;

namespace vendingMachine.Adapter
{
    class MobilePayAdapter : Payment
    {
        private MobilePay _mobilePay = new MobilePay();

        public bool Pay(string paymentID)
        {
            return _mobilePay.PayWithMobilePay(paymentID);
        }

        public void PrintPaymentDetails(IHotDrink drink)
        {
           _mobilePay.PrintPaymentDetails(drink);
        }
    }
}
