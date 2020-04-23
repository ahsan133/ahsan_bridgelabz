Feature: login
	In order to avoid silly mistakes
	I want to test login page

@SmokeTest
@Browser:Chrome
Scenario: Login page
	Given I have navigated to Login page
	And I see Login page is fully loaded
	When I type email Keyword as
	| Keyword         |
	| ahsan@gmail.com |
	And I type password Keyword as
	| Keyword  |
	| ahsan123 |
	Then It should log in