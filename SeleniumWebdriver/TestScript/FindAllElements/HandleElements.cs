using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.FindAllElements
{
    //find all elements with type __ and print them out

    [TestClass]
    public class HandleElements
    {
        [TestMethod]
        public void GetAllElements()
        {
            NavigationHelper.NavigateToUrl(Browser.Config.GetWebsite());
            ReadOnlyCollection<IWebElement> elements = Browser.Driver.FindElements(By.XPath("//input"));
            ReadOnlyCollection<IWebElement> elements2 = Browser.Driver.FindElements(By.XPath("//hello")); //should return 0

            foreach (var x in elements)
            {
                Console.WriteLine($"ID of Element: {x.GetAttribute("id")}");
            }
        }


    }
}
