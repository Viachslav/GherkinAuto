Feature: Deal with goods

Background: 
	Given user is on the page with items
	And clicks book 'Functional Programming in JS'

Scenario: open a book's description
	When user chooses 'Description' tab
	Then user can see 'Product Description'

Scenario: basket management
	When user adds an item to basket
	And user chooses basket
	Then user watches price to pay 

Scenario: proceed to order an item
	When orders an item to basket
	And user is on the basket page 
	And user proceeds for payment
	And user types 'Petya' as his name
	And user types 'Petrov' as surname
	And user inputs his Email 'slavutich765@mail.ru'
	And user types his phone number '380935567284'
	And user inputs his address 'Gladkova'
	And user types his town 'Dnipro'
	And user types his Postcode '1234'
	And user inputs his state 'Dnipropetrovska'
	And user chooses type of payment 'cheque'  
	And user clicks Place order button 
	Then user sees '₹Order Details'

Scenario: continue make the same commentary
	When user clicks Review button
	And types his commentary 'Comment' in relevant field
	And evaluates a rating of the book
	And adds his name 'Petya'
	And writes his email 'slavutich765@mail.ru'
	And clicks button Submit 
	Then user can see a message that 'Duplicate comment detected; it looks as though you’ve already said that!'



	
