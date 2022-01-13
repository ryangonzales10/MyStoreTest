using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumWebdriver.ComponentHelper;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.TestScript.Button
{
    [TestClass]
    public class HandleButton
    {
        [TestMethod]
        public void TestButton()
        {
            NavigationHelper.NavigateToUrl(ObjectRepository.Config.GetWebsite());
            ObjectRepository.Driver.FindElement(By.XPath("//a[@class='login']")).Click();
            TextboxHelper.TypeInTextBox(By.Id("email"), ObjectRepository.Config.GetUsername());
            TextboxHelper.TypeInTextBox(By.Id("passwd"), ObjectRepository.Config.GetPassword());

            Console.WriteLine($"Is the button enabled? {ButtonHelper.IsButtonEnabled(By.Id("SubmitLogin"))}");

            Console.WriteLine($"The text inside the button is: {ButtonHelper.GetButtonText(By.XPath("//button[@id='SubmitLogin']/span"))}");

            //this is an alternative to the above line:
            string x = ObjectRepository.Driver.FindElement(By.XPath("//button[@id='SubmitLogin']/span")).Text; //you cannoy use .Text unless you are putting it on a string variable
            Console.WriteLine(x);

            ButtonHelper.ClickButton(By.Id("SubmitLogin"));

        }
    }
}
