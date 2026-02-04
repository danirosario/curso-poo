namespace ExercicioFixacao2
{
    internal class Exercicio2Funcionario
    {
        public static void Main(string[] args)
        {
            var employee = new Employee();

            Console.Write("Name: ");
            employee.Name = Console.ReadLine()!;

            Console.Write("Please provide your gross salary: ");
            employee.GrossSalary = double.Parse(Console.ReadLine()!);

            Console.Write("Please provide the tax amount: ");
            employee.Tax = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Employee: " + employee);

            Console.Write("Enter the percentage of salary increase: ");
            double increasePercentage = double.Parse(Console.ReadLine()!);
            employee.IncreaseSalary(increasePercentage);

            Console.WriteLine("After Increase: " + employee);

        }
    }
}
