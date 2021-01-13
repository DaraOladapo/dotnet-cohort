Feature: Car Service Feature

@Read
Scenario: Get all cars
	When I request for all cars
	Then the result has a list of cars
	And the result should be greater than 0
Scenario: Get one car
	Given an ID
	When I request for a car
	Then the result has a car