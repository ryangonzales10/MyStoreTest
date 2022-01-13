using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public static class ButtonHelper
    {
        public static void ClickButton(By Locator)
        {
            Browser.Driver.FindElement(Locator).Click();
        }

        public static bool IsButtonEnabled(By Locator)
        {
            IWebElement element = GenericHelper.GetElement(Locator);
            return element.Enabled;
        }

        public static string GetButtonText(By Locator)
        {
            IWebElement element = GenericHelper.GetElement(Locator);

            if (element.GetAttribute("innerText") == null) return null;
            else return element.GetAttribute("innerText"); //innerText is key! btw the text is outside the pointy brackets
            //https://stackoverflow.com/questions/48417027/how-to-getattribute-of-a-span-class-value-in-selenium-web-driver
        }
    }
}
