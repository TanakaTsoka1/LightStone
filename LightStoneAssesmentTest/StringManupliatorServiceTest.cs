namespace LightStoneAssesmentTest;
using LightStoneAssesment;
[TestClass]
public class StringManupilatorServiceTest
{
    StringManupilatorService sm = new StringManupilatorService();
    [TestMethod]
    public void inputParse()
    {     
        int res = sm.inputParse("10");
        Assert.AreEqual(res, 10);
    }

    [TestMethod]
    public void printOut()
    {
        try
        {
            sm.inputParse("3");
            Assert.IsTrue(true);
        }
        catch
        {
            Assert.IsTrue(false);
        }
    }

    [TestMethod]
    public void stringManupilation()
    {
        try
        {
            sm.stringManupilation(3);
            Assert.IsTrue(true);
        }
        catch
        {
            Assert.IsTrue(false);
        }
    }
}
