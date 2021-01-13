Feature: Car
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Get cars
	When I request for list of cars
	Then the response has a list of cars
Scenario: Get car
	Given an ID of Guid Type
	When I request for a car
	Then the result should be a Car