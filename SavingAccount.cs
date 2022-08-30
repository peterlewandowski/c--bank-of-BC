public class SavingAccount : BankAccount
{

    public SavingAccount() : base()
    {
        Balance = 200;
    }

    public SavingAccount(decimal amount) : base(amount) {
        
    }
}