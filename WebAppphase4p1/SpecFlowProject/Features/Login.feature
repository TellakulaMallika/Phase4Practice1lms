﻿Feature: Login
As a user 
I want to be able to login
So that I can access the dashboard
If I enter incorrect username and password so that i should see the error message

A short summary of the feature

@tag1
Scenario: Successful login
	Given I am on the login page
	When I enter my username and password
	When I click the login buttton
	Then I should see the dashboard
@tag2
Scenario:Failed login with incorrect Credentials
 Given I am on the login page
 When I enter incorrect username and password
 When I click the login button
 Then I should see an error message
   
