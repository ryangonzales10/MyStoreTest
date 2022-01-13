using Microsoft.VisualStudio.TestTools.UnitTesting;
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
                Browser.Driver.FindElement(By.ClassName("quick-view"));
                Browser.Driver.FindElement(By.CssSelector("#header_logo"));
                Browser.Driver.FindElement(By.Id("index"));
                Browser.Driver.FindElement(By.LinkText("Women"));
                Browser.Driver.FindElement(By.PartialLinkText("Wome")); 
                Browser.Driver.FindElement(By.Name("description")); 
                Browser.Driver.FindElement(By.XPath("//div[@id='contact-link']"));
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
