using System;
using TestProj.Entities;

namespace TestProj.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; } = 10.0;
        public double PricePerDay { get; private set; } = 130.0;

        private BrazilTaxService _brazilTaxService = new BrazilTaxService();

        public RentalService()
        {
        }

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan time = carRental.Finish.Subtract(carRental.Start);

            double BasicPayment = 0;
            if(time.TotalHours <= 12)
            {
                BasicPayment = PricePerHour * Math.Ceiling(time.TotalHours);
            }
            else
            {
                BasicPayment = PricePerDay * Math.Ceiling(time.TotalDays);
            }

            double tax = _brazilTaxService.Tax(BasicPayment);
            carRental.Invoice = new Invoice(BasicPayment, tax);
        }
    }
}
