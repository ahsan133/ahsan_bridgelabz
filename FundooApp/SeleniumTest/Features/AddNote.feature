Feature: AddNote
	In order to avoid silly mistakes
	I want to test addNote

@SmokeTest
@Browser:Chrome
Scenario: Add Note
	Given I have navigated to Login page
	When I type email and password
	| Email           | Password |
	| ahsan@gmail.com | ahsan123 |
	And I click login
	Then It should log in
	When I give title and description
	| Title | Description |
	| hi    | whatsup     |
	Then the note should be added
