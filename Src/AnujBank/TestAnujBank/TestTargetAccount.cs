using System;
using AnujBank;
using NUnit.Framework;

namespace TestAnujBank
{
    [TestFixture]
    class TestTargetAccount
    {

        [Test]
        public void ShouldNotBeAbleToCreateATargetAccountWithAccountAndAllocationPercentage()
        {
            var account = new Account(new AccountId(12345678), new ClientId("ABC123"))
                                  {Balance = 100, LastUpdatedDate = DateTime.Now};
            var targetAccount = new TargetAccount(account, 2);
            Assert.AreEqual(targetAccount.GetAccountNumber(), account.GetAccountNumber());
        }

        [Test]
        public void ShouldBeAbleToUpdateTheBalance()
        {
            var account = new Account(new AccountId(12345678), new ClientId("ABC123")) { Balance = 100, LastUpdatedDate = DateTime.Now };
            var targetAccount = new TargetAccount(account, 2);
            targetAccount.UpdateBalance(100);
            Assert.AreEqual(102, targetAccount.GetAmount());
        }
    }
}
