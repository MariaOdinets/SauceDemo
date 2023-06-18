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
            NavigationSteps.SuccessfulLogin(Configurator.UserByUsername("standard_user"));

            Assert.IsTrue(NavigationSteps.ProductsPage.IsPageOpened());
        }

        [Test]
        public void LockedTest()
        {
            NavigationSteps.NavigateToLoginPage();
            NavigationSteps.IncorrectLogin(Configurator.UserByUsername("locked_out_user"));

            Assert.IsTrue(NavigationSteps.LoginPage.IsErrorMessageDisplayed());
        }
    }
}