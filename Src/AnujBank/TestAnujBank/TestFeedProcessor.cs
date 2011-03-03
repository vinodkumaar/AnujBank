using System;
using System.IO;
using AnujBank;
using Moq;
using NUnit.Framework;

namespace TestAnujBank
{
    [TestFixture]
    public class TestFeedProcessor
    {
        [Test]
        public void ShouldBeAbleToProcessTheFeed()
        {
            var account = new Account(new AccountId(87654123), new ClientId("ABC823")) { Balance = 4000, LastUpdatedDate = DateTime.Now };
            var mockRepository = new Mock<IRepository>();
            var feedProcessor = new FeedProcessor(mockRepository.Object, "../../../Pickup/feed.csv");

            mockRepository.Setup(repo => repo.Save(account));
            feedProcessor.Process();
            mockRepository.Verify(repo => repo.Save(account));
        }

        [Test]
        public void ShouldNotProcessFeedIsFileNotFound()
        {
            try
            {
                new FeedProcessor(new Mock<IRepository>().Object, "feed.csv");
                throw new Exception("FeedProcessor Created");
            }
            catch (FileNotFoundException)
            {
            }
            catch(DirectoryNotFoundException)
            {
            }
        }
    }
}
