using AbelAndCole.PageObjects;
using AbelAndCole.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using TechTalk.SpecFlow;

namespace AbelAndCole.StepDefinitions
{
    [Binding]
    public class DataWithExampleStepDefinitions
    {
        public IWebDriver driver = Hooks1.driver;
        DataWithExamplePage dataWithExamplePage;

        public DataWithExampleStepDefinitions()
        {
            dataWithExamplePage = new DataWithExamplePage();
        }
            
  

        [Given(@"I Navigate to ""([^""]*)""")]
        public void GivenINavigateTo(string url)
        {
            dataWithExamplePage.NavigateToURL(url);
        }

        [Given(@"i click on start shopping")]
        public void GivenIClickOnStartShopping()
        {
            dataWithExamplePage.BeginToShop();
        }

        [Given(@"i add product ""([^""]*)""")]
        public void GivenIAddProduct(string product1)
        {
            dataWithExamplePage.FirstProduct(product1);
        }

        [Given(@"i add second product ""([^""]*)""")]
        public void GivenIAddSecondProduct(string product2)
        {
            dataWithExamplePage.SecondProduct(product2);
        }

        [Given(@"i add third product ""([^""]*)""")]
        public void GivenIAddThirdProduct(string product3)
        {
            
            Thread.Sleep(3000);
            dataWithExamplePage.ThirdProduct(product3);
        }

        [When(@"i grab the Cart text")]
        public void WhenIGrabTheCartText()
        {
        
            Thread.Sleep(3000);
            dataWithExamplePage.Cart();
        }

        [Then(@"i should see the total number of products in my basket")]
        public void ThenIShouldSeeTheTotalNumberOfProductsInMyBasket()
        {
            Thread.Sleep(5000);
            Assert.That(dataWithExamplePage.NumberCount); ;
        }








    }
}
