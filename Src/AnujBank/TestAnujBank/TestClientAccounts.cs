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
         Assert.Throws<ArgumentException>(() => new ClientAccounts(account1, account2));
      }
   }
}
