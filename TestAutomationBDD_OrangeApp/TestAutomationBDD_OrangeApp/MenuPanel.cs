using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationBDD_OrangeApp.Base;

namespace TestAutomationBDD_OrangeApp
{
    public class MenuPanel : BasePage
    {
        public MenuPanel(IWebDriver driver) : base(driver)
        {
        }

        public void NavigateTo(string menuItemName)
        {
            By menuItemLocator = By.XPath($"//span[text()='{menuItemName}']");
            IWebElement menuItemWebElement = _driver.FindElement(menuItemLocator);
            menuItemWebElement.Click();
        }
    }
}
