using OpenQA.Selenium;
using TestAutomationBDD_OrangeApp.Base;

namespace TestAutomationBDD_OrangeApp.Pages
{
    public class LoginPage : TestBase
    {
        private By usernameField = By.XPath("//input[@class='oxd-input oxd-input--active']");
        private By passwordField = By.XPath("//input[@type='password']");
        private By loginButton = By.XPath("//button[@type='submit']");

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        public void Login(string username, string password)
        {
            _driver.FindElement(usernameField).SendKeys(username);
            _driver.FindElement(passwordField).SendKeys(password);
            _driver.FindElement(loginButton).Click();
        }
    }
}
