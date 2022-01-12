using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.Dropdown
{
    [TestClass]
    public class DropdownTest
    {
        [TestMethod]
        public void TestList()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.FindElement(By.LinkText("Women")).Click();
            SelectElement dropdown = new SelectElement(ObjectRepository.Driver.FindElement(By.Id("selectProductSort")));
            dropdown.SelectByIndex(1); //selects second item on the list
            dropdown.SelectByText("Product Name: A to Z"); //this is the visible text
            dropdown.SelectByValue("quantity:desc"); //this is the value tag

            //to check the selected value:
            Console.WriteLine($"The selected option of the dropdown is {dropdown.SelectedOption.Text}");
            Assert.AreEqual("In stock", dropdown.SelectedOption.Text);

        }
    }
}
