using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Module16.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void SubtractionMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            NUnit.Framework.Assert.That(calculator.Subtraction(80, 80), Is.EqualTo(160));
        }
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var division = new Calculator();
            NUnit.Framework.Assert.Throws<DivideByZeroException>(() => division.Division(30, 0));
        }
    }
}
