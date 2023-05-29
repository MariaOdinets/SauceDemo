using NUnit.Allure.Core;
using OpenQA.Selenium;
using SauceDemo.Core;
using SauceDemo.Steps;

namespace SauceDemo.Tests
{
    [AllureNUnit]
    public class BaseTest
    {
        protected IWebDriver Driver;
        protected NavigationSteps NavigationSteps;

        [SetUp]
        public void SetUp()
        {
            Driver = new Browser().Driver;

            NavigationSteps = new NavigationSteps(Driver);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}