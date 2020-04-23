Feature: register
	In order to avoid silly mistakes
	I want to test register page

@SmokeTest
@Browser:Chrome
Scenario: Register page
	Given I have navigated to Register page
	And I see Register page is fully loaded
	When I type data as
	| FirstName | LastName | Email           | Password |
	| mda       | ahsan    | ahsan@gmail.com | ahsan123 |
	Then It should register