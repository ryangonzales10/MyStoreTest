using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        }

        #endregion


        #region When



        #endregion


        #region Then
        [Then(@"the Item's description, price and add to cart button should appear")]
        public void ThenTheItemSDescriptionPriceAndAddToCartButtonShouldAppear()
        {

        }


        #endregion

    }
}
