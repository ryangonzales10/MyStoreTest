using OpenQA.Selenium;
using SeleniumWebdriver.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumWebdriver.ComponentHelper
{
    public class CheckboxHelper
    {
        //this is another approach
        private static IWebElement element;
        public static void CheckedCheckbox(By Locator)
        {
            element = GenericHelper.GetElement(Locator);
            element.Click();
        }


        public static bool IsCheckboxChecked(By Locator) //study me
        {
            
            element = GenericHelper.GetElement(Locator);

            //ObjectRepository.Driver.FindElement(Locator).GetAttribute("checked");
            string flag = element.GetAttribute("class");
            //get the attribute checked and store it in string flag

            if (flag == null) return false;
            else return flag.Equals("true") || flag.Equals("checked");
            //true if the value parameter is the same as the value of this instance, otherwise false. If value is null, returns false

        }



    }
}
