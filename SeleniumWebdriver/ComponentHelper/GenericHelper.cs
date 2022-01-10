using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public class GenericHelper
    {
        public static bool IsElementPresent (By Locator)
        {
            //method should hava e locator that's unique! (not use why not use FindELement instead???)
            try
            {
                return ObjectRepository.Driver.FindElements(Locator).Count == 1; //it will return me the size and compare it to 1
                //check if element id present or not. If it is there, it will return me a count as 1, and this entire statement will return true

                //if it's not there, it will return me a zero, and this is a false condition 
                //in any other cases, it will go to the catch exception
               
                //Findelement - finds a single element, returns single webelement
                //FindELements - finds multiple elements, returns a list of webelements
            }
            catch(Exception)
            {
                return false;
            }

        }

        public static IWebElement GetElement(By Locator)
        {
            if (IsElementPresent(Locator))
                return ObjectRepository.Driver.FindElement(Locator);
            else
                throw new NoSuchElementException($"Element Not Found: {Locator.ToString()}");
        }
    }
}
