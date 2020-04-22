Feature: login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@SmokeTest
@Browser:Chrome
Scenario: Login page
	Given I have navigated to login page
	And I see login page is fully loaded
	When I type email keyword as
	| Keyword         |
	| ahsan@gmail.com |
	And I type password keyword as
	| Keyword  |
	| ahsan123 |
	Then the result should be logged in