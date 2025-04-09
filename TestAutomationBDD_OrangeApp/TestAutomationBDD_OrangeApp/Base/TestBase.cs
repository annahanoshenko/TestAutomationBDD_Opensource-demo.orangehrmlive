using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll;
using TestAutomationBDD_OrangeApp.Pages;

namespace TestAutomationBDD_OrangeApp.Base
{
    public class TestBase
    {
        protected IWebDriver _driver;
        protected LoginPage _loginPage => new LoginPage(_driver);
        protected AdminPage _adminPage => new AdminPage(_driver);
        protected JobTitilePage _jobTitilePage => new JobTitilePage(_driver);
        protected MenuPanel _menuPanel => new MenuPanel(_driver);

        [BeforeScenario]
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

        [AfterScenario]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
