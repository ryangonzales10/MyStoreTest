using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public class LinkHelper
    {
        public static void ClickLink(By Locator)
        {
            Browser.Driver.FindElement(Locator).Click();
        }
    }
}
