namespace AnujBank
{
    public class TargetAccount
    {
        private readonly Account account;    
        
        private float allocatedPercentage;

        public TargetAccount(Account account, float allocatedPercentage)
        {
            this.account = account;
            this.allocatedPercentage = allocatedPercentage;
        }

        public int GetAccountNumber()
        {
            return account.GetAccountNumber();
        }

        public double GetAmount()
        {
            return account.Balance;
        }

        public void UpdateBalance(double finalAmount)
        {
            account.Balance += (finalAmount * (allocatedPercentage/100));
        }
    }
}