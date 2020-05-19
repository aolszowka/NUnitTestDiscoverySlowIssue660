using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLibrary1
{
    [TestFixture]
    public class TestLibrary1
    {
        [TestCaseSource(nameof(TestLibrary1.Tests))]
        public void BlahTest()
        {
            Assert.True(true);
        }

        public static IEnumerable<TestCaseData> Tests()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return new TestCaseData().SetName($"TestNumber{i}");
            }
        }
    }
}
