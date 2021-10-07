using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToSum()
        {
            //Act
            double result = _calculator.Subtract(10, 5);

            //Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Subtract_WhenSubtractingNegativeNumber_ResultEqualToSum()
        {
            //Act
            double result = _calculator.Subtract(5, -5);

            //Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToSum()
        {
            //Act
            double result = _calculator.Multiply(15, 3);

            //Assert
            Assert.That(result, Is.EqualTo(45));
        }

        [Test]
        [TestCase(0,54)]
        [TestCase(235,0)]
        public void Multiply_WhenMultiplyingByZero_ResultEqualToZero(int a, int b)
        {
            //Act
            double result = _calculator.Multiply(a,b);

            //Assert
            Assert.That(result, Is.EqualTo(0));
        }

        //Lab 1 Test for division
        /*[Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }*/

        //Lab 2 Test for division
        //Useful and needed scenarios already tested using BDD


        [Test]
        public void Factorial_WithPositiveInputs_Result()
        {
            //Act
            double result = _calculator.Factorial(5);

            //Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void Factorial_WithNegativeInputs_ResultThrowArgumentException()
        {
            //Act
            //Assert
            Assert.That(() => _calculator.Factorial(-5), Throws.ArgumentException);
        }

        [Test]
        public void Factorial_WithFractionInputs_ResultThrowArgumentException()
        {
            //Act
            //Assert
            Assert.That(() => _calculator.Factorial(23.5), Throws.ArgumentException);
        }


        //Area of triangle test
        [Test]
        public void AreaOfTriangle_WithPositiveInputs_ResultEqualToCalculation()
        {
            //Act
            double result = _calculator.AreaOfTriangle(4, 6);

            //Assert
            Assert.That(result, Is.EqualTo(12));
        }

        [Test]
        [TestCase(4, -2)]
        [TestCase(-6, 10)]
        [TestCase(0,5)]
        [TestCase(12,0)]
        public void AreaOfTriangle_WithNegativeInputs_ResultsThrowArgumentException(double a, double b)
        {
            //Act
            //Assert
            Assert.That(() => _calculator.AreaOfTriangle(a, b), Throws.ArgumentException);
        }


        //Area of circle test
        [Test]
        public void AreaOfCircle_WithPositiveRadius_ResultEqualToCalculation()
        {
            //Act
            double result = _calculator.AreaOfCircle(4);

            //Assert
            Assert.That(result, Is.EqualTo(50.24));
        }

        [Test]
        [TestCase(-5)]
        [TestCase(-85)]
        [TestCase(-200)]
        [TestCase(0)]
        public void AreaOfCircle_WithNegativeRadius_ResultThrowsArgumentException(double radius)
        {
            //Act
            //Assert
            Assert.That(() => _calculator.AreaOfCircle(radius), Throws.ArgumentException);
        }


        //TDD area
        #region Function A Tests
        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }


        #endregion

        #region Function B Tests
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }


        #endregion
    }
}