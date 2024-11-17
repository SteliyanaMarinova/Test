using PositiveNegativeNum;

namespace TestProjectPositiveNegativeNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsPositiveReturnPositive()
        {
            //Arrange
            double number = 5;
            Num num = new Num();

            //Act
            bool result = num.IsPositive(number);

            //Assert
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void TestIsPositiveReturnNegative()
        {
            //Arrange
            double number = -5;
            Num num = new Num();

            //Act
            bool result = num.IsPositive(number);

            //Assert
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void TestIsPositiveReturnThrowException()
        {
            //Arrange
            double number = 0;
            Num num = new Num();

            //Act
            //bool result = num.IsPositive(number);

            //Assert
            Assert.ThrowsException<ArgumentException>(() => num.IsPositive(number));
        }
    }
}
