using LW3_OKR.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class OrdersTests
{
    [TestMethod]
    public void DefaultConstructor_ShouldInitializeFields()
    {
        var order = new Orders();

        Assert.AreEqual("", order.Number);
        Assert.IsNotNull(order.Items);
        Assert.AreEqual(0, order.Items.Count);
        Assert.AreEqual(0, order.Sum);
        Assert.AreEqual(0, order.Tip);
    }

    [TestMethod]
    public void ConstructorWithParameters_ShouldAssignValues()
    {
        var date = DateTime.Now;
        var order = new Orders("123", date, "pers1");

        Assert.AreEqual("123", order.Number);
        Assert.AreEqual(date, order.Date);
        Assert.AreEqual("pers1", order.PersonalId);
        Assert.IsNotNull(order.Items);
    }
}
