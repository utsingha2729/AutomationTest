Feature: GoogleSearchVerification
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Typing Search Query
	Given I am on Google page
	And I have entered 70 into the calculator
	When I type hello world in Search Box
	Then I should see Hello world in search Box
