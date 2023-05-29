using OpenQA.Selenium;
using SauceDemo.Models;
using SauceDemo.Pages;

namespace SauceDemo.Steps
{
    public class NavigationSteps : BaseStep
    {
        public NavigationSteps(IWebDriver driver) : base(driver)
        {

        }

        public LoginPage NavigateToLoginPage()
        {
            return new LoginPage(Driver);
        }

        public ProductsPage SuccessfulLogin(string username, string password)
        {
            Login(username, password);
            return ProductsPage;
        }

        public ProductsPage SuccessfulLogin(User user)
        {
            return SuccessfulLogin(user.Username, user.Password);
        }

        public LoginPage IncorrectLogin(string username, string password)
        {
            Login(username, password);
            return LoginPage;
        }

        public LoginPage IncorrectLogin(User user)
        {
            return IncorrectLogin(user.Username, user.Password);
        }

        private void Login(string username, string password)
        {
            LoginPage.EnterUsername(username);
            Thread.Sleep(3000);
            LoginPage.EnterPassword(password);
            Thread.Sleep(3000);
            LoginPage.ClickLogin();
        }
    }
}