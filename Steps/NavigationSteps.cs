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
    }
}