using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAutomationBDD_OrangeApp.Pages
{
    public class AdminPage
    {
        private readonly IWebDriver _driver;
        private By adminButton = By.XPath("//span[text()='Admin']");
        private By jobTitleButton = By.XPath("//span[text()='Job Titles']");

        public AdminPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void ClickAdminButton()
        {
            _driver.FindElement(adminButton).Click();
        }

        public void ClickJobTitleButton()
        {
            _driver.FindElement(jobTitleButton).Click();
        }
    }
}
