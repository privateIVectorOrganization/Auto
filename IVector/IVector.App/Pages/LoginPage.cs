using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using IVector.Common;

namespace IVector.App
{
    public class LoginPage : BaseDrive
    {
        IWebDriver LoginPageDriver { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#txtEmail")]
        IWebElement EmailAddress { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#txtPassword")]
        IWebElement Password { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input#btnLogin")]
        IWebElement LoginButton { get; set; }

        public LoginPage(DriverMethods driver)
        {
            Driver = driver;
            
           //PageFactory.InitElements(LoginPageDriver, this);
        }

        public void NavigateTo(string url)
        {
            Driver.NavigateToUrl(url);
        }

        public void Login(string emailAddress, string password)
        {
            Driver.SetImplicitWait(5);
            Driver.Driver.FindElement(By.Id("txtEmail")).Clear();
            Driver.Driver.FindElement(By.Id("txtEmail")).SendKeys(emailAddress);
            Driver.Driver.FindElement(By.Id("txtPassword")).SendKeys(password);
            Driver.Driver.FindElement(By.Id("btnLogin")).Click();
            //EmailAddress.Clear();
            //EmailAddress.SendKeys(emailAddress);
            //Password.SendKeys(password);
            //LoginButton.Click();
        }

    }
}
