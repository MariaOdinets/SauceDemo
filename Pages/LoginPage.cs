using OpenQA.Selenium;
using SauceDemo.Utilities.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Pages
{
    public class LoginPage : BasePage
    {
        private static readonly By UsernameInput = By.Id("user-name");
        private static readonly By PasswordInput = By.Id("password");
        private static readonly By LoginButton = By.Id("login-button");
        public static readonly By ErrorMessage = By.CssSelector(".error - button");

        public LoginPage(IWebDriver driver) : base(driver)
        {
            OpenPageByURL();
        }

        public override bool IsPageOpened()
        {
            return Driver.FindElement(LoginButton).Displayed;
        }

        public void EnterUsername(string username)
        {
            Driver.FindElement(UsernameInput).SendKeys(username);
        }

        public void EnterPassword(string password) 
        { 
            Driver.FindElement(PasswordInput).SendKeys(password);
        }

        public void ClickLogin()
        {
            Driver.FindElement(LoginButton).Click();
        }

        public bool IsErrorMessageDisplayed()
        {
            return Driver.FindElement(ErrorMessage).Displayed;
        }
    }
}