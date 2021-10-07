using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class SoftwareQualitySteps
    {
        private readonly CalculatorPOCO _calculatorPOCO;

        private double decayParam;

        private double defectDensity;
        private decimal experiencedFailures;


        public SoftwareQualitySteps(CalculatorPOCO calculatorPOCO)
        {
            this._calculatorPOCO = calculatorPOCO;
        }

        

        [Given(@"the decay parameter is ""(.*)""")]
        public void GivenTheDecayParameterIs(Decimal p0)
        {
            decayParam = (double)p0;
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Defect")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDefect(int p0, int p1)
        {
            defectDensity = _calculatorPOCO._calculator.Divide(p0,p1);
        }
        
        [When(@"I entered the initial failure intensity ""(.*)"" and number of failures experienced is ""(.*)""")]
        public void WhenIEnteredTheInitialFailureIntensityAndNumberOfFailuresExperiencedIs(int p0, int p1)
        {
            experiencedFailures = _calculatorPOCO._calculator.CurrentFailureIntensityLogModel(p0, decayParam, p1);
        }
        
        [Then(@"the defect density result should be ""(.*)""")]
        public void ThenTheDefectDensityResultShouldBe(Decimal p0)
        {
            Assert.That(defectDensity, Is.EqualTo(p0));
        }
        
        [Then(@"the number of experienced failures is ""(.*)""")]
        public void ThenTheNumberOfExperiencedFailuresIs(Decimal p0)
        {
            Assert.That(experiencedFailures, Is.EqualTo(p0));
        }
    }
}
