namespace MethodPow2.Tests;

[TestClass]
public class XUnitTests
{
    [DataTestMethod]
    [DataRow(-3, 9)]
    [DataRow(0, 0)]
    [DataRow(12, 144)]
    public void TestPow2(int input, int expected)
    {
        int actual = Program.Pow2(input);
        Assert.AreEqual(expected, actual);
    }
}
