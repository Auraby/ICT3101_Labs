using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{

    [Binding]
    public class CalculatorPOCO
    {
        public Calculator _calculator;
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }

    }

    [Binding]
    public class UsingCalculatorAdditionsSteps
    {
        private readonly CalculatorPOCO _calculatorPOCO;
        private double _result;

        public UsingCalculatorAdditionsSteps(CalculatorPOCO calculatorPOCO)
        {
            this._calculatorPOCO = calculatorPOCO;
        } 


        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _calculatorPOCO._calculator.Add(p0, p1);
        }
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}
