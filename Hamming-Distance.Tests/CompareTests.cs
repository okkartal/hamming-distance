namespace Hamming_Distance.Tests;

[TestClass]
public class CompareTests
{
    [TestMethod]
    public void ShouldSupportBuffers()
    {
        var distance = Compare.HammingDistance(new byte[] { 0x00, 0x00 }, new byte[] { 0x00, 0x0F });
        Assert.AreEqual(4, distance);
    }

    [TestMethod]
    public void ShouldSupportHexStrings()
    {
        var distance = Compare.HammingDistance("11011001", "10011101");
        Assert.AreEqual(2, distance);
    }
}