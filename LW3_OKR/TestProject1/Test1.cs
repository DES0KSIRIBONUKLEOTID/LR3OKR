using LW3_OKR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Tests
{
    [TestClass]
    public class OrderTests
    {
        [TestMethod]
        public void AddItem_WorksCorrectly()
        {
            var client = new Form1.Client(1, "Test", "000", "-");
            var order = new Form1.Order(client);

            var goods = new Goods { Name = "Sushi", Quantity = 100 };

            order.AddItem(goods);

            Assert.AreEqual(1, order.Items.Count);
        }

        [TestMethod]
        public void GetItemsSum_ReturnsCorrectSum()
        {
            var client = new Form1.Client(1, "Test", "000", "-");
            var order = new Form1.Order(client);

            order.AddItem(new Goods { Name = "Sushi", Quantity = 120 });
            order.AddItem(new Goods { Name = "Roll", Quantity = 80 });

            Assert.AreEqual(200, order.GetItemsSum());
        }

        [TestMethod]
        public void GetTotal_IncludesTips()
        {
            var client = new Form1.Client(1, "Test", "000", "-");
            var order = new Form1.Order(client);

            order.AddItem(new Goods { Name = "Tea", Quantity = 50 });
            order.Tips = 20;

            Assert.AreEqual(70, order.GetTotal());
        }

        [TestMethod]
        public void Order_HasCorrectClient()
        {
            var client = new Form1.Client(10, "Ivan", "123", "mail@ex.com");
            var order = new Form1.Order(client);

            Assert.AreEqual("Ivan", order.Client.Name);
        }
    }


    // ===== RESTAURANT TESTS =====

    [TestClass]
    public class RestaurantTests
    {
        [TestMethod]
        public void AddIncome_IncreasesTotalIncome()
        {
            var r = new Form1.Restaurant("Sushi Bar", "Kyiv");
            r.AddIncome(new Form1.Income(DateTime.Now, "Sale", 300));
            r.AddIncome(new Form1.Income(DateTime.Now, "Sale", 200));

            Assert.AreEqual(500, r.GetTotalIncome());
        }

        [TestMethod]
        public void AddExpense_IncreasesTotalExpense()
        {
            var r = new Form1.Restaurant("Sushi Bar", "Kyiv");
            r.AddExpense(new Form1.Expense(DateTime.Now, "Rice", 150));
            r.AddExpense(new Form1.Expense(DateTime.Now, "Fish", 250));

            Assert.AreEqual(400, r.GetTotalExpense());
        }

        [TestMethod]
        public void GetProfit_CalculatesCorrectly()
        {
            var r = new Form1.Restaurant("Sushi Bar", "Kyiv");

            r.AddIncome(new Form1.Income(DateTime.Now, "Sale", 600));
            r.AddExpense(new Form1.Expense(DateTime.Now, "Rent", 400));

            Assert.AreEqual(200, r.GetProfit());
        }
    }


    // ===== NETWORK TESTS =====

    [TestClass]
    public class RestaurantNetworkTests
    {
        [TestMethod]
        public void AddRestaurant_IncreasesCount()
        {
            var network = new Form1.RestaurantNetwork("Good Sushi");

            network.AddRestaurant(new Form1.Restaurant("S1", "Kyiv"));
            network.AddRestaurant(new Form1.Restaurant("S2", "Lviv"));

            Assert.AreEqual(2, network.Restaurants.Count);
        }

        [TestMethod]
        public void GetTotalProfit_SumsAllRestaurants()
        {
            var network = new Form1.RestaurantNetwork("Network");

            var r1 = new Form1.Restaurant("S1", "Kyiv");
            r1.AddIncome(new Form1.Income(DateTime.Now, "Sale", 1000));
            r1.AddExpense(new Form1.Expense(DateTime.Now, "Rent", 400));

            var r2 = new Form1.Restaurant("S2", "Lviv");
            r2.AddIncome(new Form1.Income(DateTime.Now, "Sale", 800));
            r2.AddExpense(new Form1.Expense(DateTime.Now, "Fish", 300));

            network.AddRestaurant(r1);
            network.AddRestaurant(r2);

            Assert.AreEqual(1100, network.GetTotalProfit());
        }
    }
}
