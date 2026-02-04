namespace Aula06
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point;
            point.X = 10;
            point.Y = 20;
            Console.WriteLine(point);

            // Output: { X = 10, Y = 20 }
            // Note: não é necessário usar 'new' para structs
            // porque structs são tipos por valor e podem ser usados diretamente.
            // todos os campos devem ser atribuídos antes do uso.
            // Isso difere de classes, que são tipos por referência e requerem 'new' para instanciar.
            // Structs não suportam herança (não podem derivar de outras structs ou classes, exceto de System.ValueType).
            // Eles podem implementar interfaces, no entanto.
            // Structs são geralmente usados para representar pequenos grupos de dados relacionados.
            // Eles são alocados na stack, o que pode levar a melhorias de desempenho em certos cenários.
            // Structs são tipos imutáveis por padrão, embora seus campos possam ser mutáveis se declarados como tal.

            Point anotherPoint = new Point(); // isso é permitido, mas não obrigatório e inicializa os campos com valores padrão (0 para numéricos)
            Console.WriteLine(anotherPoint);

            // nullable structs podem ser usados para permitir valores null, o que não é possível com structs normais

            Nullable<double> x = null;
            double? y = null; // sintaxe abreviada para Nullable<T>

            double? z = 5.0;

            Console.WriteLine($"x: {x.GetValueOrDefault()}, y: {y}, z: {z}");

            Console.WriteLine(x.HasValue); // false no caso de null

            // Console.WriteLine(y.Value); // lança InvalidOperationException se y for null, não seguro acessar diretamente

            if (y.HasValue)
            {
                Console.WriteLine(y.Value); // seguro acessar Value
            }
            else
            {
                Console.WriteLine("y é null");
            }

            // Uso do operador null-coalescing para fornecer um valor padrão

            double valueY = y ?? 0.0; // se y for null, valueY será 0.0
            Console.WriteLine($"valueY: {valueY}"); // imprime 0.0

        }
    }
}
