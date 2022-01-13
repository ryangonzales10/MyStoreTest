using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    
    public class DropdownHelper
    {
        private static IWebElement element;
        private static SelectElement dropdown;

        public static void DropdownSelectByIndex (By Locator, int x)
        {
            dropdown = new SelectElement(GenericHelper.GetElement(Locator)); //initializes a new instancew of the SelectElement class. element is the element to be wrapped
            dropdown.SelectByIndex(x);
        }

        public static void DropdownSelectByText(By Locator, string x)
        {
            dropdown = new SelectElement(GenericHelper.GetElement(Locator)); 
            dropdown.SelectByText(x);
        }

        public static void DropdownSelectByValue(By Locator, string x)
        {
            dropdown = new SelectElement(GenericHelper.GetElement(Locator));
            dropdown.SelectByValue(x);
        }

        public static IList<string> GetAllItems (By Locator)
        {
            dropdown = new SelectElement(GenericHelper.GetElement(Locator));
            return dropdown.Options.Select((x) => x.Text).ToList(); //search linq expression in google
        }

    }
}
