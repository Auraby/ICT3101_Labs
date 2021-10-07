Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

@FailureIntensity
Scenario: Current Failure Intensity
	Given I have a calculator
	And the initial failure intensity is "10" 
	When I entered average failure "50" and total failures "100"
	Then the current failure intensity is "5"


@FailureIntensity
Scenario: Average number of expected failures
	Given I have a calculator
	And the time t is "10"
	When I entered the initial failure intensity "10" and total failures "100"
	Then the average number of expected failures is "63"
