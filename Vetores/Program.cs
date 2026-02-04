using System;
using System.Globalization;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 2 : Using a vector of objects

            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter product name: ");
                string name = Console.ReadLine(); 
                Console.WriteLine("Enter product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price }; // Instantiating a new Product object and assigning it to the array

                sum += vect[i].Price;
            }

            double average = sum / n;

            Console.WriteLine("AVERAGE PRICE: " + average.ToString("F2", CultureInfo.InvariantCulture));

            /*
             * Exercise 1: Using a vector to store values
             * 
             * 
            int n = int.Parse(Console.ReadLine());
            double[] vect = new double[n];

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += vect[i];
            }

            double average = sum / n;
            Console.WriteLine("AVERAGE HEIGHT: " + average.ToString("F2", CultureInfo.InvariantCulture));
            */
        }
    }
}
