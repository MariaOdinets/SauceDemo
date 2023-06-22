using OpenQA.Selenium;
using SauceDemo.Utilities.Configuration;

namespace SauceDemo.Pages
{
    public class ProductsPage : BasePage
    {
        private static readonly By AddToCartButton = By.Id("add-to-cart-sauce-labs-backpack");
        public ProductsPage(IWebDriver driver) : base(driver)
        {

        }

        public override bool IsPageOpened()
        {
            try
            {
                return Driver.FindElement(AddToCartButton).Displayed;
            }  
            
            catch (Exception e)
            { 
                return false;
            }
        }

        public override void OpenPage()
        {
            Driver.Navigate().GoToUrl(Configurator.AppSettings.URL);
        }
    }
}