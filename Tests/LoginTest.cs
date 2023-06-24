using SauceDemo.Models;
using SauceDemo.Pages;
using SauceDemo.Steps;
using SauceDemo.Utilities.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Tests
{
    public class LoginTest : BaseTest
    {
        [Test]

        public void SuccessfulLoginTest()
        {
            NavigationSteps.NavigateToLoginPage();
            NavigationSteps.SuccessfulLogin(UserBuilder.StandartUser);

            Assert.IsTrue(NavigationSteps.ProductsPage.IsPageOpened());
        }

        [Test]
        public void IncorrectLogin()
        {
            NavigationSteps.NavigateToLoginPage();
            NavigationSteps.LockedLogin(UserBuilder.LockedOutUser);

            Assert.IsTrue(NavigationSteps.LoginPage.IsErrorButtonDisplayed());
        }
    }
}