using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TristanReilly_S00199625;

namespace UnitTestProjectDecreasePrice
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDecreasePrice()
        {
            //ARRANGE
            Game g1 = new Game();
            g1.Price = 50;
            decimal expectedPrice = 40;

            //ACT
            g1.DecreasePrice(10);

            //ASSERT
            Assert.AreEqual(expectedPrice, g1.Price);
        }
    }
}
