using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumWebdriver.Settings;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.CustomException;
using OpenQA.Selenium.Firefox;

//This takes care of launching the browsers, and tearing them down. It's like hook 
namespace SeleniumWebdriver.BaseClasses
{
    [TestClass] 
    public class BaseClass
    {
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized"); //fancy way of saying Browser.Manage().Window.Maximize(); We are passing an argument that does the same thing
            //option.AddExtension(@"C:\Project\Chrome Extensions"); //inside parenthesis should be the local directory of the extension. to check, go to google/apps in the window of the test
            return option;
        }


        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());  //this is from line 20, we are passing the maximize argument
            return driver;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        [AssemblyInitialize] //makes this method run first 
        public static void InitWebdriver(TestContext tc) 
        {
            ObjectRepository.Config = new AppConfigReader();
            switch (ObjectRepository.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    ObjectRepository.Driver = GetChromeDriver();
                    break;

                case BrowserType.Firefox:
                    ObjectRepository.Driver = GetFirefoxDriver();
                    break;
                default:
                    throw new NoSuitableDriverFound($"Driver Not Found {ObjectRepository.Config.GetBrowser().ToString()}");
            }
        }

        [AssemblyCleanup] //runs last
        public static void Teardown()
        {
            if (ObjectRepository.Driver != null)
            {
                ObjectRepository.Driver.Close();
                ObjectRepository.Driver.Quit();
            }
        }
    }
}
