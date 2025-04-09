using NUnit.Framework;
using OpenQA.Selenium;
using Reqnroll;
using TestAutomationBDD_OrangeApp.Base;

namespace TestAutomationBDD_OrangeApp.StepDefinitions
{
    [Binding]
    public class AddJobTitlesSteps : TestBase
    {
        [Given(@"I am logged in as an admin")]
        public void GivenIAmLoggedInAsAnAdmin()
        {
            _loginPage.Login("Admin", "admin123");
        }

        [When(@"I navigate to '(.*)' Page")]
        public void WhenINavigateToJobTitlesPage(string menuItemName)
        {
           _menuPanel.NavigateTo(menuItemName);
        }

        [When(@"I add a new job title '(.*)' with description '(.*)' and note '(.*)'")]
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
            var jobTitles = _driver.FindElements(By.XPath("//"));
            bool jobTitleExists = 
                jobTitles.Any(jobTitle => jobTitle.Text.Equals(title));
            Assert.That(jobTitleExists, $"The job title '{title}' was not found.");
        }

    }
}
