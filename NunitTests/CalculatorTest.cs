using NUnit.Framework;
using UnitTestPractise;

namespace NunitTests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void AddTwoNumbers_InptutAsTwoInteger()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.AddTwoNumbers(10, 20), Is.EqualTo(30));
            Assert.That(calculator.AddTwoNumbers(20, 10), Is.EqualTo(10));
        }
    }
}
