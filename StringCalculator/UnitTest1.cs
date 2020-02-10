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
            var sum = StringCalculator.Add("");

            Assert.AreEqual(0, sum);
        }

        [Test]
        public void ShouldBeReturnTheSameReceiveNumber()
        {
            var sum = StringCalculator.Add("1");

            Assert.AreEqual(1, sum);
        }

        [Test]
        public void ShouldBeReturnTheAdditionOfReceiveNumbers()
        {
            var sum = StringCalculator.Add("1, 4");

            Assert.AreEqual(5, sum);
        }

    }
}