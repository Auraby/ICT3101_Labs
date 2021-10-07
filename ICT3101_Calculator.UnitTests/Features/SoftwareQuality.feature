Feature: SoftwareQuality
	In order to calculate Software Quality

@Defect
Scenario: Calculating Defect Density
    Given I have a calculator
    When I have entered "100" and "50" into the calculator and press Defect
    Then the defect density result should be "2.0"

@LogarithmicFailureIntensity
Scenario: Calculating failure intensity
    Given I have a calculator
    And the decay parameter is "0.02"
    When I entered the initial failure intensity "10" and number of failures experienced is "50"
    Then the number of experienced failures is "3.68"