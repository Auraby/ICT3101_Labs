using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {
        private readonly CalculatorPOCO _calculatorPOCO;

        private double _mbtfResult;
        private double _mttfResult;
        private double _mttrResult;
        private decimal _availability;
        private double _class;

        public UsingCalculatorAvailabilitySteps(CalculatorPOCO calculatorPOCO)
        {
            this._calculatorPOCO = calculatorPOCO;
        }


        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            _mbtfResult = _calculatorPOCO._calculator.Add(p0, p1);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTTF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTTF(int p0, int p1)
        {
            _mttfResult = _calculatorPOCO._calculator.Subtract(p0, p1);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTTR")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTTR(int p0, int p1)
        {
            _mttrResult = _calculatorPOCO._calculator.Subtract(p0, p1);
        }

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            _availability = _calculatorPOCO._calculator.Availability(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"" into the calculator and press Availability Class")]
        public void WhenIHaveEnteredIntoTheCalculatorAndPressSystemClass(double p0)
        {
            _class = _calculatorPOCO._calculator.AvailabilityClass(p0);
        }
        
        [Then(@"the MBTF result should be ""(.*)""")]
        public void ThenTheMTBFResultShouldBe(int p0)
        {
            Assert.That(_mbtfResult, Is.EqualTo(p0));
        }

        [Then(@"the MTTF result should be ""(.*)""")]
        public void ThenTheMTTFResultShouldBe(int p0)
        {
            Assert.That(_mttfResult, Is.EqualTo(p0));
        }

        [Then(@"the MTTR result should be ""(.*)""")]
        public void ThenTheMTTRResultShouldBe(int p0)
        {
            Assert.That(_mttrResult, Is.EqualTo(p0));
        }

        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(Decimal p0)
        {
            Assert.That(_availability, Is.EqualTo(p0));
        }

        [Then(@"the availability result should be 1")]
        public void ThenTheAvailabilityResultShouldBe()
        {
            Assert.That(_class, Is.EqualTo(1));
        }
    }
}
