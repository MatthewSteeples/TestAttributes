using System.Diagnostics;

namespace TestAttributes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Trace.WriteLine(nameof(TestMethodAttribute) + "." + nameof(TestMethod1));
        }
    }
}