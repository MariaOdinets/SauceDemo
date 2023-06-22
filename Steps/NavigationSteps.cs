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

        // as an example of Value Object pattern
        public ProductsPage SuccessfulLogin(User user)
        {
            return SuccessfulLogin(user.Username, user.Password);
        }

        public LoginPage LockedLogin(string username, string password)
        {
            Login(username, password);
            return LoginPage;
        }

        public LoginPage LockedLogin(User user)
        {
            return LockedLogin(user.Username, user.Password);
        }

        private void Login(string username, string password)
        {
            LoginPage.EnterUsername(username);
            Thread.Sleep(3000);
            LoginPage.EnterPassword(password);
            Thread.Sleep(3000);
            LoginPage.ClickLogin();
            Thread.Sleep(3000);
        }
    }
}