using System;
using ExTratamentoExcecoes.Entities;
using ExTratamentoExcecoes.Entities.Exceptions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExTratamentoExcecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy): ");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy): ");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            try
            {
                var reservation = new Reservation(number, checkin, checkout);
                Console.WriteLine("Reservation: " + reservation);
            }
            catch(DomainException)
            { 
                Console.WriteLine($"Error in reservation: ");
            }

        }
    }
}
