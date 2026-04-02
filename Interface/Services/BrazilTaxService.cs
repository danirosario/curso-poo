namespace Interface.Services
{
    internal class BrazilTaxService : ITaxService // This class implements the ITaxService interface, providing a specific tax calculation for Brazil.
    {
        public double Tax(double amount)
        {
            if (amount <= 100.0)
            {
                return amount * 0.2;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
