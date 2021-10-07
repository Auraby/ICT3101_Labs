Feature: UsingCalculatorAvailability
 In order to calculate MTBF and Availability
 As someone who struggles with math
 I want to be able to use my calculator to do this



@Availability
Scenario: Calculating MTBF
	 Given I have a calculator
	 When I have entered "200" and "10" into the calculator and press MTBF
	 Then the MBTF result should be "210"

@Availability
Scenario: Calculating MTTF
	 Given I have a calculator
	 When I have entered "210" and "10" into the calculator and press MTTF
	 Then the MTTF result should be "200"

@Availability
Scenario: Calculating MTTR
	 Given I have a calculator
	 When I have entered "210" and "200" into the calculator and press MTTR
	 Then the MTTR result should be "10"


@Availability
Scenario: Calculating Availability
	 Given I have a calculator
	 When I have entered "200" and "210" into the calculator and press Availability
	 Then the availability result should be "95.2"


@Availability
Scenario: Get Calculator Availability Class
	 Given I have a calculator
	 When I have entered "95.2" into the calculator and press Availability Class
	 Then the availability result should be 1