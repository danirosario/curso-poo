using System;
using Interface.Entities;

namespace Interface.Services
{
    internal class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerday { get; private set; }

        public RentalService(double pricePerHour, double pricePerday)
        {
            PricePerHour = pricePerHour;
            PricePerday = pricePerday;
        }   

        public Invoice ProcessInvoice(CarRental carRental)
        {
            double basicPayment = 0.0;
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);
            if (duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                basicPayment = PricePerday * Math.Ceiling(duration.TotalDays);
            }
            double tax = new BrazilTaxService().Tax(basicPayment);
            return new Invoice(basicPayment, tax);
        }
    }
}
