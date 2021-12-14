using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using 
//This is my test
namespace SeleniumWebdriver.TestScript.PageNavigation
{
    class TestPageNavigation
    {
        [TestMethod]
        public void OpenPage()
        {
            ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());


        }
    }
}
