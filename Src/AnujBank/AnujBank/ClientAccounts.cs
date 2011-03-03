using System;
using System.Collections.Generic;
using System.Linq;

namespace AnujBank
{
   public class ClientAccounts
   {
      private readonly HashSet<Account> accounts;

      public ClientAccounts()
      {
         accounts = new HashSet<Account>();
      }

      public int Count
      {
         get { return accounts.Count; }
      }

      public void Add(Account newAccount)
      {
         Validate(newAccount);
         accounts.Add(newAccount);
      }

      private void Validate(Account newAccount)
      {
         string clientId = newAccount.GetClientId();
         if (accounts.Any(account => account.GetClientId() != clientId))
         {
            throw new ArgumentException("Account from two different clients cannot be added.");
         }
      }

       public bool SharesAccountWith(ClientAccounts clientAccounts)
       {
           return accounts.Overlaps(clientAccounts.accounts);
       }
   }
}