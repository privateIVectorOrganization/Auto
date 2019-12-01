using System;
using TechTalk.SpecFlow;
using IVector.App;
using IVector.Common;

namespace IVector
{
    [Binding]
    public class LoginSteps
    {
        public LoginPage LoginPage { get; set; }

        public LoginSteps(LoginPage loginPage)
        {
            LoginPage = loginPage;
        }

        [Given(@"Navigate to '(.*)'")]
        public void GivenNavigateTo(string url)
        {
            LoginPage.Driver.InitializeDrive(BrowserTypes.CHROME);
            LoginPage.NavigateTo(url);
        }

        [Given(@"Enter credentials '(.*)' and '(.*)'")]
        public void GivenEnterCredentialsAnd(string emailAddress, string password)
        {
            LoginPage.Login(emailAddress, password);
        }

    }
}
