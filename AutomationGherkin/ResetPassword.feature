Feature: Reset password


Background:
Given user is logged out and stayes on the sign in page

Scenario: reset password via email
	When user clicks on Lost your password button
	And inputs his current email address 'slavutich765@mail.ru'
	And clicks reset button
	Then user sees a message 'A password reset email has been sent to the email address on file for your account, but may take several minutes to show up in your inbox. Please wait at least 10 minutes before attempting another reset.'  
	
# only once because site doesn't allow to delete data, only change
Scenario: change password in personal account
	When user inputs his email 'slavutich12345@mail.ru'
	And user types his password '123Slav!!""'
	And user clicks on "Login" button
	And user is on the starting page of his account
	When user pushes button Account details
	And types '123Slav!!""' as a current password 
	And inputs as a new password '0801!!""pas' 
	And confirms new password '0801!!""pas' 
	And clicks button Save changes  
	And user logs out
	And user inputs his login 'slavutich12345@mail.ru'
	And user types as a new password '0801!!""pas'
	And user pushes on "Login" button
	Then user can watch his account starting page
