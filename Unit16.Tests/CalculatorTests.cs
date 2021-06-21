using NUnit.Framework;
using System;

namespace Unit16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(20, 10) == 30);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(30, 10) == 20);
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Miltiplication(10, -25) == -250);
        }

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(300, 11) == 27);
        }

        [Test]
        public void Division_MustThrow_Exception()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }
    }
}
