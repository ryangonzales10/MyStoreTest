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
            NavigationHelper.NavigateToUrl(Browser.Config.GetWebsite());
            Browser.Driver.FindElement(By.Id("contact-link")).Click();
            Browser.Driver.Navigate().Back(); //go back
            Browser.Driver.Navigate().Forward(); //go forward
            Browser.Driver.Manage().Window.Minimize(); //minimize window
            Browser.Driver.Manage().Window.Maximize(); //maximize window
            Browser.Driver.Navigate().Refresh(); //refresh window



        }
    }
}
