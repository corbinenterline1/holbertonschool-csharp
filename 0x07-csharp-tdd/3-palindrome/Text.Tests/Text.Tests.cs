using NUnit.Framework;
using System.Collections.Generic;

namespace Text.Tests
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void PalTest()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("level"));
        }
        [Test]
        public void PalCaseTest()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("Racecar"));
        }
        [Test]
        public void PalSpaceAndStuffTest()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("A man, a plan, a canal: Panama."));
        }
        [Test]
        public void PalEmptyTest()
        {
            Assert.IsTrue(Text.Str.IsPalindrome(""));
        }
    }
}i