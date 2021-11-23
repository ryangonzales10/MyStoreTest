using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MyStoreTestProject.Page_Objects
{
    public class Element
    {
        //put all the page objects here
        public static string signinbutton1 = "//a[@title='Log in to your customer account']";
        public static string email = "email";
        public static string password = "passwd";
        public static string singinbuttongreen = "SubmitLogin";
    }

    class Page : Element
    {
        //put all the actions here
        public static void  SignIn1() => Browser.Webdriver.FindElement(By.XPath(signinbutton1)).Click();
        public static void Username(string x) => Browser.Webdriver.FindElement(By.Id(email)).SendKeys(x);
        public static void Password(string x) => Browser.Webdriver.FindElement(By.Id(password)).SendKeys(x);
        public static void SignIn2() => Browser.Webdriver.FindElement(By.Id(singinbuttongreen)).Click();
        public static void ClearUsername() => Browser.Webdriver.FindElement(By.Id(email)).Clear();
        public static void ClearPassword() => Browser.Webdriver.FindElement(By.Id(password)).Clear();

    }
}
