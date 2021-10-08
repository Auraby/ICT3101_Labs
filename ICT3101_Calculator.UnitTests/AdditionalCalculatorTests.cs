using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Moq;

namespace ICT3101_Calculator.UnitTests
{
    public class AdditionalCalculatorTests
    {
        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("../../../../ICT3101_Calculator/MagicNumbers.txt")).Returns(new string[8] { "4", "-2", "6", "1","-5", "10","8","-3" });
            _calculator = new Calculator();
        }

        //Lab 4
        [Test]
        public void GenMagicNum_WithValidChoice_ResultReturnsPositiveOfChoice()
        {
            //Act
            double result = _calculator.GenMagicNum(2, _mockFileReader.Object);

            //Assert
            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        public void GenMagicNum_WithValidChoice_NegativeResultReturnsPositiveOfChoice()
        {
            //Act
            double result = _calculator.GenMagicNum(1, _mockFileReader.Object);

            //Assert
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void GenMagicNum_WithInvalidChoice_ResultReturnZero()
        {
            //Act
            double result = _calculator.GenMagicNum(10, _mockFileReader.Object);

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
