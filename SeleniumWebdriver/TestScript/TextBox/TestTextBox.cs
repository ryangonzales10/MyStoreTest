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
            ObjectRepository.Driver.FindElement(By.XPath("//a[@class='login']")).Click();
            ObjectRepository.Driver.FindElement(By.Id("email")).SendKeys("rvg_23@yahoo.com");
            ObjectRepository.Driver.FindElement(By.Id("passwd")).SendKeys("burubugudstoystugudunstuy");
            ObjectRepository.Driver.FindElement(By.Id("passwd")).Clear();
        }
    }
}
