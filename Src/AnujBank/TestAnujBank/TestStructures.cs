using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            Accounts accounts = new Accounts(new Account(),new Account());
            var structure = new Structure(accounts);
            var structures = new Structures();
            structures.Add(structure);

            Assert.True(structures.Contains(structure));
        } 
    }
}
