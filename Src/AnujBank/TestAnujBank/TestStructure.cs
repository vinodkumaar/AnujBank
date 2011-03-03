using System;
using AnujBank;
using NUnit.Framework;

namespace TestAnujBank
{
    [TestFixture]
    public class TestStructure
    {
        [Test]
        public void ShouldNotBeAbleToCreateAStructureWithLessThanTwoSourceAccounts()
        {
            var clientId = new ClientId("ABC123");
            var account1 = new Account(new AccountId(12341234), clientId);
            var clientAccounts = new ClientAccounts();
            clientAccounts.Add(account1);
            Assert.Throws<ArgumentException>(() => new Structure(clientAccounts));
        }

        [Test]
        public void ShouldBeAbleToFindIfTwoStructuresHaveSharedAccounts()
        {
            var clientId = new ClientId("ABC123");
            var account1 = new Account(new AccountId(12341234), clientId);
            var account2 = new Account(new AccountId(12341235), clientId);
            var account3 = new Account(new AccountId(12341236), clientId);
            var account4 = new Account(new AccountId(12341237), clientId);

            var clientAccounts1 = new ClientAccounts();
            clientAccounts1.Add(account1);
            clientAccounts1.Add(account2);
            var structure1 = new Structure(clientAccounts1);

            var clientAccounts2 = new ClientAccounts();
            clientAccounts2.Add(account1);
            clientAccounts2.Add(account3);
            var structure2 = new Structure(clientAccounts2);
            
            var clientAccounts3 = new ClientAccounts();
            clientAccounts3.Add(account4);
            clientAccounts3.Add(account3);
            var structure3 = new Structure(clientAccounts3);

            Assert.IsTrue(structure1.SharesASourceAccountWith(structure2));
            Assert.IsFalse(structure1.SharesASourceAccountWith(structure3));

        }
    }
}
