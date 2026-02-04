namespace ExercicioMembrosEstaticos
{
    class CurrencyConverter
    {
        public static double IOF = 0.06;

        public static double ConvertToReais(double dollarRate, double amount)
        {
            double baseValue = dollarRate * amount;
            return baseValue * (1 + IOF);
        }
    }
}
