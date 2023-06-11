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

        public LoginPage loginPage;
        public LoginPage LoginPage
        {
            get
            {
                if (this.loginPage == null)
                    this.loginPage = new LoginPage(Driver);

                return this.loginPage;
            }
        }

        public ProductsPage productsPage;
        public ProductsPage ProductsPage
        {
            get
            {
                if (this.productsPage == null)
                    this.productsPage = new ProductsPage(Driver);

                return this.productsPage;
            }
        }

        public BaseStep(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}