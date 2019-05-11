using System;
using System.Collections.Generic;
using System.Text;
using vendingMachine.model;

namespace vendingMachine.Adapter
{
    class MobilePayAdapter : Payment
    {
        private MobilePay _mobilePay = new MobilePay();

        public override bool Pay(string paymentID)
        {
            return _mobilePay.ConfirmMobilePayPayment(paymentID);
        }

        public override void PrintPaymentDetails(IHotDrink drink)
        {
           _mobilePay.PrintPaymentDetails(drink);
        }
    }
}
