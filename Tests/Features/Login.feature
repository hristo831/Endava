Feature: Login
	Implement tests for Login page

Background: 
	Given Navigate to Login page
		And Login with valid username and password

Scenario: Login with valid username and password 
	Then I am redirected to the Inventory page with url "/inventory.html"
		And Page title is "PRODUCTS"

Scenario: Logout
	When Logout from the system
	Then I am redirected to the Login page with url "/"
