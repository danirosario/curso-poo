using System;
using Enumeracao.Entities;
using Enumeracao.Entities.Enums;
namespace Enumeracao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            
            Console.WriteLine(order);

            string txt = OrderStatus.Processing.ToString();

            Console.WriteLine(txt);

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            Console.WriteLine(os);


        }
    }
}
