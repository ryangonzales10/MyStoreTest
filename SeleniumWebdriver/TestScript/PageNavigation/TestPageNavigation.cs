using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.Settings;


namespace SeleniumWebdriver.TestScript.PageNavigation
{
    class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()
        {
            //INavigation page = ObjectRepository.Driver.Navigate();
            //page.GoToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());

        }
    }
}
