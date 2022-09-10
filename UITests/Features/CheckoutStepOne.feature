Feature: Checkout Spep One
	Implement tests for Checkout Spep One page

Background: 
	Given Navigate to Login page
		And Login with valid username and password
		And Add the first inventory item to the cart 
		And Add the last inventory item to the cart
		And Click shopping cart badge
		And  Click checkout

@CheckoutSpepOneTests
Scenario: Checkout order
	Then I am redirected to the Checkout Step One page with url "/checkout-step-one.html"
		And Page title is "CHECKOUT: YOUR INFORMATION"
	When Fill my information
	| FirstName | LastName | ZipCode |
	| Hristo    | Georgiev | 4000    |
		And Click Contunue
	Then I am redirected to the Checkout Step Two page with url "/checkout-step-two.html"
		And Page title is "CHECKOUT: OVERVIEW"