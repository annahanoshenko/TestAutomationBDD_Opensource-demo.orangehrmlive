using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestAutomationBDD_OrangeApp.Pages;

namespace TestAutomationBDD_OrangeApp.Base
{
    public class TestBase
    {
        protected IWebDriver _driver;
        protected LoginPage _loginPage => new LoginPage(_driver);
        protected AdminPage _adminPage => => new AdminPage(_driver);
        protected JobTitilePage _jobTitilePage => new JobTitilePage(_driver);

       
        public void Setup()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void TearDown()
        {
            _driver.Quit();
        }
    }
}
