using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SauceDemo.Utilities.Configuration;

namespace SauceDemo.Pages
{
    public abstract class BasePage
    {        
        protected static int waitForPageLoadTime = 60;
        [ThreadStatic] protected static IWebDriver Driver;

        public BasePage()
        {

        }
        public abstract void OpenPage();
        public abstract bool IsPageOpened();

        protected BasePage(IWebDriver driver, bool openPageByUrl)
        {
            Driver = driver;

            if (openPageByUrl) 
            {
                OpenPage();
            }
            WaitForOpen();
        }  

        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
        
        protected void OpenPageByURL()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        }

        protected void WaitForOpen() 
        {
            var countSeconds = 0;
            var isPageOpenedIndicator = IsPageOpened();

            while (!isPageOpenedIndicator && countSeconds < waitForPageLoadTime) 
            {
                Thread.Sleep(1000);
                countSeconds++;
                isPageOpenedIndicator = IsPageOpened();
            }

            if (!isPageOpenedIndicator) 
            {
                throw new Exception("Page was not opened");
            }
        }
    }
}