using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public class CheckboxHelper
    {
        //this is another approach
        private static IWebElement element;
        public static void CheckCheckbox(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Click();
        }
    }
}
