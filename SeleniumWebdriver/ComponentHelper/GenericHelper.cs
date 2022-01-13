using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
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
                return Browser.Driver.FindElements(Locator).Count == 1; //it will return me the size and compare it to 1
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
                return Browser.Driver.FindElement(Locator);
            else
                throw new NoSuchElementException($"Element Not Found: {Locator.ToString()}");
        }

        public static void TakeScreenshot(string filename = "screen") //if user has not supplied a filename, this just defaults as screen. But if they have provided, the provided name will overwrite screen
        {
            Screenshot screen = Browser.Driver.TakeScreenshot(); //need to install Selenium.Webdriver.Extensions Nuget package. Variable Screenshot needs OpenQA.Selenium

            if (filename == "screen")
            {
                filename = filename + DateTime.UtcNow.ToString("yyy-MM-dd-mm-ss") + ".jpeg";
                screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg); //this will be saved in C:\Project\SeleniumWebdriver\bin\Debug
                return; //it just stops and returns, so it won't run line 54

            }
            screen.SaveAsFile(filename, ScreenshotImageFormat.Jpeg); //this will be saved in C:\Project\SeleniumWebdriver\bin\Debug
        }
    }
}
