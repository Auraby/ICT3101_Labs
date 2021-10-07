Feature: UsingCalculatorFactorial
	In order to calculate Factorial
	As a student doing the labs
	I want to be able to calculate factorial

@Factorial
Scenario: Normal Factorial
	Given I have a calculator
	When I have entered "5" into the calculator and press factorial
	Then the factorial result should be "120"


@Factorial
Scenario: Zero Factorial
	Given I have a calculator
	When I have entered "0" into the calculator and press factorial
	Then the factorial result should be 1