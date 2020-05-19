using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestLibrary1
{
    [Parallelizable(ParallelScope.All)]
    [TestFixture]
    public class TestLibrary1
    {
        [TestCaseSource(nameof(TestLibrary1.Tests))]
        public void LargeTests()
        {
            Assert.True(true);
        }

        public static IEnumerable<TestCaseData> Tests()
        {
            for (int i = 0; i < 50000; i++)
            {
                yield return new TestCaseData().SetName($"TestNumber{i}");
            }
        }
    }
}
