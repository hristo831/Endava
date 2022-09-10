Feature: Inventory
	Implement tests for Inventory page

Background: 
	Given Navigate to Login page
		And Login with valid username and password

@InventoryTests
Scenario: Add the first and the last items.
	When Add the first inventory item to the cart 
		And Add the last inventory item to the cart
		And Get the first and the last inventory items information
	Then "2" items are added to the shopping cart badge
	When Click shopping cart badge
	Then I am redirected to the Cart page with url "/cart.html"
		And Page title is "YOUR CART"
		And The first and the last items are added to the cart
		
