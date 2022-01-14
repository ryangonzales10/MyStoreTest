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
        private static FirefoxProfile GetFirefoxOptions()
        {
            FirefoxProfile profile = new FirefoxProfile();
            FirefoxProfileManager manager = new FirefoxProfileManager();
            profile = manager.GetProfile("default"); //profile is taken when you run 'firefox -ProfileManager'
            return profile;
        }

        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions option = new ChromeOptions();
            option.AddArgument("start-maximized"); //fancy way of saying Browser.Manage().Window.Maximize(); We are passing an argument that does the same thing
            //option.AddArgument("headless");
            //option.AddExtension(@"C:\Project\Chrome Extensions"); //inside parenthesis should be the local directory of the extension. to check, go to google/apps in the window of the test
            return option;
        }


        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver(GetChromeOptions());  //this is from line 31, we are passing the maximize argument
            return driver;
        }

        private static IWebDriver GetFirefoxDriver()
        {
            //IWebDriver driver = new FirefoxDriver(GetFirefoxOptions()); //not working anymore
            IWebDriver driver = new FirefoxDriver();
            return driver;
        }

        [AssemblyInitialize] //makes this method run first 
        public static void InitWebdriver(TestContext tc) 
        {
            Browser.Config = new AppConfigReader();
            switch (Browser.Config.GetBrowser())
            {
                case BrowserType.Chrome:
                    Browser.Driver = GetChromeDriver();
                    break;

                case BrowserType.Firefox:
                    Browser.Driver = GetFirefoxDriver();
                    break;
                default:
                    throw new NoSuitableDriverFound($"Driver Not Found {Browser.Config.GetBrowser().ToString()}");
            }

            //PageLoad - For controlling the page load time
            Browser.Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(Browser.Config.GetPageLoadTimeout()); //implicit wait, will wait for 10 seconds before it throws an error

            //ImplicitWait - For controlling the web element load time
            Browser.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(Browser.Config.GetElementLoadTimeout());
        }

        [AssemblyCleanup] //runs last
        public static void Teardown()
        {
            if (Browser.Driver != null)
            {
                Browser.Driver.Close();
                Browser.Driver.Quit();
            }
        }
    }
}
