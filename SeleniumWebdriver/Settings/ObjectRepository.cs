using OpenQA.Selenium;
using SeleniumWebdriver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//This will contain objects and properties used by other classes in our framework
namespace SeleniumWebdriver.Settings
{
    public class ObjectRepository
    {
        public static IConfig Config {get; set;}
        public static IWebDriver Driver { get; set; }

    }
}
