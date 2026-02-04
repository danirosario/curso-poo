namespace ExercicioFixacao1
{
    internal class Exercicio1
    {
        public static void Main(string[] args)
        {
            var rectangle = new Rectangle();
            Console.Write("Enter rectangle width: ");
            rectangle.Width = double.Parse(Console.ReadLine()!);

            Console.Write("Enter rectangle height: ");
            rectangle.Height = double.Parse(Console.ReadLine()!);

            Console.WriteLine($"AREA = {rectangle.Area():F2}");
            Console.WriteLine($"PERIMETER = {rectangle.Perimeter():F2}");
            Console.WriteLine($"DIAGONAL = {rectangle.Diagonal():F2}");
        }
    }
}
