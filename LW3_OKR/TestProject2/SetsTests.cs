using LW3_OKR.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class SetsTests
{
    [TestMethod]
    public void DefaultConstructor_ShouldInitializeFields()
    {
        var set = new Sets();

        Assert.AreEqual("", set.SetName);
        Assert.IsNotNull(set.GoodsIds);
        Assert.AreEqual(0, set.GoodsIds.Count);
    }

    [TestMethod]
    public void ConstructorWithParameters_ShouldAssignValues()
    {
        var goodsIds = new List<string> { "1", "2" };
        var set = new Sets("MegaSet", goodsIds);

        Assert.AreEqual("MegaSet", set.SetName);
        CollectionAssert.AreEqual(goodsIds, set.GoodsIds);
    }
}
