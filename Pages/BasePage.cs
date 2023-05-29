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
        protected IWebDriver Driver;
        protected BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public abstract bool IsPageOpened();        
        protected void OpenPageByURL()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        }
    }
}