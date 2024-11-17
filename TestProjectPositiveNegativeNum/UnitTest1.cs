using PositiveNegativeNum;

namespace TestProjectPositiveNegativeNum
{
    public class Tests
    {
        [TestFixture]
        public class NUnitTest
        {
            [Test]
            public void Setup()
            {
                Num number = new Num();
            }

            [TestCase(6)]
            [TestCase(1)]
            [TestCase(3.45)]
            [TestCase(12.221)]
            public void TestIsPositiveReturnTrue(double number)
            {
                Assert.IsTrue(true);
            }
            [TestCase(-6)]
            [TestCase(-1)]
            [TestCase(-3.45)]
            [TestCase(-12.221)]
            public void TestIsPositiveReturnFalse(double number)
            {
                Assert.IsFalse(false);
            }
            [TestCase(0)]
            public void TestIsPositiveRetureThrowException(double number)
            {
                Assert.IsFalse(false);
            }
        }
    }
}