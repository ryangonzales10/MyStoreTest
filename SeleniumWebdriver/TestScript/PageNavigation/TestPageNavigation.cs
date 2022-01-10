﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using SeleniumWebdriver.Settings;
using SeleniumWebdriver.ComponentHelper;
using OpenQA.Selenium.Firefox;

//This is my test
namespace SeleniumWebdriver.TestScript.PageNavigation
{
    public static class TestPageNavigation
    {
        [TestMethod]
        public static void OpenPage()
        {
            FirefoxDriver Browser = new FirefoxDriver();
            //ObjectRepository.Driver.Navigate().GoToUrl(ObjectRepository.Config.GetWebsite());
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            Browser.Close();
            Browser.Quit();
        }
    }
}
