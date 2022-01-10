using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumWebdriver.TestScript.TextBox
{
    [TestClass]
    public class TestTextBox
    {
        [TestMethod]
        public void TextBox()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            LinkHelper.ClickLink(By.XPath("//a[@class='login']")); //navigate to sign in page
            TextboxHelper.TypeInTextBox(By.Id("email"), ObjectRepository.Config.GetUsername()); //this is just SendKeys()
            TextboxHelper.TypeInTextBox(By.Id("passwd"), ObjectRepository.Config.GetPassword()); 
            TextboxHelper.ClearTextBox(By.Id("passwd")); //this is just Clear()
            

        
        }
    }
}
