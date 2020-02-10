using NUnit.Framework;

namespace StringCalculator
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ShouldBeReturnZeroWhenReceiveEmpty()
        {
            int sum = StringCalculator.Calculator("");

            Assert.AreEqual(0, sum);
        }

        [Test]
        public void ShouldBeReturnTheSameReceiveNumber()
        {
            int sum = StringCalculator.Calculator("1");

            Assert.AreEqual(1, sum);
        }

        [Test]
        public void ShouldBeReturnTheAdditionOfReceiveNumbers()
        {
            int sum = StringCalculator.Calculator("1, 4");

            Assert.AreEqual(5, sum);
        }

    }
}