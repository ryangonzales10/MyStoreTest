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
        [Given(@"the User navigates to http://automationpractice\.com/")]
        public void GivenTheUserNavigatesToHttpAutomationpractice_Com()
        {
            Browser.Webdriver.Navigate().GoToUrl("http://automationpractice.com/");
        }

        [When(@"the user clicks on Sign In Button at the top right")]
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


        [Then(@"the User should be able to enter their accout")]
        public void ThenTheUserShouldBeAbleToEnterTheirAccout()
        {
            try
            {
                Browser.Webdriver.FindElement(By.Id("my-account")); //goes to catch when element is missing
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }



    }
}
