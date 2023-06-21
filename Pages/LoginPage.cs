using OpenQA.Selenium;
using SauceDemo.Models;
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
        public static readonly By ErrorButton = By.CssSelector(".error-button");

        private LoginPage loginPage;
        private ProductsPage productsPage;
        public LoginPage(IWebDriver driver) : base(driver)
        {
            OpenPageByURL();
        }

        public override bool IsPageOpened()
        {
            return Driver.FindElement(LoginButton).Displayed;
        }

        public LoginPage EnterUsername(string username)
        {
            Driver.FindElement(UsernameInput).SendKeys(username);
            return loginPage;
        }

        public LoginPage EnterPassword(string password) 
        { 
            Driver.FindElement(PasswordInput).SendKeys(password);
            return loginPage;
        }

        public LoginPage ClickLogin()
        {
            Driver.FindElement(LoginButton).Click();
            return loginPage;
        }

        public bool IsErrorButtonDisplayed()
        {
            return Driver.FindElement(ErrorButton).Displayed;
        }

        internal ProductsPage SuccessfulLogin(string username, string password)
        {
            return productsPage;
        }

        internal LoginPage LockedLogin(string username, string password)
        {
            return loginPage;
        }
    }
}