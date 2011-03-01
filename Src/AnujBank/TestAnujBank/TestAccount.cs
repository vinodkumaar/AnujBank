using System;
using AnujBank;
using NUnit.Framework;

namespace TestAnujBank
{
    [TestFixture]
    public class TestAccount
    {
        [Test]
        public void ShouldBeAbleToCreateAnAccount()
        {
            var client = new Client(new ClientID("ABCD1234"));
            var account = new Account(new AccountId(12341234), client)
                              {Balance = 100.00, LastUpdatedDate = DateTime.Now};
            Assert.AreEqual(account.GetAccountNumber(), 12341234);
        }
        [Test, ExpectedException(typeof(NoClientException))]
        public void ShouldBeAbleRaiseErrorInCaseNoClientProvided()
        {
            var account = new Account(new AccountId(12341234), null) { Balance = 100.00, LastUpdatedDate = DateTime.Now };
        }
    }
}
