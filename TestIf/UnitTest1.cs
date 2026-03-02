using NUnit.Framework;
using iftry;
namespace TestIf
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FitsNormally()
        {
            var a = 2;
            var b = 3;
            var c = 5;
            var d = 6;

            var result = Logic.CanFit(a, b, c, d);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void NotFit()
        {
            var a = 7;
            var b = 8;
            var c = 5;
            var d = 6;

            var result = Logic.CanFit(a, b, c, d);

            Assert.AreEqual(false, result);
        }

        [Test]
        public void SameSize()
        {
            var a = 3;
            var b = 3;
            var c = 3;
            var d = 3;

            var result = Logic.CanFit(a, b, c, d);

            Assert.AreEqual(true, result);
        }
    }
}
