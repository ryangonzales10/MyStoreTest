using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyStoreTestProject
{
    class Browser
    {
        //property for Webdriver so that it can be called at different parts of the program
        //this is encapsulation, so that sensitive data is hidden from the users
        //get - set means this has read and write 
        //get - we are "getting" the value and passing it on. Used in i.e. Console.Log(x);
        //set - we are "setting" the value, we are getting inputs to instantiate this. Used in i.e. x = 10;
        public static IWebDriver Webdriver { get; set; }
    }
}
