using System;
using NUnit.Framework;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TestAutomationPractice.Helpers;
using TestAutomationPractice.Pages;

namespace TestAutomationPractice.Steps
{
    [Binding]
    public class PDPSteps : Base
    {
        Utilities ut = new Utilities(Driver);

        private readonly ProductData productData;

        public PDPSteps(ProductData productData)

        {

         this.productData = productData;
        }

        [Given(@"user opens '(.*)' section")]
        public void GivenUserOpensSection(string cat)
        {
            ut.ReturnCategoryList(cat)[1].Click();
        }
        
        [Given(@"opens first product from the list")]
        public void GivenOpensFirstProductFromTheList()
        {
            PLPage plp = new PLPage(Driver);
            ut.ClickOnElement(plp.firstProduct);
        }
        
        [Given(@"increases quantity to '(.*)'")]
        public void GivenIncreasesQuantityTo(string qty)
        {

            By iframe = By.ClassName("fancybox-iframe");
            Driver.SwitchTo().Frame(Driver.FindElement(iframe));
            PDPage pdp = new PDPage(Driver);
            Driver.FindElement(pdp.quantity).Clear();
            ut.EnterTextInElement(pdp.quantity, qty);
            productData.ProductName = ut.ReturnTextFromElement(pdp.productName);
        }
        
        [When(@"user clicks add to cart button")]
        public void WhenUserClicksOnAddToCartButton()
        {
            PDPage pdp = new PDPage(Driver);
            ut.ClickOnElement(pdp.addToCartBtn);
        }
        
        [When(@"user proceeds to checkout")]
        public void WhenUserProceedsToCheckout()
        {
            PDPage pdp = new PDPage(Driver);
            ut.ClickOnElement(pdp.proToCheckOutBtn);
        }
        
        [Then(@"cart summary is displayed and product is added to cart")]
        public void ThenCartSummaryIsDisplayedAndProductIsAddedToCart()
        {
            //PDPage pdp = new PDPage(Driver);
            //Assert.True(ut.ElementExists(By.Id("order-detail-content")), "dfasdf asdfsa f");
            //Assert.True(ut.TextPresentInElement(pdp.cartPage), "Cart summary is NOT displayed");
            //Assert.True(ut.TextPresentInElemen(pdp.productName), "Product is NOT added to cart");
            //{
            //CartPage cp = new CartPage(Driver);
            //Assert.True(pdp.InformationPageIsDisplayed(cp.cartPage), "Expected page is NOT displayed");
            PDPage pdp = new PDPage(Driver);
            CartPage cp = new CartPage(Driver);
            Assert.IsTrue(pdp.InformationPageIsDisplayed(), "Expected page is NOT displayed");
            Assert.True(ut.ElementExists(cp.ProductName), "Product is NOT added to cart");

        }
        
        }
    }

