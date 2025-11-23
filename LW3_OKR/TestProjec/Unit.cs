using LW3_OKR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjec
{
    public class NoMongoDbTests
    {
        [Fact]
        public void Orders_DefaultConstructor_ShouldInitValues()
        {
            var order = new Orders();

            Assert.Equal("", order.Number);
            Assert.NotNull(order.Items);
            Assert.Equal(0, order.Sum);
            Assert.Equal(0, order.Tip);
        }

        [Fact]
        public void Orders_Constructor_ShouldSetValues()
        {
            var date = new DateTime(2024, 1, 1);
            var order = new Orders("10", date, "123");

            Assert.Equal("10", order.Number);
            Assert.Equal(date, order.Date);
            Assert.Equal("123", order.PersonalId);
        }

        [Fact]
        public void Goods_DefaultConstructor_ShouldInitFields()
        {
            var g = new Goods();

            Assert.Equal("", g.Type);
            Assert.Equal("", g.Name);
            Assert.Equal(0, g.Quantity);
        }

        [Fact]
        public void Goods_Constructor_ShouldSetProperties()
        {
            var g = new Goods("Food", "Burger", 5);

            Assert.Equal("Food", g.Type);
            Assert.Equal("Burger", g.Name);
            Assert.Equal(5, g.Quantity);
        }

        [Fact]
        public void Sets_DefaultConstructor_ShouldInitList()
        {
            var set = new Sets();

            Assert.Equal("", set.SetName);
            Assert.NotNull(set.GoodsIds);
        }

        [Fact]
        public void Sets_Constructor_ShouldAssignValues()
        {
            var ids = new List<string>() { "1", "2" };

            var set = new Sets("Combo", ids);

            Assert.Equal("Combo", set.SetName);
            Assert.Equal(ids, set.GoodsIds);
        }
    }
}
