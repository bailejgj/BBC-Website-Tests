Feature: BbcLogin 
In order to login into my account 
As a user 
I want to be see my account page 

 

@mytag 
Scenario: Invalid password – all digits
Given I am on the login page 
And I have enter a valid username of "Cathy@home.com"
And I have entered a invalid password of "12345678"
When I press login 
Then I should see the error message "Sorry, that password isn’t valid. Please include a letter"

@mytag
Scenario: Invalid password - all letters
Given I am on the login page 
And I have enter a valid username of "Cathy@home.com"
And I have entered a invalid password of "abcdefgh"
When I press login 
Then I should see the error message "Sorry, that password isn’t valid. Please include a digit"