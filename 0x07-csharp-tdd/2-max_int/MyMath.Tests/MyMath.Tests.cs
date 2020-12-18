using NUnit.Framework;
using System.Collections.Generic;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void MaxTest()
        {
            var test_list = new List<int>()
            {0, 55, 6969, 420, 42};
            int max = Operations.Max(test_list);
            Assert.AreEqual(max, 6969);
        }
        [Test]
        public void MaxZeroTest()
        {
            var test_list = new List<int>();
            int max = MyMath.Operations.Max(test_list);
            Assert.AreEqual(max, 0);
        }
    }
}