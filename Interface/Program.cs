using Interface.Entities;
using Interface.Services;
using System;
using System.Globalization;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the rental data");
            Console.WriteLine("Car model: ");
            string model = Console.ReadLine();
            Console.WriteLine("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);
            Console.WriteLine("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", null);

            Console.WriteLine("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);

        }
    }
}
