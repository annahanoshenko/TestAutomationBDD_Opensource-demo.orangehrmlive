Feature: UpdateJobTitle

A short summary of the feature
Precondition: Add new job title

@tag1
Scenario: Update existing job title
	Given Job Titles page  
	When Click edit created job title
	And Change name and description
	Then Verify successfull message is displayed 
	And Verify that old job title is not present anymore on the Job Titles page
	And Verify that updated job title is present on the Job Titles page
	
