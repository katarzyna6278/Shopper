Feature: Calculator

@AddHappyPath

Scenario: Add happy path
	Given first number is 1
	And second number is 2
	When two numbers are added
	Then the result is 3

Scenario: Subtract happy path
   Given first number is 2
   And second number is 1
   When two numbers are subtracted
   Then the result is 1

Scenario: Multiply happy path
   Given first number is 2
   And second number is 2
   When two numbers are multiply
   Then the result is 4
   
Scenario: Divide happy path
   Given first number is 4
   And second number is 2
   When two numbers are divided
   Then the result is 2