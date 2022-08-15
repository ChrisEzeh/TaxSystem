Feature: SummerDress
	


Scenario Outline: Verify customer can select printed summer dress
	Given I navigate to "http://automationpractice.com/index.php"
	When I enter "<Dresstype>" in the search field
	And I click on search
	And I click printed summer dress
	And I click on blue
	And I select medium from dropdown
	And I enter "<Quantity>" in the quantity field
	And I click on add to cart button
	Then pop up window message "Product successfully added to your shopping cart"
	When I click on proceed to checkout
	Then I can see Shopping-Cart Summary
	And I can see "<Description>" and "<Color>" and "<Size>" and "<Total>" and "<TotalProducts>" and "<TotalShipping>" and "<TotalBeforeTax>" and "<Tax>" and "<TotalAfterTax>" in cart
	When I click on the plus icon to increase quantity
	Then I can see "<quantity2>" in shopping-cart summary
	When I click on proceed to checkout button
	Then I will see the authentication page 
	

Examples: 
	| Dresstype            | Qauntity | Quantity2 | Description          | Color | Size | Total  | TotalProducts | TotalShipping | TotalBeforeTax | Tax   | TotalAfterTax |
	| printed summer dress | 2        | 3         | Printed Summer Dress |  Blue |  M   | $57.96 |   $57.96      |  $2.00        |  $59.96        | $0.00 |  $59.96       |