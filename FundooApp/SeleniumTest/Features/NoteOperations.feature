Feature: NoteOperations
	In order to avoid silly mistakes
	I want to test all operations on note

@SmokeTest
@Browser:Chrome
Scenario:1 Add Note
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

Scenario:2 Add remainder
    When I click on add remainder
	Then the remainder is added

Scenario:3 Add collaborator
    When I type email
	| Email            |
	| mmmdas@gmail.com |
	And Click on save button
	Then the collaborator is added

Scenario:4 Change color
    When I click on a color
	Then the color is changed

Scenario:5 Add label
    When I click on add label
	And Enter the label
	| Label |
	| goods |
	Then the label is added

Scenario:6 Add archive
    When I click on add archive
	Then the note is added to archive