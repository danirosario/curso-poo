using System;

namespace Vetores
{
    class Calculator
    {
        public static int Sum(params int[] numbers) // usa-se 'params' para permitir um número variável de argumentos 
        {
            int sum = 0;
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //return sum;

            foreach(int number in numbers) // outra forma de fazer o loop
            {
                sum += number;
            }
            return sum;
        }
    }
}
// foreach é uma estrutura de repetição específica para percorrer coleções, como arrays ou listas.





// ref vs out
// ref: o parâmetro deve ser inicializado antes de ser passado para o método
// out: o parâmetro não precisa ser inicializado antes de ser passado para o método,
//      mas deve ser atribuído dentro do método antes de ser usado

// Exemplo de uso de ref e out
// class RefOutExample
// {
//     public static void ModifyValues(ref int a, out int b)
//     {
//         a += 10; // Modifica o valor de 'a'
//         b = 20;  // Atribui um valor a 'b'
//     }
//
//     static void Main(string[] args)
//     {
//         int x = 5;
//         int y; // 'y' não precisa ser inicializado
//         ModifyValues(ref x, out y);
//         Console.WriteLine("x: " + x); // Saída: x: 15
//         Console.WriteLine("y: " + y); // Saída: y: 20
//     }
// }

