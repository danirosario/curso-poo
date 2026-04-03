using ExFixInterface.Entities;
using ExFixInterface.Services;
using System;
namespace ExFixInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date: (dd/MM/yyyy):");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int numberOfInstallments = int.Parse(Console.ReadLine());

            Contract myContract = new Contract(contractNumber, contractDate, contractValue);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, numberOfInstallments);

            Console.WriteLine("Installments:");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);

            }
        }
    }
}
