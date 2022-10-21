using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TestAutomationPractice.Helpers;

namespace TestAutomationPractice.Pages
{
    public class CartPage
    {
        readonly IWebDriver driver;
        public By cartPage = By.Id("order");
        public By ShoppingCartSummary = By.Id("cart_summary");
        public By SummaryProductsQuantity = By.Id("summary_products_quantity");

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(cartPage));
        }
    }
}
