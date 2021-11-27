Feature: As a User, I should be able to purchase an item
	End-to-end test for purchasing an item

Background: User goes to the My Store site 
	Given the User navigates to http://automationpractice.com/

Scenario: Check if Quick View works
	Given the User clicks Quick View
	Then the Item's description, price and add to cart button should appear
