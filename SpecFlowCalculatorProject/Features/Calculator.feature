Feature: Calculator

@AddHappyPath

Scenario: Add happy path
	Given first number is 1
	And second number is 2
	When two numbers are added
	Then the result is 3
