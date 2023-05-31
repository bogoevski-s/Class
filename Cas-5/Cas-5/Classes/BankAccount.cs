namespace Cas_5.Classes
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string AccountName { get; set; }
        public int Balance { get; set; }

        public void Deposit(int amount)
        {
            Balance += amount;
        }

        public string Withdraw(int amount)
        {
            if(amount > Balance)
            {
                return "You dont have enough money";
            }

            Balance -= amount;

            return $"Your new balance is: {Balance}";
        }

        public int GetBalance()
        {
            return Balance;
        }
    }
}
