using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using OrderProcessingBL.Model;
using OrderProcessingBL;
using OrderProcessingBL.Enums;

namespace BLTest
{
    [TestClass]
    class OrderUnitTest
    {
        [TestMethod]
        public void PhysicalProductProcess()
        {
            // MOQ can be used to mock object
            Product _Project = new Product();
            _Project.Name = "Physical Product";
            _Project.Description = "My Test Physical Product";

            Order _Order = new Order();
            _Order.ProductItem = _Project;
            _Order.PaymentTypeIs = PaymentTypes.PhysicalProduct;

            IOrderFactory factory = new OrderFactory();

            IOrderProcess bookOrder = factory.GetOrder(0);
            

            int result = bookOrder.ProcessOrder();

            Assert.Equals(result, 0);
        }
    }
}
