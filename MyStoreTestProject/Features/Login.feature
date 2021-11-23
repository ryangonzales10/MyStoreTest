Feature: As a User I should be able to log in to the site

Background: User goes to the My Store site 
	Given the User navigates to http://automationpractice.com/


Scenario: Log in and Log Out functionality
	When the user clicks on Sign In Button at the top right 
	And the User inputs the correct credentials
	And the User clicks on the green Sign In button
	Then the User should be able to enter their accout