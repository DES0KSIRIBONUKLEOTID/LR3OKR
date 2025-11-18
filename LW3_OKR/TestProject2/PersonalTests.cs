using LW3_OKR.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
[TestClass]
public class PersonalTests
{
    [TestMethod]
    public void DefaultConstructor_ShouldInitializeStrings()
    {
        var p = new Personal();

        Assert.AreEqual("", p.SurName);
        Assert.AreEqual("", p.Name);
        Assert.AreEqual("", p.Position);
        Assert.AreEqual("", p.Stat);
    }

    [TestMethod]
    public void ConstructorWithParameters_ShouldAssignValues()
    {
        var p = new Personal("Ivanov", "Ivan", "Chef", "Active");

        Assert.AreEqual("Ivanov", p.SurName);
        Assert.AreEqual("Ivan", p.Name);
        Assert.AreEqual("Chef", p.Position);
        Assert.AreEqual("Active", p.Stat);
    }
}
