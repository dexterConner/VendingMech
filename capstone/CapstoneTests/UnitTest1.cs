using Capstone;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass()]
    public class UnitTest1
    {
        public object VendingMechBalance { get; private set; }

        [TestMethod]
        public  void TestMakeChange()
        {
            VendingMech vending = new VendingMech();

            decimal vendingbalance = 0.00M;
            decimal expectedValue = 0.00M;
            vending.FinishTransactionMenu(vendingbalance);

            Assert.AreEqual(expectedValue, vending.FinishTransactionMenu(vendingbalance));




        }
    }
}
