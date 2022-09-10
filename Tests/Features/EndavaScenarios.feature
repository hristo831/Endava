Feature: EndavaScenarios
	Implement Endava scenarios

Background: 
	Given Navigate to Login page
		And Login with valid username and password
	
Scenario: Scenario 1
	Then I am redirected to the Inventory page with url "/inventory.html"
		And Page title is "PRODUCTS"
	When Add the first inventory item to the cart 
		And Add the last inventory item to the cart
		And Get the first and the last inventory items information
	Then "2" items are added to the shopping cart badge
	When Click shopping cart badge
	Then I am redirected to the Cart page with url "/cart.html"
		And Page title is "YOUR CART"
		And The first and the last items are added to the cart
	When Remove the first item
		And Click continue shopping
	Then I am redirected to the Inventory page with url "/inventory.html"
		And Page title is "PRODUCTS"
	When Add the penultimate inventory item to the cart
	And Get the penultimate and the last inventory items information
		And Click shopping cart badge
	Then The penultimate and the last items are added to the cart
	When Click checkout
	Then I am redirected to the Checkout Step One page with url "/checkout-step-one.html"
		And Page title is "CHECKOUT: YOUR INFORMATION"
	When Fill my information
	| FirstName | LastName | ZipCode |
	| Hristo    | Georgiev | 4000    |
		And Click Contunue
	Then I am redirected to the Checkout Step Two page with url "/checkout-step-two.html"
		And Page title is "CHECKOUT: OVERVIEW"
	When Click finish
	Then I am redirected to the Checkout Complete page with url "/checkout-complete.html"
		And Page title is "CHECKOUT: COMPLETE!"
	When Click shopping cart badge
	Then The cart is empty
	When Logout from the system
	Then I am redirected to the Login page with url "/"

Scenario: Scenario 2
	When Select price high to low
	Then The items are sorted from high to low price
	When Logout from the system
	Then I am redirected to the Login page with url "/"
