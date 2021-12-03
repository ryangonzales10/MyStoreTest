using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.Settings
{
    //This class will specify all the keys that are in the App.config
    //Advantage is if you change the Browser in appconfig to BrowserType, the program won't mind because it is a constant called Browser
    public class AppConfigKeys
    {
        public const string Browser = "BrowserType"; //constant means you cannot modify it anymore
        public const string Username = "Username";
        public const string Password = "Password";
    }
}
