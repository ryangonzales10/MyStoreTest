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
            NavigationHelper.NavigateToUrl(Browser.Config.GetWebsite());
            Browser.Driver.FindElement(By.LinkText("Women")).Click();

            SelectElement dropdown = new SelectElement(Browser.Driver.FindElement(By.Id("selectProductSort")));

            dropdown.SelectByIndex(1); //selects second item on the list. or...
            DropdownHelper.DropdownSelectByIndex(By.Id("selectProductSort"), 1);

            dropdown.SelectByText("Product Name: A to Z"); //this is the visible text. or...
            DropdownHelper.DropdownSelectByText(By.Id("selectProductSort"), "Product Name: A to Z");

            dropdown.SelectByValue("quantity:desc"); //this is the value tag. or...
            DropdownHelper.DropdownSelectByValue(By.Id("selectProductSort"), "quantity:desc");

 
            


            //to check the selected value:
            Console.WriteLine($"The selected option of the dropdown is {dropdown.SelectedOption.Text}"); //.Text at the end converts it  to a string
            Assert.AreEqual("In stock", dropdown.SelectedOption.Text);

            //to get all the list in the dropdown
            IList<IWebElement> allOptionsInList = dropdown.Options; //here's a List (IList) with each item as IWebElement

            //this is the basic way:
            for (int x = 0; x < allOptionsInList.Count; x++)
            {
                Console.WriteLine($"Option {x + 1} is: {allOptionsInList[x].Text}");
            }

            //this is a fancier way
            foreach (IWebElement x in allOptionsInList)
            {
                Console.WriteLine($"Option value: {x.GetAttribute("value")}, text: {x.Text}");
            }

            //this is using the helper class
            foreach (string y in DropdownHelper.GetAllItems(By.Id("selectProductSort")))
            {
                Console.WriteLine($"Text: {y}");
            }
        }
    }
}
