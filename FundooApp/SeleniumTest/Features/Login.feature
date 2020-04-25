Feature: login
	In order to avoid silly mistakes
	I want to test login page

@SmokeTest
@Browser:Chrome
Scenario: Login page
	Given I have navigated to Login page
	And I see Login page is fully loaded
	When I type email and password
	| Email           | Password |
	| ahsan@gmail.com | ahsan123 |
	And I click login
	Then It should log in