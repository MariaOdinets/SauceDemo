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
            new LoginPage(Driver)
                .SuccessfulLogin(Configurator.UserByUsername("standard_user"));

            Assert.IsTrue(NavigationSteps.ProductsPage.IsPageOpened());
        }

        [Test]
        public void LockedUserLoginTest()
        {
            LoginPage loginPage = new LoginPage(Driver)
                 .LockedLogin(Configurator.UserByUsername("locked_out_user"));

            Assert.IsTrue(loginPage.IsErrorButtonDisplayed());
        }
    }
}