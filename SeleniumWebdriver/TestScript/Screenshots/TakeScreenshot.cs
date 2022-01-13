using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.Screenshots
{
    [TestClass]
    public class TakeScreenshot
    {
        [TestMethod]
        public void ScreenShots()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            GenericHelper.TakeScreenshot("Ryan1.jpeg");
            GenericHelper.TakeScreenshot(); //without filename is handled in helper class
        }
    }
}
