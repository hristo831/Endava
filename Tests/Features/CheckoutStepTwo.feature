Feature: CheckoutStepTwo
	Implement tests for Checkout Spep Two page

Background: 
	Given Navigate to Login page
		And Login with valid username and password
		And Add the first inventory item to the cart 
		And Add the last inventory item to the cart
		And Click shopping cart badge
		And  Click checkout
		And Fill my information
		| FirstName | LastName | ZipCode |
		| Hristo    | Georgiev | 4000    |
		And Click Contunue

Scenario: Finish order
	When Click finish
	Then I am redirected to the Checkout Complete page with url "/checkout-complete.html"
		And Page title is "CHECKOUT: COMPLETE!"
	When Click shopping cart badge
	Then The cart is empty
