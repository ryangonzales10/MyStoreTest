using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStoreTestProject.Page_Objects;

namespace MyStoreTestProject.Step_Definitions
{
    [Binding]
    public sealed class Login_steps
    {

        #region Given
        [Given(@"the User navigates to http://automationpractice\.com/")]
        public void GivenTheUserNavigatesToHttpAutomationpractice_Com()
        {
            Browser.Webdriver.Navigate().GoToUrl("http://automationpractice.com/");
        }

        #endregion


        #region When

        [When(@"the User clicks on Sign In Button at the top right")]
        public void WhenTheUserClicksOnSignInButtonAtTheTopRight()
        {
            Page.SignIn1();
        }

        [When(@"the User inputs the correct credentials")]
        public void WhenTheUserInputsTheCorrectCredentials()
        {
            Page.Username("archersphoto4@gmail.com");
            Page.Password("password01");

        }

        [When(@"the User clicks on the green Sign In button")]
        public void WhenTheUserClicksOnTheGreenSignInButton()
        {
            Page.SignIn2();
        }

        [When(@"the User clicks logout")]
        public void WhenTheUserClicksLogout()
        {
            Browser.Webdriver.FindElement(By.XPath("//a[@title='Log me out']")).Click();

        }

        [When(@"the User enters an incorrect User Name and Password")]
        public void WhenTheUserEntersAnIncorrectUserNameAndPassword()
        {
            Page.Username("test@test.com");
            Page.Password("hello123");
        }

        [When(@"the User inputs an email with an incorrect format")]
        public void WhenTheUserInputsAnEmailWithAnIncorrectFormat()
        {
            Page.Username("blahblahblah");
            Page.Password("hello123");
            Page.SignIn2();
        }

        [When(@"the User leaves the password blank")]
        public void WhenTheUserLeavesThePasswordBlank()
        {
            Page.Username("testblankpw@test.com");
            Page.ClearPassword();
            Page.SignIn2();
        }

        #endregion


        #region Then

        [Then(@"the User should be able to enter their account")]
        public void ThenTheUserShouldBeAbleToEnterTheirAccount()
        {
            try
            {
                Browser.Webdriver.FindElement(By.Id("my-account")); //goes to catch when element is missing
                Browser.Webdriver.FindElement(By.XPath("//span[text()='Tester McTest']")); //checks if my username is visible
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        [Then(@"the User is signed out and directed back to login page")]
        public void ThenTheUserIsSignedOutAndDirectedBackToLoginPage()
        {
            try
            {
                Browser.Webdriver.FindElement(By.XPath("//a[@class='login']"));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        [Then(@"an authentication error should appear")]
        public void ThenAnAuthenticationErrorShouldAppear()
        {
            try
            {
                Browser.Webdriver.FindElement(By.XPath("//div[@class='alert alert-danger']/ol/li[text()='Authentication failed.']"));
                Page.ClearUsername();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

        }

        [Then(@"an Invalid Email Address error should appear")]
        public void ThenAnInvalidEmailAddressErrorShouldAppear()
        {
            try
            {
                Browser.Webdriver.FindElement(By.XPath("//div[@class='alert alert-danger']/ol/li[text()='Invalid email address.']"));
                Page.ClearUsername();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        [Then(@"a Password is Required error should appear")]
        public void ThenAPasswordIsRequiredErrorShouldAppear()
        {
            try
            {
                Browser.Webdriver.FindElement(By.XPath("//div[@class='alert alert-danger']/ol/li[text()='Password is required.']"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }


        #endregion

    }
}
