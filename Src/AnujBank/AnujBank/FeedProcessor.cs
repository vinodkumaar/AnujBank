using System;
using System.IO;

namespace AnujBank
{
    public class FeedProcessor
    {

        private StreamReader feedReader;
        public FeedProcessor(IRepository repository, string feedPath)
        {
            Repository = repository;
            Load(feedPath);
        }

        public IRepository Repository { get; private set; }
        
        private void Load(string feedPath)
        {
            feedReader = File.OpenText(feedPath);
        }

        public void Process()
        {
            string row;
            while ((row = feedReader.ReadLine()) != null)
            {
                ProcessRow(row);
            }
        }
        private void ProcessRow(string row)
        {
            var fields=row.Split(',');
            var clientId = new ClientId(fields[0]);
            var account = new Account(new AccountId(int.Parse(fields[1])), clientId) { Balance = double.Parse(fields[2].Trim()), LastUpdatedDate = DateTime.ParseExact(fields[3],"dd/mm/yyyy",null) };
            
            Repository.Save(account);
        }
    }
}