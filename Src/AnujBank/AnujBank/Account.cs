using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnujBank
{
    public class Account
    {
        public Account(AccountId id,Client client)
        {
            if (client == null)
                throw new NoClientException("You must provide client"); 
            AccountNo = id;
            Client = client;
            Client.AddAccount(this);
        }
        public AccountId AccountNo { get; private set; }
        public Client Client { get; private set; }
        public double Balance { get; set; }
        public DateTime LastUpdatedDate { get; set; }

        public int GetAccountNumber()
        {
            return AccountNo.Id;
        }
    }

    public class NoClientException : Exception
    {
        public NoClientException(string message) : base(message)
        {
            
        }
    }

    public class Client
    {

        private ClientID _id;
        private List<Account> _accounts;

        public Client(ClientID clientId)
        {
            _id = clientId;
            _accounts = new List<Account>();
        }
        public Account[] Accounts
        {
            get { return this._accounts.ToArray(); }

        }
        
        public string GetId()
        {
            return _id.Id;
        }

        public void AddAccount(Account account)
        {
            this._accounts.Add(account);
        }

    }
    
    public class ClientID
    {
      
        public ClientID(string id)
        {
            Id = id;
         }

        public string Id { get; set; }
     
    }
    public class AccountId
    {

        public AccountId(int id)
        {
            Id = id;
        }
        public int Id { get; set; }

    }
    
    

}
