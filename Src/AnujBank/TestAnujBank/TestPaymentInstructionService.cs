using System;
using System.IO;
using System.Xml;
using AnujBank;
using NUnit.Framework;

namespace TestAnujBank
{
    public class TestPaymentInstructionService
    {
        [Test]
        public void PaymentInstructionServiceShouldBeAbleToCreateOutPutDirectoryAndFile()
        {
            var payment = new Payment("someaccount", 100.50M, DateTime.Now);
            var paymentInstructionService= new PaymentInstructionService();
            if (Directory.Exists(paymentInstructionService.OutputPath))
            Directory.Delete(paymentInstructionService.OutputPath,true);
            paymentInstructionService.Generate(payment);
            Assert.True(Directory.Exists(paymentInstructionService.OutputPath));
            Assert.True(File.Exists(paymentInstructionService.OutputPath + 1+".xml"));
        }

        [Test]
        public void ShouldBeAbleToGenerateOutputWithValidPaymentObject()
        {

            var payment = new Payment("someaccount", 100.50M, DateTime.Parse("2011-03-01T17:01:37.9575406+05:30"));
            var paymentInstructionService = new PaymentInstructionService();
            paymentInstructionService.Generate(payment);
            using (XmlReader xmlReader = new XmlTextReader(paymentInstructionService.OutputPath + 1 + ".xml"))
            {
                string name = "";
                int elementCount = 0;
                while (xmlReader.Read())
                {
                    XmlNodeType xmlNodeType = xmlReader.NodeType;
                    switch (xmlNodeType)
                    {
                        case XmlNodeType.Element:
                            name = xmlReader.Name;
                            break;
                        case XmlNodeType.Text:
                            switch (name)
                            {
                                case "account":
                                    Assert.AreEqual(payment.Account, xmlReader.Value);
                                    elementCount++;
                                    break;
                                case "amount":
                                    Assert.AreEqual(Math.Abs(payment.Amount).ToString(), xmlReader.Value);
                                    elementCount++;
                                    break;
                                case "date":
                                    Assert.AreEqual("2011-03-01T17:01:37.9575406+05:30", xmlReader.Value);
                                    elementCount++;
                                    break;
                                case "type":
                                    Assert.AreEqual(payment.GetTransactionType(), xmlReader.Value);
                                    elementCount++;
                                    break;
                            }
                            break;
                    }

                }
                Assert.AreEqual(4, elementCount);
            }
           
            
           
           
        }

    }
}
