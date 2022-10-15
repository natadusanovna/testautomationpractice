Feature: My Account
	In order to open sign in page
    As a registered user
    I want to be able to log in

	
	
@mytag
Scenario: User can log in
	Given user opens sign in page
    And enters correct credentials
	When user submits the login form
    Then user will be logged in

