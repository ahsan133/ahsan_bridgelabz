Feature: AdminLogin
	I want to test login page

@SmokeTest
@Browser:Chrome
Scenario: AdminLogin page
	Given I have navigated to AdminLogin page
	And I see AdminLogin page is fully loaded
	When I type email Keyword for admin as
	| Keyword         |
	| ahsan@gmail.com |
	And I type password Keyword for admin as
	| Keyword  |
	| ahsan123 |
	Then It should log in as admin