using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using SeleniumWebdriver.Settings;
using SeleniumWebdriver.ComponentHelper;

//This is my test
namespace SeleniumWebdriver.TestScript.PageNavigation
{
    class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()
        {
            ChromeDriver Browser = new ChromeDriver();
            //ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Browser.Close();
            Browser.Quit();
        }
    }
}
