using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Configuration;

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

        }
    }
}
