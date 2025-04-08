using OpenQA.Selenium;

namespace TestAutomationBDD_OrangeApp.Base
{
    public class BasePage
    {
        protected readonly IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }
    }
}
