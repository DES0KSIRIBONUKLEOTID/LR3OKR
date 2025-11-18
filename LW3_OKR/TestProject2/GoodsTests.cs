using LW3_OKR.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class GoodsTests
{
    [TestMethod]
    public void DefaultConstructor_ShouldInitializeFields()
    {
        var goods = new Goods();

        Assert.AreEqual("", goods.Type);
        Assert.AreEqual("", goods.Name);
        Assert.AreEqual(0, goods.Quantity);
    }

    [TestMethod]
    public void ConstructorWithParameters_ShouldAssignValues()
    {
        var goods = new Goods("Sushi", "California", 10);

        Assert.AreEqual("Sushi", goods.Type);
        Assert.AreEqual("California", goods.Name);
        Assert.AreEqual(10, goods.Quantity);
    }
}