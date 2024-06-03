using NUnit.Framework;
using System;

namespace Module_16_finaly.Tests
{
    public class Tests
    {
        Calculator calc = new Calculator();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalcAdditionTest()
        {
            Assert.AreEqual(8, calc.Additional(4, 5));
            //Assert.Pass();
        }
        [Test]
        public void CalcSubtractionTest()
        {
            Assert.AreEqual(1, calc.Subtraction(6, 5));
        }
        [Test]
        public void CalcMiltiplicationTest()
        {
            Assert.AreEqual(25, calc.Miltiplication(5, 5));
        }
        [Test]
        public void CalcDivisionTest()
        {
            Assert.That(calc.Division(9, 3) == 3);
        }
        [Test]
        public void CalcDivisionByZeroEceptionTest()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Division(8, 0));
        }
    }
}