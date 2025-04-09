using OpenQA.Selenium;
using TestAutomationBDD_OrangeApp.Base;

namespace TestAutomationBDD_OrangeApp.Pages
{
    public class AdminPage : TestBase
    {
        private By adminButton = By.XPath("//span[text()='Admin']");
        private By jobButton = By.XPath("//span[text()='Job ']");
        private By jobTitleButton = By.XPath("//a[text()='Job Titles']"); 

        public AdminPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickAdminButton()
        {
            _driver.FindElement(adminButton).Click();
        }
        public void ClickJobButton()
        {
            _driver.FindElement(jobButton).Click();
        }
        public void ClickJobTitleButton()
        {
            _driver.FindElement(jobTitleButton).Click();
        }
    }
}
