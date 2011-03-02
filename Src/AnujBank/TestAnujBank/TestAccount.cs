﻿using System;
using AnujBank;
using Moq;
using NUnit.Framework;

namespace TestAnujBank
{
    [TestFixture]
    public class TestAccount
    {
        [Test]
        public void ShouldBeAbleToCreateAnAccount()
        {
            var clientId = new ClientId("ABC123");
            var account = new Account(new AccountId(12341234), clientId)
                              {Balance = 100.00, LastUpdatedDate = DateTime.Now};
            Assert.AreEqual(account.GetAccountNumber(), 12341234);
        }

        [Test]
        public void ShouldBeAbleRaiseErrorInCaseNoClientProvided()
        {
            try
            {
                new Account(new AccountId(12341234), null) { Balance = 100.00, LastUpdatedDate = DateTime.Now };
                throw new Exception("Account Created");
            }
            catch (ArgumentException)
            {
                
                
            }
            
        }
        [Test]
        public void ShouldBeAbleToSaveAccount()
        {
            var account = new Account(new AccountId(12341234), new ClientId("ABC123")) { Balance = 100.00, LastUpdatedDate = DateTime.Now };
            
            var mockRepository=new Mock<IRepository>();

           mockRepository.Setup(repo => repo.Save(account));

            Feed feed = new Feed(mockRepository.Object);
            feed.Process();

            mockRepository.Verify(repo => repo.Save(account));

        }
        [Test]
        public void ShouldBeAbleToProcessFeed()
        {
          //  Feed feed = Feed.load();
            //feed.process();

        }
    }
}
