using System;
using Heranca.Entities;

namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Maria", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            Account account1 = new Account(8020, "Bob", 100.0);

            BusinessAccount businessAccount = new BusinessAccount(8030, "Alex", 0.0, 500.0);

            // UPCASTING

            Account account2 = businessAccount; // implicitamente convertendo um BusinessAccount para um Account
            Account account3 = new BusinessAccount(8040, "Anna", 0.0, 300.0); // implicitamente convertendo um BusinessAccount para um Account
            Account account4 = new SavingsAccount(8050, "Bob", 0.0, 0.01); // implicitamente convertendo um SavingsAccount para um Account

            // DOWNCASTING

            BusinessAccount account5 = (BusinessAccount)account2; // explicitamente convertendo um Account para um BusinessAccount
            account5.Loan(100.0);

            if (account3 is BusinessAccount) // is é um operador que verifica se um objeto é de um determinado tipo, retornando true ou false
            {
                //BusinessAccount account6 = (BusinessAccount)account3; // explicitamente convertendo um Account para um BusinessAccount
                BusinessAccount account6 = account3 as BusinessAccount; // outra forma de explicitamente converter um Account para um BusinessAccount, usando o operador as
                account6.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if (account4 is BusinessAccount)
            {
                BusinessAccount account6 = (BusinessAccount)account4; // explicitamente convertendo um Account para um BusinessAccount
                account6.Loan(200.0);
                Console.WriteLine("Loan!");
            }
            else if (account4 is SavingsAccount)
            {
                SavingsAccount account6 = account4 as SavingsAccount; // explicitamente convertendo um Account para um SavingsAccount
                account6.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}

// herança é um dos pilares da programação orientada a objetos,
// onde uma classe pode herdar características (propriedades e métodos) de outra classe.
// A classe que herda é chamada de classe derivada ou subclasse,
// enquanto a classe que é herdada é chamada de classe base ou superclasse.

// Upcasting é o processo de converter um objeto de uma classe derivada para uma classe base.
// Isso é permitido porque a classe derivada é um tipo mais específico da classe base.
// Downcasting é o processo de converter um objeto de uma classe base para uma classe derivada.
// Isso pode ser perigoso, pois nem todos os objetos da classe base são necessariamente objetos da classe derivada.