using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TestAutomationPractice.Pages
{
    public class SignUpPage
    {

        readonly IWebDriver driver;
        public By signUpPage = By.Id("account-creation_form");
        public By FirstName = By.Id("customer_firstname");
        public By LastName = By.Id("customer_lastname");
        public By Password = By.Id("passwd");
        public By Address = By.Id("address1");
        public By City = By.Id("city");
        public By State = By.Id("id_state");
        public By ZipCode = By.Id("postcode");
        public By Phone = By.Id("phone");
        public By registerBtn = By.Id("submitAccount");

        public SignUpPage(IWebDriver driver)
        {
            this.driver = driver;
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(signUpPage));
        }
    }
}
