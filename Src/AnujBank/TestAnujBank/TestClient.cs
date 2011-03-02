using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnujBank;
using NUnit.Framework;

namespace TestAnujBank
{
    [TestFixture]
    public class TestClient
    {
        [Test]
        public void ShouldBeAbleAddAStructure()
        {
            var clientId = new ClientId("ABCD1234");
            var account1 = new Account(new AccountId(12341234), clientId);
            var account2 = new Account(new AccountId(12341235), clientId);
            Accounts accounts = new Accounts(account1, account2);
            var structure = new Structure(accounts);
            var client = new Client(clientId, accounts);
            client.AddStructure(structure);
            Assert.IsTrue(client.Contains(structure));
        } 
    }

}
