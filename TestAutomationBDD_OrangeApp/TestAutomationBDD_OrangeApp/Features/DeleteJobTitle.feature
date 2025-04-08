Feature: DeleteJobTitle

A short summary of the feature
Precondition: Add new job title

@tag1
Scenario: Delete exsisting job title
	Given Job Titles page 
	When  Clicking delete button on created job title
	Then Verify successfull message is displayed 
	And Verify that deleted job title is not present anymore on the Job Titles page