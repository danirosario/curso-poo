using System;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            var product = new Product("TV", 500.00, 10);

            product.SetName("TV 4K");

            Console.WriteLine(product.GetName());



            /**
            Console.WriteLine("Enter the product details.:");
            Console.Write("Name: ");
            string nome = Console.ReadLine()!;
            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine()!);
            Console.Write("Quantity in stock: ");
            int quantity = int.Parse(Console.ReadLine()!);

            var product = new Product(nome, price, quantity); // Instanciando o objeto produto com os dados fornecidos pelo usuário

            Console.Write("\nProduct details: " + product);

            Console.WriteLine("\nEnter the number of products to be added in stock: ");
            Console.Write("Quantity: ");
            int quantityAdd = int.Parse(Console.ReadLine()!);
            product.AddProducts(quantityAdd);
            Console.WriteLine("\nUpdated data: " + product);

            Console.WriteLine("\nEnter the number of products to be removed from stock: ");
            Console.Write("Quantity: ");
            quantity = int.Parse(Console.ReadLine()!);
            product.RemoveProduct(quantity);
            Console.WriteLine("\nUpdated data: " + product);

            */
        }
    }
}