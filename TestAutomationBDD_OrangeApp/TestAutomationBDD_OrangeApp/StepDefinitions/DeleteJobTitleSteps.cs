using Reqnroll;
using TestAutomationBDD_OrangeApp.Base;

namespace TestAutomationBDD_OrangeApp.StepDefinitions
{
    [Binding]
    public class DeleteJobTitleSteps : TestBase
    {
        [Given(@"I am logged in as an admin")]
        public void GivenIAmLoggedInAsAnAdmin()
        {
            _loginPage.Login("Admin", "admin123");
        }

    }
}
