using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using SeleniumWebdriver.Configuration;

namespace SeleniumWebdriver
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //ConfigurationManager is from a DLL we added called System.Configuration
            //It enables me to read a configuration file "App.config" 
            //You need to have <configuration> and <appSettings> in App.config
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Username"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Password"));
            Console.WriteLine($"This is the BrowserType content {BrowserType.Firefox}");
            Console.WriteLine($"This is the position of BrowserType firefox {(int)BrowserType.Firefox}");

        }
    }
}
