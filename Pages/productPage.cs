using OpenQA.Selenium;
using System;
using System.Threading;

namespace AmazonAutomationTest.Pages
{
    public class AmazonProductPage
    {
        private readonly IWebDriver driver;

        public AmazonProductPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        public void viewCartBtn()
        {
            Thread.Sleep(5000);
            IWebElement addToCartButton = driver.FindElement(By.CssSelector("input[name=\"submit.addToCart\"]"));

            // Click on the Add to Cart button
            addToCartButton.Click();

            IWebElement viewCart = driver.FindElement(By.XPath("//form/span/span/input"));

            // Click on the view Cart button
            Thread.Sleep(5000);
            viewCart.Click();

        }


    }
}
