Feature: JobTitle  testing
	As a user
	I want to add a new job title
	So that I can verify it appears in the job titles list

@tag1
Scenario:  Job title added sucessfully
	Given Logged in as an admin 
	When I navigate to Job Titles page
	And Add job title "Student" with job description "Intership" and note "Temporary"
	And Click Save
	Then Successfull message should be displayed 
	Then Job title should be added to the the job titles list on the Job Titles page
