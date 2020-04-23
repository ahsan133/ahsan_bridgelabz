Feature: AdminRegister
	In order to avoid silly mistakes
	I want to test adminRegister page

@SmokeTest
@Browser:Chrome
Scenario: AdminRegister page
	Given I have navigated to adminRegister page
	And I see adminRegister page is fully loaded
	When I type data for admin as
	| FirstName | LastName | Email           | Password |
	| mda       | ahsan    | ahsan@gmail.com | ahsan123 |
	Then It should register for admin