using System;
using System.Collections.Generic;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();  // cria uma lista vazia

            list.Add("Maria");
            list.Add("Ana");
            list.Add("Alex"); // adiciona ao final da lista

            list.Insert(1, "Ni"); // adiciona em um indice especifico

            foreach (string item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"list count: {list.Count}"); // tamanho da lista

            string s1 = list.Find(x => x[0] == 'A'); // x tal que x[0] seja igual a 'A' // encontra a primeira ocorrencia // (expressão Lambda)
            Console.WriteLine("First A = " + s1);

            string s2 = list.FindLast(x => x[0] == 'A'); // encontra a ultima ocorrencia
            Console.WriteLine("Last A = " + s2);

            int pos1 = list.FindIndex(x =>  x[0] ==  'A'); // primeiro index
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A'); // ultimo index
            Console.WriteLine("Last position 'A': " + pos2);

            Console.WriteLine("-----------------------");

            List<string> list2 = list.FindAll(x => x.Length == 2);

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }

            list.Remove("Alex");  // remove um item da lista
            Console.WriteLine("-----------------------");
            foreach(string item in list) { Console.WriteLine(item); }

            list.RemoveAll(x => x[0] == 'M'); // remove todos que tenham a condição especificada
            Console.WriteLine("-----------------------");
            foreach (string item in list) { Console.WriteLine(item); }

        }
    }
}

//listas é uma estrutura de dados homogenea, ordenada 
// o tamanho da lista é variavel, diferente do vetor, mas o acesso aos elementos é sequencial 
// generics e predicados