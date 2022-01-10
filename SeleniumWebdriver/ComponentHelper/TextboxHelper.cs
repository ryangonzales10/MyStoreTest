using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    //create a iWebElement here called element
    public class TextboxHelper
    {
        public static void TypeInTextBox(By Locator, string x)
        {
            ObjectRepository.Driver.FindElement(Locator).SendKeys(x);
        }

        public static void ClearTextBox(By Locator)
        {
            ObjectRepository.Driver.FindElement(Locator).Clear();
        }

    }
}
