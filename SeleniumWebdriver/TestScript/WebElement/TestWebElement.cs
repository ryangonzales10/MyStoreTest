﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumWebdriver.Settings;
using SeleniumWebdriver.TestScript.PageNavigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumWebdriver.TestScript.WebElement
{
    [TestClass]
    public class TestWebElement
    {
        [TestMethod]
        public void GetElement()
        {
            TestPageNavigation.OpenPage();
            //this is how to test if an elemt is preseent:
            try
            {
                ObjectRepository.Driver.FindElement(By.ClassName("quick-view"));
                ObjectRepository.Driver.FindElement(By.CssSelector("#header_logo"));
                ObjectRepository.Driver.FindElement(By.Id("index"));      
                ObjectRepository.Driver.FindElement(By.LinkText("test")); //should go to catch
                ObjectRepository.Driver.FindElement(By.PartialLinkText("test")); //should go to catch
                ObjectRepository.Driver.FindElement(By.Name("test")); //should go to catch
                ObjectRepository.Driver.FindElement(By.XPath("blank one, should throw an error")); //should go to catch
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}