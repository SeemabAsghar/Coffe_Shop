using Microsoft.VisualStudio.TestTools.UnitTesting;
using LAB_09;

namespace UnitTestOrder
{
    [TestClass]
    public class OrderFormTests
    {
        [TestMethod]
        public void Test_Order_OnlyCoffee()
        {
            var form = new OrderForm();
            decimal total = form.CalculateTotal(true, false);
            Assert.AreEqual(5.0m, total);
        }

        [TestMethod]
        public void Test_Order_OnlySandwich()
        {
            var form = new OrderForm();
            decimal total = form.CalculateTotal(false, true);
            Assert.AreEqual(7.0m, total);
        }

        [TestMethod]
        public void Test_Order_BothItems()
        {
            var form = new OrderForm();
            decimal total = form.CalculateTotal(true, true);
            Assert.AreEqual(12.0m, total);
        }

        [TestMethod]
        public void Test_Order_NoItem()
        {
            var form = new OrderForm();
            decimal total = form.CalculateTotal(false, false);
            Assert.AreEqual(0m, total);
        }

        [TestMethod]
        public void Test_Price_Update()
        {
            var form = new OrderForm();
            form.textBox1.Text = "6.0";
            form.textBox2.Text = "8.0";

            decimal total = form.CalculateTotal(true, true);
            Assert.AreEqual(14.0m, total);
        }
    }
}
