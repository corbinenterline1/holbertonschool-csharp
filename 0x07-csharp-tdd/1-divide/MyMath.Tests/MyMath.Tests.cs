using NUnit.Framework;
using System;
using MyMath;

namespace MyMath.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void DivTest()
        {
            int dn = 2;
            int[,] matrix = new int[2, 2]
            {
                {100, 66}, {50, 14}
            };
            int[,] div_res = Matrix.Divide(matrix, dn);
            Assert.AreEqual(new int[2, 2]
            {
                {50, 33}, {25, 7}
            }, div_res);
        }
        [Test]
        public void DivZeroTest()
        {
            int dn = 2;
            int[,] matrix = null;
            int[,] div_res = Matrix.Divide(matrix, dn);
            Assert.AreEqual(null, div_res);
        }
        [Test]
        public void DivNullTest()
        {
                int dn = 0;
                int[,] matrix = new int[2, 2]
                {
                    {100, 66}, {50, 14}
                };
                int[,] div_res = Matrix.Divide(matrix, dn);
                Assert.AreEqual(null, div_res);
        }
    }
}