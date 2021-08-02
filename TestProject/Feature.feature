Feature: Feature
	Simple calculator for adding two numbers

@mytag
Scenario Outline: Facebook authentication
	Given I open facebook
	When I enter invalid <username> and <password>
	Then Error <message> is displayed
	Examples:
	| username | password     | message                             |
	| testuser | testpassword | Facebook அணுகல் விரைவில் கிடைக்கும் |
