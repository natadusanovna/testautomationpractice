Feature: Contact Us
	In order to contact customer service
	As a user
	I want to be able to use contact us form
	
@mytag
Scenario: User can contact customer service 
	Given User opens contact us page
	When user fill all required field with 'webmaster'heading and QA kurs message
    And user submits the form
	Then message 'Your message has been successfully sent to our team.' is presented to the user
