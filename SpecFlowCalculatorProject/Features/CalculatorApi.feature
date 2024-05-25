Feature: CalculatorApi

Calls to Calculator api

@tag1
Scenario: Add two numbers
	Given first api number is 5
	And second api number is 7
	When two numbers are added by Api
	Then the result is 12