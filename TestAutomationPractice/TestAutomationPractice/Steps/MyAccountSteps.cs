using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestAutomationPractice.Helpers;
using TestAutomationPractice.Pages;

namespace AutomationPracticeFramework.Steps
{
    [Binding]
    public class MyAccountSteps : Base
    {
        Utilities ut = new Utilities(Driver);
        HomePage hp = new HomePage(Driver);

        private readonly PersonData personData;

        public MyAccountSteps(PersonData personData)
        {
            this.personData = personData;
        }

        [Given(@"user opens sign in page")]
        public void GivenUserOpensSignInPage()
        {
            ut.ClickOnElement(hp.signin);
        }

        [Given(@"enters correct credentials")]
        public void GivenEntersCorrectCredentials()
        {
            AuthPage ap = new AuthPage(Driver);
            ut.EnterTextInElement(ap.username, TestConstants.Username);
            ut.EnterTextInElement(ap.Password, TestConstants.Password);
        }

        [When(@"user submits the login form")]
        public void WhenUserSubmitsTheLoginForm()
        {
            AuthPage Ap = new AuthPage(Driver);
            ut.ClickOnElement(hp.signin);
        }

        [Then(@"user will be logged in")]
        public void ThenUserWillBeLoggedIn()
        {
            MyAccountPage mp = new MyAccountPage(Driver);
            Assert.True((bool)ut.ElementIsDisplayed(mp.signOutbtn), "User is not logged in");
        }

        [Given(@"initiates a flow for creating an account")]
        public void GivenInitiatesAFlowForCreatingAnAccount()

        {
            AuthPage Ap = new AuthPage(Driver);
            ut.EnterTextInElement(Ap.email,ut.GenerateRandomEmail());
            ut.ClickOnElement(Ap.createAcc);

        }
        [Given(@"user enters all required personal details")]
        public void GivenUserEntersAllRequiredPersonalDetails()
        {
             SignUpPage sup = new SignUpPage(Driver);
             ut.EnterTextInElement(sup.FirstName, TestConstants.FirstName);
             ut.EnterTextInElement(sup.LastName, TestConstants.Lastname);
             personData.FullName = TestConstants.FirstName + " " + TestConstants.Lastname;
             ut.EnterTextInElement(sup.Password, TestConstants.Password);
             ut.EnterTextInElement(sup.Address, TestConstants.Address);
             ut.EnterTextInElement(sup.City, TestConstants.City);
             ut.DropDownSelect(sup.State, TestConstants.State);
             ut.EnterTextInElement(sup.ZipCode, TestConstants.ZipCode);
             ut.EnterTextInElement(sup.Phone, TestConstants.MobilePhone);


         }

        [When(@"user submits the sign up form")]
        public void WhenUserSubmitsTheSignUpForm()
        {
            SignUpPage sup = new SignUpPage(Driver);
            ut.ClickOnElement(sup.registerBtn);
        }

        [Then(@"user's full name is displayed")]
        public void ThenUserSFullNameIsDisplayed()
        {
            Assert.True(ut.TextPresentInElement(personData.FullName),"User's full name is not displayed");
        }

    }
}
