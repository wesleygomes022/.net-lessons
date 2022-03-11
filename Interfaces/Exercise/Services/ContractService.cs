using System;
using TestProj.Entities;

namespace TestProj.Services
{
    class ContractService
    {
        public IPaymentService PaymentType { get; private set; } 
        
        public ContractService(IPaymentService paymentType)
        {
            PaymentType = paymentType;
        }

        public void ProcessContract(Contract contract, int month)
        {
            double BasicAliquota = contract.TotalValue / month;
            for (int i = 1; i <= month; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double temp = BasicAliquota + PaymentType.MonthlyFee(BasicAliquota, i);
                double amount = temp + PaymentType.PaymentFee(temp);
                contract.Installments.AddLast(new Installment(date, amount));
            }
        }
    }
}
