using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using OpenQA.Selenium.Interactions;
using SeleniumWebdriver.ComponentHelper;

namespace SeleniumWebdriver.TestScript.Hyperlink
{
    [TestClass]
    public class TestHyperlink
    {
        [TestMethod]
        public void ClickLink()
        {
            Actions action = new Actions(Browser.Driver);
            NavigationHelper.NavigateToUrl(Browser.Config.GetWebsite());
            Browser.Driver.FindElement(By.XPath("//a[@class='login']")).Click();
            
            Browser.Driver.FindElement(By.LinkText("Forgot your password?")).Click(); //this is the exact hyperlink text
            
            //you can put the above in a variable, but it has to be IWebElement
            //IWebElement element = Browser.Driver.FindElement(By.LinkText("Forgot your password?"));
        }

    }
}

