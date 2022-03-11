using System;
using TestProj.Entities;

namespace TestProj.Services
{
    interface IPaymentService
    {
        double MonthlyFee(double amount, int monthNum);
        double PaymentFee(double amount);
    }
}
