using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyStoreTestProject.Step_Definitions
{
    [Binding]
    public sealed class Login_steps
    {
        ChromeDriver Browser = new ChromeDriver();

        [Given(@"the User navigates to http://automationpractice\.com/")]
        public void GivenTheUserNavigatesToHttpAutomationpractice_Com()
        {
            Browser.Navigate().GoToUrl("http://automationpractice.com/");
        }

        [When(@"the user clicks on Sign In Button at the top right")]
        public void WhenTheUserClicksOnSignInButtonAtTheTopRight()
        {
            Browser.FindElement(By.XPath("//a[@title='Log in to your customer account']")).Click();
        }

        [When(@"the User inputs the correct credentials")]
        public void WhenTheUserInputsTheCorrectCredentials()
        {
            Browser.FindElement(By.Id("email")).SendKeys("archersphoto4@gmail.com");
            Browser.FindElement(By.Id("passwd")).SendKeys("password01");
        }

        [When(@"the User clicks on the green Sign In button")]
        public void WhenTheUserClicksOnTheGreenSignInButton()
        {
            Browser.FindElement(By.Id("SubmitLogin")).Click();
        }


        [Then(@"the User should be able to enter their accout")]
        public void ThenTheUserShouldBeAbleToEnterTheirAccout()
        {
            try
            {
                Browser.FindElement(By.Id("my-account")); //goes to catch when element is missing
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }

            Browser.Close();
            Browser.Quit();
        }



    }
}
