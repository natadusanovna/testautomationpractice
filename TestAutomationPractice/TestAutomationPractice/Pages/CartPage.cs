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
        public By ProductName = By.XPath("//a[contains(text(),'Printed Dress')]");
        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(cartPage));
        }
    }
}
