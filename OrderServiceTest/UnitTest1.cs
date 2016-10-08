using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using MyOrderTest;
using System.Collections.Generic;
namespace MyOrderTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void 計算Cost三組總合()
        {
            List<Order> orderList = GetOrderData();
 
            List<int> expected = new List<int>() {6, 15, 24, 21};
 
            IOrderService orderService = new OrderService();
            List<int> actual = orderService.CalculateTotal<Order>(orderList, 3, "Cost");
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod]
        public void 計算SellPrice四組總合()
        {
            List<Order> orderList = GetOrderData();

            List<int> expected = new List<int>() {90, 106, 90};

            IOrderService orderService = new OrderService();
            List<int> actual = orderService.CalculateTotal<Order>(orderList, 4, "SellPrice");

            CollectionAssert.AreEquivalent(expected, actual);
        }

        private static List<Order> GetOrderData()
        {
            List<Order> orderList = new List<Order>
            {
                new Order {Id=1,Cost=1,Revenue=11,SellPrice=21 },
                new Order {Id=2,Cost=2,Revenue=12,SellPrice=22 },
                new Order {Id=3,Cost=3,Revenue=13,SellPrice=23 },
                new Order {Id=4,Cost=4,Revenue=14,SellPrice=24 },
                new Order {Id=5,Cost=5,Revenue=15,SellPrice=25 },
                new Order {Id=6,Cost=6,Revenue=16,SellPrice=26 },
                new Order {Id=7,Cost=7,Revenue=17,SellPrice=27 },
                new Order {Id=8,Cost=8,Revenue=18,SellPrice=28 },
                new Order {Id=9,Cost=9,Revenue=19,SellPrice=29 },
                new Order {Id=10,Cost=10,Revenue=20,SellPrice=30 },
                new Order {Id=11,Cost=11,Revenue=21,SellPrice=31 }
            };
            
            return orderList;
        }
    }
}