using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.Checkbox
{
    [TestClass]
    public class TestCheckBox
    {
        [TestMethod]
        public void TestBox()
        {
            NavigationHelper.NavigateToUrl(Browser.Config.GetWebsite());
            Browser.Driver.FindElement(By.XPath("//a[@title='Women']")).Click(); //clicks Women section
            CheckboxHelper.CheckedCheckbox(By.Id("uniform-layered_category_4"));
            CheckboxHelper.IsCheckboxChecked(By.XPath("//div[@id='uniform-layered_category_4']/span")); //this is showing false!!! 
                 
        }
    }
}
