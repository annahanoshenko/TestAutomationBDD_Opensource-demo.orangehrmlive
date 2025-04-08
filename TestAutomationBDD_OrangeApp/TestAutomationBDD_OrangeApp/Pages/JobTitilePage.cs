using OpenQA.Selenium;

namespace TestAutomationBDD_OrangeApp.Pages
{
    public class JobTitilePage
    {
        private readonly IWebDriver _driver;
        private By addJobTitleButton = By.XPath("//button[@class='oxd-button oxd-button--medium oxd-button--secondary']");
        private By jobTitleField = By.XPath("///div/input[@class='oxd-input oxd-input--active']");
        private By jobDescriptionField = By.XPath("//textarea[@placeholder='Type description here']");
        private By jobSpecificationField = By.XPath("//div[@class='oxd-file-button']");
        private By noteField = By.XPath("//textarea[@placeholder='Add note']");
        private By saveButton = By.XPath("//button[@type='submit']");
        private By successMessage = By.XPath("//div[@id='oxd-toaster_1']");

        public JobTitilePage(IWebDriver driver)
        {
            _driver = driver;
        }

       public void AddJobTitle(string jobTitle, string jobDescription, string note)
        {
            _driver.FindElement(addJobTitleButton).Click();
            _driver.FindElement(jobTitleField).SendKeys(jobTitle);
            _driver.FindElement(jobDescriptionField).SendKeys(jobDescription);
            _driver.FindElement(jobSpecificationField).Click();
            _driver.FindElement(noteField).SendKeys(note);
            _driver.FindElement(saveButton).Click();
        }

        public bool GetSuccessMessage()
        {
            return _driver.FindElement(successMessage).Displayed;
        }
    }
}
