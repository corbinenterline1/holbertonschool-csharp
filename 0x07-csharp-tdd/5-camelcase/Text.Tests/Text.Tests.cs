using NUnit.Framework;
using System.Collections.Generic;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void CamelTest()
        {
            string a = "Camel";
            int b = Str.CamelCase(a);
            Assert.AreEqual(1, b);
        }
        [Test]
        public void BasicCamelTest()
        {
            string a = "camel";
            int b = Str.CamelCase(a);
            Assert.AreEqual(1, b);
        }
        [Test]
        public void CamelPartyTest()
        {
            string a = "CamelDamelzamelQamel";
            int b = Str.CamelCase(a);
            Assert.AreEqual(3, b);
        }
        [Test]
        public void EmptyCamelTest()
        {
            string a = "";
            int b = Str.CamelCase(a);
            Assert.AreEqual(0, b);
        }
        [Test]
        public void NullCamelTest()
        {
            string a = null;
            int b = Str.CamelCase(a);
            Assert.AreEqual(0, b);
        }
    }
}