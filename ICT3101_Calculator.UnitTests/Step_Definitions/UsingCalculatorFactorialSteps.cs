using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorFactorialSteps
    {
        private readonly CalculatorPOCO _calculatorPOCO;
        private double _result;

        public UsingCalculatorFactorialSteps(CalculatorPOCO calculatorPOCO)
        {
            this._calculatorPOCO = calculatorPOCO;
        }

        [When(@"I have entered ""(.*)"" into the calculator and press factorial")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressFactorial(int p0)
        {
            _result = _calculatorPOCO._calculator.Factorial(p0);
        }
        
        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheFactorialShouldBe(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
        
        [Then(@"the factorial result should be 1")]
        public void ThenTheFactorialResultShouldBe()
        {
            Assert.That(_result, Is.EqualTo(1));
        }
    }
}
