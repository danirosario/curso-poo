using System.Globalization;

namespace ExercicioMembrosEstaticos
{
    internal class Exercicio1
    {
        static void Main(string[] args)
        {
            double dollarRate;
            double amount;
            double totalValue;

            Console.Write("What is the dollar rate? ");
            dollarRate = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("How many dollars will be bought? ");
            amount = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            totalValue = CurrencyConverter.ConvertToReais(dollarRate, amount);

            Console.WriteLine("Amount to be paid in reais = " + totalValue.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

}
