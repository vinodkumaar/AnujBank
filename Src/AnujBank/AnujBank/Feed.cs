using System;
using AnujBank;

namespace TestAnujBank
{
    public class Feed
    {
        
        public Feed(IRepository repository)
        {
            Repository = repository;
        }

        public IRepository Repository { get; private set; }
        public void Load()
        {
            
        }

        public void Process()
        {
            string row = "";
            ProcessRow(row);
        }
        private void ProcessRow(string row)
        {
            var clientId = new ClientId("ABC123");
            var account = new Account(new AccountId(12341234), clientId) { Balance = 100.00, LastUpdatedDate = DateTime.Now };
            Repository.Save(account);
        }
    }
}