Feature: AccountOperations
	In order to avoid silly mistakes
	I want to test all operations on account

@SmokeTest
@Browser:Chrome
Scenario:1 Login
    Given I have navigated to the Login page
	When I type the email and password
	| Email           | Password |
	| ahsan@gmail.com | ahsan123 |
	And I click login button

Scenario:2 Display Remainders
    When I click on Remainders
	Then Remainders should display

Scenario:3 Display Archive
    When I click on Archive
	Then Archive should display

Scenario:4 Display Trash
    When I click on Trash
	Then Trash should display

Scenario:5 Display Notes
    When I click on notes
	Then Notes should display

Scenario:6 List View
    When I click on ListView
	Then The notes should display in list

Scenario:7 Grid View
    When I click on GridView
	Then The notes should display in Grid

Scenario:8 Logout
    When I click on SignOut
	Then I should log out