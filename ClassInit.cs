using System.Diagnostics;

namespace TestAttributes
{
    [TestClass]
    public class ClassInit
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            Trace.WriteLine(nameof(AssemblyInitializeAttribute) + "." + nameof(AssemblyInitialize) + ": " + context.FullyQualifiedTestClassName);
        }

        [ClassInitialize(InheritanceBehavior.BeforeEachDerivedClass)]
        public static void ClassInitMethod(TestContext context)
        {
            Trace.WriteLine(nameof(ClassInitializeAttribute) + "." + nameof(ClassInitMethod) + ": " + context.FullyQualifiedTestClassName + " - " + context.TestName);
        }

        [TestMethod]
        public void MyTestMethod1()
        {
            Trace.WriteLine(nameof(TestMethodAttribute) + "." + nameof(MyTestMethod1));
        }

        [TestMethod]
        public void MyTestMethod2()
        {
            Trace.WriteLine(nameof(TestMethodAttribute) + "." + nameof(MyTestMethod2));
        }

        [TestMethod]
        public void MyTestMethod3()
        {
            Trace.WriteLine(nameof(TestMethodAttribute) + "." + nameof(MyTestMethod3));
        }
    }
}
