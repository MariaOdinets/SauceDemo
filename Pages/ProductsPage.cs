using OpenQA.Selenium;

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
            return Driver.FindElement(AddToCartButton).Displayed;
        }
    }
}