using System;
using AnujBank;
using NUnit.Framework;

namespace TestAnujBank
{
    [TestFixture]
    class TestStructures
    {
        [Test]
        public void ShouldBeAbleToAddAStructure()
        {
            var clientId = new ClientId("ABC123");
            var account1 = new Account(new AccountId(12341234), clientId);
            var account2 = new Account(new AccountId(12341235), clientId);
            var clientAccounts = new ClientAccounts();
            clientAccounts.Add(account1);
            clientAccounts.Add(account2);
            var structure = new Structure(clientAccounts);
            var structures = new Structures();
            structures.Add(structure);

            Assert.True(structures.Contains(structure));
        }

        [Test]
        public void ShouldNotBeAbleToCreateClientStructuresWithTwoRepeatingAccounts()
        {
            var clientId = new ClientId("ABC123");
            var account1 = new Account(new AccountId(12341234), clientId);
            var account2 = new Account(new AccountId(12341235), clientId);
            var account3 = new Account(new AccountId(12341236), clientId);
            var clientAccounts1 = new ClientAccounts();
            clientAccounts1.Add(account1);
            clientAccounts1.Add(account2);

            var clientAccounts2 = new ClientAccounts();
            clientAccounts2.Add(account1);
            clientAccounts2.Add(account3);

            var structure1 = new Structure(clientAccounts1);
            var structure2 = new Structure(clientAccounts2);

            var structures = new Structures();
            structures.Add(structure1);

            Assert.Throws<ArgumentException>(() => structures.Add(structure2));
        }
    }
}
