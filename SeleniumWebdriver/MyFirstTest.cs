using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;
using SeleniumWebdriver.Configuration;
using SeleniumWebdriver.Interfaces;

namespace SeleniumWebdriver
{
    [TestClass]
    public class MyFirstTest
    {
        [TestMethod]
        public void MyFirstTestMethod()
        {
            //ConfigurationManager is from a DLL we added called System.Configuration
            //It enables me to read a configuration file "App.config" 
            //You need to have <configuration> and <appSettings> in App.config

            //random tests
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Browser"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Username"));
            Console.WriteLine(ConfigurationManager.AppSettings.Get("Password"));
            Console.WriteLine($"This is the BrowserType content {BrowserType.Firefox}");
            Console.WriteLine($"This is the position of BrowserType firefox {(int)BrowserType.Firefox}");


            //IConfig config = new IConfig; - this is an abstract class (interface), so we cannot instantiate it as an object
            IConfig config = new AppConfigReader(); //use the derived class instead
            IConfig config2 = new XmlReader();

            Console.WriteLine($"Browser: {config.GetBrowser()}");
            Console.WriteLine($"Username: {config.GetUsername()}");
            Console.WriteLine($"Password: {config.GetPassword()}");

        }
    }
}
