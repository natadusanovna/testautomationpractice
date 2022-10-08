Feature: Search
	In order to avofind products
	As a user
	I want to be able to search for a term
	
@mytagUser
    Scenario: can search for a term s
	Given user enters 'dress' search term
	When user submits the search
	Then results for 'dress' search term are displayed
