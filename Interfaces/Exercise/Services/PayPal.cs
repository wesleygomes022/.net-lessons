using System;

namespace TestProj.Services
{
    class PayPal : IPaymentService
    {
        public double MonthlyFee(double amount, int monthNum)
        {
            return amount * 0.01 * monthNum;
        }

        public double PaymentFee(double amount)
        {
            return amount * 0.02;
        }
    }
}
