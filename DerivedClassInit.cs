using System.Diagnostics;

namespace TestAttributes
{
    [TestClass]
    public class DerivedClassInit : ClassInit
    {
        [ClassInitialize]
        public static void ClassInitMethod2(TestContext context)
        {
            Trace.WriteLine(nameof(ClassInitializeAttribute) + "." + nameof(ClassInitMethod2) + ": " + context.FullyQualifiedTestClassName + " - " + context.TestName);
        }

        [TestMethod]
        public void DerivedTestMethod1()
        {
            Trace.WriteLine(nameof(TestMethodAttribute) + "." + nameof(DerivedTestMethod1));
        }

        [TestMethod]
        public void DerivedTestMethod2()
        {
            Trace.WriteLine(nameof(TestMethodAttribute) + "." + nameof(DerivedTestMethod2));
        }

        [TestMethod]
        public void DerivedTestMethod3()
        {
            Trace.WriteLine(nameof(TestMethodAttribute) + "." + nameof(DerivedTestMethod3));
        }
    }
}
