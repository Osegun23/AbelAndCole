using AbelAndCole.Utilities;
using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbelAndCole.PageObjects
{
    class DataWithExamplePage
    {
        IWebDriver driver;
        //WebDriverWait wait;
        
        public DataWithExamplePage() 
        {

            driver = Hooks1.driver;
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            /*DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(10);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(250);*/
        }

        IWebElement StartShopping => driver.FindElement(By.CssSelector("a.hero-button.push-banner"));
        IWebElement Search => driver.FindElement(By.Id("search-term"));
        IWebElement SearchButton => driver.FindElement(By.Id("search-btn"));
        IWebElement BrownieSelect => driver.FindElement(By.XPath("//*[@id=\"product-list\"]/li[2]/div[3]/div[3]/div[2]/div[1]"));

        IWebElement HummusChipsSelect => driver.FindElement(By.XPath("//*[@id=\"product-list\"]/li/div[3]/div[3]/div[2]/div[1]"));
        IWebElement HummusPlusSign => driver.FindElement(By.XPath("//*[@id=\"product-list\"]/li/div[3]/div[3]/div[2]/div[2]/div/div[3]"));
        IWebElement SaltedPopcornSelect => driver.FindElement(By.XPath("//*[@id=\"product-list\"]/li[1]/div[3]/div[3]/div[2]/div[1]"));
        IWebElement PopcornPlusSign => driver.FindElement(By.XPath("//*[@id=\"product-list\"]/li[1]/div[3]/div[3]/div[2]/div[2]/div/div[3]"));
        IWebElement BasketCount => driver.FindElement(By.Id("BasketCount"));
        IWebElement NumberInBasket => driver.FindElement(By.XPath("//span[text()='6']"));


        public void NavigateToURL(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void BeginToShop()
        {
            StartShopping.Click();
        }

        public void FirstProduct(string product1)
        {
            Search.SendKeys(product1);
            SearchButton.Click();
            BrownieSelect.Click();
            
        }

        public void SecondProduct(string product2) 
        {
            
            Search.SendKeys(product2);
            SearchButton.Click();
            //wait.Until(ExpectedConditions.ElementToBeClickable(HummusChipsSelect));
            HummusChipsSelect.Click();
            int i = 1;
            while(i<3) 
            {
                //wait.Until(ExpectedConditions.ElementToBeClickable(HummusPlusSign));
                HummusPlusSign.Click();
                i++;
            }
        }

        public void ThirdProduct(string product3) 
        {
            Search.SendKeys(product3);
            SearchButton.Click();
            //wait.Until(ExpectedConditions.ElementToBeClickable(SaltedPopcornSelect));
            SaltedPopcornSelect.Click();
            int i = 1;
            while (i < 2)
            {
                //wait.Until(ExpectedConditions.ElementToBeClickable(PopcornPlusSign));
                PopcornPlusSign.Click();
                i++;
            }
        }

        public void Cart()
        {
           var Count = BasketCount.Text;
            Console.WriteLine(Count);
        }

        public bool NumberCount()
        {
            return NumberInBasket.Displayed;
             
        }




    }
}
