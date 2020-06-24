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

        [TestMethod]
        public void BookProcess()
        {
            // MOQ can be used to mock object
            Product _Project = new Product();
            _Project.Name = "Book Product";
            _Project.Description = "My Test book Product";

            Order _Order = new Order();
            _Order.ProductItem = _Project;
            _Order.PaymentTypeIs = PaymentTypes.Book;

            IOrderFactory factory = new OrderFactory();

            IOrderProcess bookOrder = factory.GetOrder(1);


            int result = bookOrder.ProcessOrder();

            Assert.Equals(result, 1);
        }


        [TestMethod]
        public void MemberShipProcess()
        {
            // MOQ can be used to mock object
            Product _Project = new Product();
            _Project.Name = "Membership order";
            _Project.Description = "Membership";

            Order _Order = new Order();
            _Order.ProductItem = _Project;
            _Order.PaymentTypeIs = PaymentTypes.MemberShip;

            IOrderFactory factory = new OrderFactory();

            IOrderProcess bookOrder = factory.GetOrder(2);


            int result = bookOrder.ProcessOrder();

            Assert.Equals(result, 2);
        }


        [TestMethod]
        public void UpgradeProcess()
        {
            // MOQ can be used to mock object
            Product _Project = new Product();
            _Project.Name = "Upgrade Product";
            _Project.Description = "My Test Physical Product";

            Order _Order = new Order();
            _Order.ProductItem = _Project;
            _Order.PaymentTypeIs = PaymentTypes.Upgrade;

            IOrderFactory factory = new OrderFactory();

            IOrderProcess bookOrder = factory.GetOrder(3);


            int result = bookOrder.ProcessOrder();

            Assert.Equals(result, 3);
        }


        [TestMethod]
        public void VideoProcess()
        {
            // MOQ can be used to mock object
            Product _Project = new Product();
            _Project.Name = "Video ";
            _Project.Description = "Video

            Order _Order = new Order();
            _Order.ProductItem = _Project;
            _Order.PaymentTypeIs = PaymentTypes.Video;

            IOrderFactory factory = new OrderFactory();

            IOrderProcess bookOrder = factory.GetOrder(4);


            int result = bookOrder.ProcessOrder();

            Assert.Equals(result, 4);
        }
    }
}
