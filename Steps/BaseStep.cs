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
        public LoginPage LoginPage => new LoginPage(Driver);
        public ProductsPage ProductsPage => new ProductsPage(Driver);

        public BaseStep(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}