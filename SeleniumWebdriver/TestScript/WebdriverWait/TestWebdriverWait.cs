using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.WebdriverWait
{
    [TestClass]
    public class TestWebdriverWait
    {
        [TestMethod]
        public void TestWait()
        {
            Browser.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromMilliseconds(10);
            Browser.Driver.Navigate().GoToUrl("http://www.facebook.com");
            Browser.Driver.FindElement(By.LinkText("Forgotten password?")).Click();
        }
    }
}
