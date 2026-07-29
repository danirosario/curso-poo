using GetHashCode_Equals.Entities;
using System;

namespace GetHashCode_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Equals: retorna true ou false
            string a = "Maria";
            string b = "Alex";

            Console.WriteLine(a.Equals(b));

            //GetHashCode: retorna um numero inteiro representando um código gerado a partir das informações do objeto

            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            Client x = new Client { Name = "Ni", Email = "ni@gmail.com"};
            Client y = new Client { Name = "Ni Gracinhas", Email = "nigracinhas@gmail.com" };

            Console.WriteLine();
            Console.WriteLine(x.Equals(y));
            Console.WriteLine(x == y);
            Console.WriteLine(x.GetHashCode());
            Console.WriteLine(y.GetHashCode());


        }
    }
}

// GetHashCode e Equals são operações da classe Object utilizadas para comparar se um objeto é igual ao outro
// Equals: lento, resposta 100%
// GetHashCode: rápido, porém resposta positiva não é 100%