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
            ClientId clientId = new ClientId();
            Accounts accounts = new Accounts(new Account(), new Account());
            var structure = new Structure(accounts);
            var client = new Client(clientId, accounts);
            client.AddStructure(structure);
            Assert.IsTrue(client.Contains(structure));
        } 
    }

}
