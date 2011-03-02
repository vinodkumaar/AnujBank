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
            var account1 = new Account();
            var accounts = new Accounts(account1);
            Assert.Throws<ArgumentException>(() => new Structure(accounts));
        }
    }
}
