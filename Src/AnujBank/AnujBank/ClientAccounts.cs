using System;
using System.Linq;

namespace AnujBank
{
    public class ClientAccounts
    {
        private readonly Account[] _accounts;

        public ClientAccounts(params Account[] accounts)
        {
           Validate(accounts);
           _accounts = accounts;
        }

       private static void Validate(Account[] accounts)
       {
          string clientId = accounts[0].GetClientId();
          if(accounts.Any(account => account.GetClientId() != clientId))
          {
             throw new ArgumentException("Account from two different clients cannot be added.");
          }
       }

       public int Count
        {
            get { return _accounts.Length; }
        }
    }
}