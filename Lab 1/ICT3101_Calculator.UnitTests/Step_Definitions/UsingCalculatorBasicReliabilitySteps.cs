using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorBasicReliabilitySteps
    {
        private readonly CalculatorPOCO _calculatorPOCO;

        private double initialFailureIntensity;
        private double timeT;
        private double currentFailureIntensity;
        private int avgexpectedFailure;

        public UsingCalculatorBasicReliabilitySteps(CalculatorPOCO calculatorPOCO)
        {
            this._calculatorPOCO = calculatorPOCO;
        }

        [Given(@"the initial failure intensity is ""(.*)""")]
        public void GivenTheInitialFailureIntensityIs(int p0)
        {
            initialFailureIntensity = p0;
        }
        
        [Given(@"the time t is ""(.*)""")]
        public void GivenTheTimeTIs(int p0)
        {
            timeT = p0;
        }
        
        [When(@"I entered average failure ""(.*)"" and total failures ""(.*)""")]
        public void WhenIEnteredAverageFailureAndTotalFailures(int p0, int p1)
        {
            currentFailureIntensity = _calculatorPOCO._calculator.CurrentFailureIntensity(initialFailureIntensity, p0, p1); 
        }
        
        [When(@"I entered the initial failure intensity ""(.*)"" and total failures ""(.*)""")]
        public void WhenIEnteredTheInitialFailureIntensityAndTotalFailures(int p0, int p1)
        {
            avgexpectedFailure = _calculatorPOCO._calculator.AvgExpectedFailures(timeT, p0, p1);
        }
        
        [Then(@"the current failure intensity is ""(.*)""")]
        public void ThenTheCurrentFailureIntensityIs(int p0)
        {
            Assert.That(currentFailureIntensity, Is.EqualTo(p0));
        }
        
        [Then(@"the average number of expected failures is ""(.*)""")]
        public void ThenTheAverageNumberOfExpectedFailuresIs(int p0)
        {
            Assert.That(avgexpectedFailure, Is.EqualTo(p0));
        }
    }
}
