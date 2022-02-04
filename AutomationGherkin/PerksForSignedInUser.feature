Feature: Perks for signed in user

Background: 
	Given user is registered and stays on the sign in page
	And user inputs his 'slavutich765@mail.ru'
	And user types his '123Slav!!""'
	And user clicks on "Login" button
	And user is on the starting page of his account

Scenario: sign out from account
	When user clicks on Log out button
	Then user goes back to sign in page

Scenario: change name and surname in account
	When clicks Account details
	And types 'Petya' as his first name
	And inputs 'Petrov' as last name
	And pushes Save change button
	Then user watches his login 'slavutich765' on the starting page

Scenario: change billing address
	When user chooses Billing Addresses 
	And user types his name 'Petya'   
	And user inputs his surname 'Petrov'
	And user edits telephone '380995193978'
	And user clarifies his Address 'Baha,3'
	And user chooses city 'Uman'        
	And inputs postcode '11111'           
	And clicks Save address button   
	Then users watches a message 'Address changed successfully.'    

Scenario: change shipping address
	When user chooses Shipping Addresses   
	And user writes his name 'Petya'    
	And user confirms his surname 'Petrov'  
	And user specifies address of shipping 'Seva,4'  
	And user inputs city 'Dnipro'              
	And types postcode '123'             
	And types state 'Dnipropetrovska'          
	And pushes Save address button      
	Then user can watch a message 'Address changed successfully.'  


	
