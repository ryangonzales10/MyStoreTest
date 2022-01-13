using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.BrowserActions
{
    [TestClass]
    public class TestBrowserActions
    {
        [TestMethod]
        public void TestActions()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.FindElement(By.Id("contact-link")).Click();
            ObjectRepository.Driver.Navigate().Back(); //go back
            ObjectRepository.Driver.Navigate().Forward(); //go forward
            ObjectRepository.Driver.Manage().Window.Minimize(); //minimize window
            ObjectRepository.Driver.Manage().Window.Maximize(); //maximize window
            ObjectRepository.Driver.Navigate().Refresh(); //refresh window



        }
    }
}
