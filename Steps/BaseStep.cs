using OpenQA.Selenium;
using SauceDemo.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SauceDemo.Steps
{
    public class BaseStep
    {
        protected IWebDriver Driver;

        private LoginPage loginPage;
        public LoginPage LoginPage
        {
            get
            {
                if (this.loginPage == null)
                    this.loginPage = new LoginPage(Driver);

                return this.loginPage;
            }
        }

        public ProductsPage ProductsPage => new ProductsPage(Driver);
        public BaseStep(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}