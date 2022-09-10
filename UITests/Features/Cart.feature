Feature: Cart
	Implement tests for Inventory page

Background: 
	Given Navigate to Login page
		And Login with valid username and password
		And Add the first inventory item to the cart 
		And Add the last inventory item to the cart
		And Click shopping cart badge

@CartTests
Scenario: Remove the first and add the penultimate item.
	When Remove the first item
		And Click continue shopping
	Then I am redirected to the Inventory page with url "/inventory.html"
		And Page title is "PRODUCTS"
	When Add the penultimate inventory item to the cart
	And Get the penultimate and the last inventory items information
		And Click shopping cart badge
	Then The penultimate and the last items are added to the cart



