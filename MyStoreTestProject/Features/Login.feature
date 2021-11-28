Feature: As a User I should be able to log in to the site
	Test user log in and log out scenarios

Background: User goes to the My Store site 
	Given the User navigates to http://automationpractice.com/


Scenario: Log in and Log Out functionality
	When the User clicks on Sign In Button at the top right 
	And the User inputs the correct credentials
	And the User clicks on the green Sign In button
	Then the User should be able to enter their account

	When the User clicks logout
	Then the User is signed out and directed back to login page


Scenario: Log in with Incorrect Credentials and test other negative scenarios
	When the User clicks on Sign In Button at the top right 
	And the User enters an incorrect User Name and Password
	And the User clicks on the green Sign In button
	Then an authentication error should appear 

	When the User inputs an email with an incorrect format
	Then an Invalid Email Address error should appear

	When the User leaves the password blank
	Then a Password is Required error should appear

		
	