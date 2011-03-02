using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnujBank;
using NUnit.Framework;

namespace TestAnujBank
{
    [TestFixture]
    class TestClientId
    {
        [Test]
        public void ShouldBeAbleToCreateClientIdWithStatringWithThreeAlphabetsFollowedByThreeDigits()
        {
            new ClientId("ABX899");
        }
        [Test]
        public void ShouldNotCreateClientIdWithAnythingOtherThenThreeAlphabetsFollowedByThreeDigits()
        {
            try
            {
                new ClientId("AB8899");
                throw new Exception("ClientId Created");

            }
            catch (InvalidClientIdException)
            {
                
                
            }
        }
    }
}
