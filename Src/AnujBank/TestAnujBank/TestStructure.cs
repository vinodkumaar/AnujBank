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
         var accounts = new ClientAccounts(account1);
         Assert.Throws<ArgumentException>(() => new Structure(accounts));
      }
   }
}
