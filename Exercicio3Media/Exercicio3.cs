namespace ExercicioFixacao3
{
    internal class Exercicio3
    {
        public static void Main(string[] args)
        {
            var grade = new GradeCalculator();

            Console.Write("Enter the student's name: ");
            grade.StudentName = Console.ReadLine()!;

            Console.WriteLine("Enter the three grades: ");
            grade.Grade1 = double.Parse(Console.ReadLine()!);
            grade.Grade2 = double.Parse(Console.ReadLine()!);
            grade.Grade3 = double.Parse(Console.ReadLine()!);
 
            double finalGrade = grade.FinalGrade();

            Console.WriteLine($"Final Average: {finalGrade:F2}");

            Console.WriteLine("Status: " + (grade.IsPassed() ? "Passed" : "Failed"));
            if (!grade.IsPassed())
            {
                double missingPoints = grade.MissingPoints();
                Console.WriteLine($"Missing Points: {missingPoints:F2}");
            }
        }
    }
}


