using static System.Math;

namespace ExercicioFixacao1
{
    class Rectangle
    {
        public double Width;
        public double Height;
        public double Area()
        {
            return Width * Height;

        }
        public double Perimeter()
        {
            return 2 * (Width + Height);
        }
        public double Diagonal()
        {
            return Sqrt(Pow(Width, 2) + Pow(Height, 2));
        }
    }
}