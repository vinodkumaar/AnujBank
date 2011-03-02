using System;
using AnujBank;
using NUnit.Framework;

namespace TestAnujBank
{
    [TestFixture]
    class TestAccountId
    {
        [Test]
        public void ShouldBeAbleToCreateAccountIdWithEightDigits()
        {
            var accountId = new AccountId(98765412);

        }
        [Test]
        public void ShouldNotCreateAccountIdWithAnythingOtherThenEightDigits()
        {
            try
            {
                new AccountId(654388);
                throw new Exception("Account Created");

            }
            catch (InvalidAccountIdException)
            {
                
            }
            

        }
    }
}
