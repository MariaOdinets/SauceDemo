using Allure.Commons;
using NUnit.Allure.Attributes;
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
        [Test(Description = "Successful Login")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureOwner("Standard_user")]
        [AllureSuite("Passed_suite")]
        [AllureSubSuite("GUI")]
        [AllureIssue("testIssue")]
        [AllureTms("TMS-157_testIssue")]
        [AllureTag("regression")]

        public void SuccessfulLoginTest()
        {
            NavigationSteps.NavigateToLoginPage();
            NavigationSteps.SuccessfulLogin(Configurator.UserByUsername("standard_user"));

            Assert.IsTrue(NavigationSteps.ProductsPage.IsPageOpened());
        }

        [Test(Description = "Login Failed")]
        [Description ("Login failed - user locked out")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureOwner("Locked_out_user")]
        public void LockedTest()
        {
            NavigationSteps.NavigateToLoginPage();
            NavigationSteps.IncorrectLogin(Configurator.UserByUsername("locked_out_user"));

            Assert.IsTrue(NavigationSteps.LoginPage.IsErrorMessageDisplayed());
        }
    }
}