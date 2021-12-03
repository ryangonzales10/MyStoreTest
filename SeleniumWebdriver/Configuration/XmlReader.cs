using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumWebdriver.Interfaces;

namespace SeleniumWebdriver.Configuration
{
    //This class is used to provide its own implementation of the IConfig Interface /reading the data
    public class XmlReader : IConfig
    {
        public BrowserType GetBrowser()
        {
            throw new NotImplementedException();
        }

        public string GetPassword()
        {
            throw new NotImplementedException();
        }

        public string GetUsername()
        {
            throw new NotImplementedException();
        }
    }
}
