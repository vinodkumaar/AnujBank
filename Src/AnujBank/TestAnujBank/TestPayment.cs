using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AnujBank;
using NUnit.Framework;

namespace TestAnujBank
{
    class TestPayment
    {
        [Test] 
        public void   ShouldNotCreatePaymentWhenAccountIsInvalid()
        {
            try
            {
                Payment payment = new Payment(null, 100.50M, DateTime.Parse("2011-03-01T17:01:37.9575406+05:30"));
                Assert.Fail();
            }
            catch (Exception)
            {
                
            }
           
        }
       
    }
}
