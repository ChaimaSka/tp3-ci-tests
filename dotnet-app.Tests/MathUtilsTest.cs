using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class MathUtilsTests
{
    [TestMethod]
    public void TestFactorial5()
    {
        Assert.AreEqual(0, MathUtils.Factorial(0));
    }
}