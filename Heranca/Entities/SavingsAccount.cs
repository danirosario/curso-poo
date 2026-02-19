namespace Heranca.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) // override permite que a classe derivada sobrescreva este método, substituindo a implementação da classe base
        {
           // Balance -= amount;
            base.Withdraw(amount); // base permite acessar a implementação da classe base, mesmo que ela tenha sido sobrescrita pela classe derivada
            Balance -= 2.0; // cobrando uma taxa de 2.0 para cada saque em uma conta poupança, além da taxa de 5.0 cobrada pela classe base
        }
    }
}
