using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyStoreTestProject.Page_Objects;

namespace MyStoreTestProject.Step_Definitions
{
    [Binding]
    public sealed class Purchase_steps
    {

        #region Given
        [Given(@"the User clicks Quick View")]
        public void GivenTheUserClicksQuickView()
        {
            Page.QuickView();
        }

        #endregion


        #region When



        #endregion


        #region Then
        [Then(@"the Item's description, price and add to cart button should appear")]
        public void ThenTheItemSDescriptionPriceAndAddToCartButtonShouldAppear()
        {
            try
            {
                Browser.Webdriver.SwitchTo().Frame(1); //clicking quick view opens a new iframe. This line switches to that frame
                Browser.Webdriver.FindElement(By.XPath("//h1[text()='Faded Short Sleeve T-shirts']")); //checks description if correct
                Browser.Webdriver.FindElement(By.XPath("//span[@id='our_price_display' and text()='$16.51']")); //checks price if correct
                Browser.Webdriver.FindElement(By.XPath("//p[@id='add_to_cart']/descendant::span[text()='Add to cart']")); //checks if Add to Cart is present
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }


        #endregion

    }
}
