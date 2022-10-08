Feature: Search
	In order to find for a term
	As a user
	I want to able to search a term
	
@mytag
Scenario: Add two numbers
	Given User enters search 'dress' term
	When user submits the search
	Then the result for search 'dress' term are displayed
