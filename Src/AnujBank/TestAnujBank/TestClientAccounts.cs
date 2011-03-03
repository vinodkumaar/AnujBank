using System;
using AnujBank;
using NUnit.Framework;

namespace TestAnujBank
{
    [TestFixture]
    public class TestClientAccounts
    {
        [Test]
        public void ShouldNotBeAbleToCreatAStructureWithAccountsFromTwoDifferentClients()
        {
            var clientId1 = new ClientId("ABC123");
            var clientId2 = new ClientId("ABC124");
            var account1 = new Account(new AccountId(12341234), clientId1);
            var account2 = new Account(new AccountId(12341235), clientId2);
            var clientAccounts = new ClientAccounts();
            clientAccounts.Add(account1);
            Assert.Throws<ArgumentException>(() => clientAccounts.Add(account2));
        }

        [Test]
        public void ShouldBeAbleToFindTwoClientAccountsShareACommonAccount()
        {
            var account1 = new Account(new AccountId(12341234), new ClientId("ABC123"));
            var account2 = new Account(new AccountId(12341235), new ClientId("ABC123"));
            var account3 = new Account(new AccountId(12341236), new ClientId("ABC123"));
            var account4 = new Account(new AccountId(12341237), new ClientId("ABC123"));
            
            var clientAccounts1 = new ClientAccounts();
            clientAccounts1.Add(account1);
            clientAccounts1.Add(account2);
            
            var clientAccounts2 = new ClientAccounts();
            clientAccounts2.Add(account1);
            clientAccounts2.Add(account3);

            var clientAccounts3 = new ClientAccounts();
            clientAccounts3.Add(account3);
            clientAccounts3.Add(account4);
            
            Assert.IsTrue(clientAccounts1.SharesAccountWith(clientAccounts2));
            Assert.IsFalse(clientAccounts1.SharesAccountWith(clientAccounts3));
        }
    }
}
