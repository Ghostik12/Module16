using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Module16.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            var subtraction = new Calculator();
            NUnit.Framework.Assert.That(subtraction.Subtraction(80, 80), Is.EqualTo(0));
        }
        [Test]
        public void DivisionMustReturnCorrectValue()
        {
            var division = new Calculator();
            NUnit.Framework.Assert.That(division.Division(80, 80), Is.EqualTo(1));
        }
        public void MiltiplicationMustReturnCorrectValue()
        {
            var miltiplication = new Calculator();
            NUnit.Framework.Assert.That(miltiplication.Miltiplication(80, 80), Is.EqualTo(6400));
        }
        public void AdditionalMustReturnCorrectValue()
        {
            var additional = new Calculator();
            NUnit.Framework.Assert.That(additional.Additional(80, 80), Is.EqualTo(160));
        }
    }
}
