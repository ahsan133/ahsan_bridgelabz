Feature: ForgotPassword
	In order to avoid silly mistakes
	I want to test forgotPassword page

@SmokeTest
@Browser:Chrome
Scenario: Forgot password
	Given I have navigated to ForgotPassword page
	And I see ForgotPassword page is fully loaded
	When I type email as
	| Email           |
	| ahsan@gmail.com |
	Then It should send mail
