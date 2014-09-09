using System.Runtime.CompilerServices;
using System.Threading;
using NUnit.Framework;


namespace NunitParallelTestExperimentsAssembly2
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class ParallelTestExperimentsAssembly2Fixture2
    {
        private static void TestHelper(int delay, [CallerMemberName] string callerMemberName = "--unknown--")
        {
            TestContext.WriteLine("Starting Parallel Test {0}", callerMemberName);
            TestContext.WriteLine("Waiting for {0}ms.", delay);
            Thread.Sleep(delay);
            TestContext.WriteLine("Finishing Parallel Test {0}", callerMemberName);

        }

        [Test]
        [Parallelizable(ParallelScope.Fixtures)]
        public void ParallelTest1_Assembly2_Fixture2()
        {
            TestHelper(5000);
        }

        [Test]
        [Parallelizable(ParallelScope.Fixtures)]
        public void ParallelTest2_Assembly2_Fixture2()
        {
            TestHelper(5000);
        }

        [Test]
        [Parallelizable(ParallelScope.Fixtures)]
        public void ParallelTest3_Assembly2_Fixture2()
        {
            TestHelper(5000);
        }

        [Test]
        [Parallelizable(ParallelScope.Fixtures)]
        public void ParallelTest4_Assembly2_Fixture2()
        {
            TestHelper(5000);
        }

        [Test]
        [Parallelizable(ParallelScope.Fixtures)]
        public void ParallelTest5_Assembly2_Fixture2()
        {
            TestHelper(5000);
        }

        [Test]
        [Parallelizable(ParallelScope.Fixtures)]
        public void ParallelTest6_Assembly2_Fixture2()
        {
            TestHelper(5000);
        }
    }
}
