using System;
using System.Collections.Generic;
using System.Text;
using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass()]
    public class test2
    {
        public object VendingMechBalance { get; private set; }

        [TestMethod]
        public void TestChange()
        {
            VendingMech vending = new VendingMech();
            decimal vendingBalance = 1.00M;
            decimal expectedValue = 4;
            vending.MakeChange(vendingBalance);
            Assert.AreEqual(expectedValue, vending.MakeChange(vendingBalance));




        }

    }





}

