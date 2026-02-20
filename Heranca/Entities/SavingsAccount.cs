namespace Heranca.Entities
{
    sealed class SavingsAccount : Account // sealed impede que outras classes herdem desta classe, ou seja, SavingsAccount não pode ser herdada por nenhuma outra classe
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

        public sealed override void Withdraw(double amount) // override permite que a classe derivada sobrescreva este método, substituindo a implementação da classe base
        {
           // Balance -= amount;
            base.Withdraw(amount); // base permite acessar a implementação da classe base, mesmo que ela tenha sido sobrescrita pela classe derivada
            Balance -= 2.0; // cobrando uma taxa de 2.0 para cada saque em uma conta poupança, além da taxa de 5.0 cobrada pela classe base
        }
    }
}

// SELED: O modificador sealed é usado para impedir que uma classe seja herdada ou que um método seja sobrescrito.
// metodo Withdraw da classe SavingsAccount é marcado como sealed,
// o que significa que ele não pode ser sobrescrito por nenhuma classe que herde de SavingsAccount.
// Isso garante que a implementação do método Withdraw em SavingsAccount
// seja a única implementação possível para essa classe e suas subclasses.
// A classe SavingsAccount é marcada como sealed, o que significa que ela não pode ser herdada por nenhuma outra classe.
