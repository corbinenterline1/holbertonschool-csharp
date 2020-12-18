using NUnit.Framework;
using System.Collections.Generic;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void UniqCharTest()
        {
            string a = "dddedflkjd";
            int b = Str.UniqueChar(a);
            Assert.AreEqual(3, b);
        }
        [Test]
        public void SameCharTest()
        {
            string a = "dddddddd";
            int b = Str.UniqueChar(a);
            Assert.AreEqual(-1, b);
        }
        [Test]
        public void NoCharTest()
        {
            string a = "";
            int b = Str.UniqueChar(a);
            Assert.AreEqual(-1, b);

        }
        [Test]
        public void NullCharTest()
        {
            string a = null;
            int b = Str.UniqueChar(a);
            Assert.AreEqual(-1, b);
        }
    }
}