using NLog;
using NUnit.Allure.Core;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SauceDemo.Core;
using SauceDemo.Steps;
using Logger = NLog.Logger;

namespace SauceDemo.Tests
{
    [AllureNUnit]
    public class BaseTest
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        protected IWebDriver Driver;
        protected NavigationSteps NavigationSteps;

        [SetUp]
        public void SetUp()
        {
            logger.Info("Info message");
            logger.Warn("Warning");
            logger.Error("Error message");
            logger.Fatal("Fatal");

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