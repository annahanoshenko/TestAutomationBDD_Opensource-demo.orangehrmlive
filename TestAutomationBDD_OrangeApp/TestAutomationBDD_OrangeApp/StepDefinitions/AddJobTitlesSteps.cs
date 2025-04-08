using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TestAutomationBDD_OrangeApp.Base;
using TestAutomationBDD_OrangeApp.Pages;

namespace TestAutomationBDD_OrangeApp.StepDefinitions
{
    [Binding]
    public class AddJobTitlesSteps : TestBase
    {
        [Given(@"I am logged in as an admin")]
        public void GivenIAmLoggedInAsAnAdmin()
        {
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
            
            _loginPage.Login("Admin", "admin123");
        }

        [When(@"I navigate to Job Titles Page")]
        public void WhenINavigateToJobTitlesPage()
        {
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/index.php/admin/viewJobTitleList");
            JobTitilePage jobTitilePage = new JobTitilePage(_driver);
        }

        [When(@"I add a new job title ""(.*)"" with description ""(.*)"" and note ""(.*)""")]
        public void WhenIAddANewJobTitleWithDescriptionAndNote(string jobTitle, string jobDescription, string note)
        {
            _jobTitilePage.AddJobTitle(jobTitle, jobDescription, note);
        }

        [Then(@"The job title should be added successfully")]
        public void ThenIShouldSeeTheSuccessMessage(string expectedMessage)
        {
            Assert.Equals(expectedMessage, _jobTitilePage.GetSuccessMessage());
        }

        [Then(@"The job title should appear in the job titles list")]
        public void ThenTheJobTitleShouldAppearInTheJobTitlesList(string title)
        {
            var jobTitles = _driver.FindElements(By.XPath("//table[@id='resultTable']/tbody/tr/td[2]"));
            bool jobTitleExists = 
                jobTitles.Any(jobTitle => jobTitle.Text.Equals(title));
            Assert.That(jobTitleExists, $"The job title '{title}' was not found.");
        }

    }
}
