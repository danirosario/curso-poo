using System;

namespace Matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("quantidade de linhas e colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite {n} numeros separados por virgula ',': ");
                string[] values = Console.ReadLine().Split(',');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("\nNegative numbers: " + count);

            /*
            double[,] mat = new double[2, 3];
            Console.WriteLine(mat.Length); // imprime o total de elementos

            Console.WriteLine(mat.Rank); // quantidade de linhas

            Console.WriteLine(mat.GetLength(0)); // numeros de elementos em uma dimensão especifica da matriz / retorna 2
            Console.WriteLine(mat.GetLength(1)); // retorna 3
            */
        }
    }
}
