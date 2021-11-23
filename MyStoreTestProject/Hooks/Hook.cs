using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyStoreTestProject.Hooks
{
    [Binding]
    public sealed class Hook
    {
        [BeforeScenario]
        public void BeforeScenario()
        {
            //This runs before any other steps are run
            Browser.Webdriver = new ChromeDriver();
            Browser.Webdriver.Manage().Window.Maximize();
            Browser.Webdriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20); //implicit wait. Will wait before the item appears in page
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //This runs after all the steps have ran
            Browser.Webdriver.Close();
            Browser.Webdriver.Quit();
        }
    }
}
