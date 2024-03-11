using OpenQA.Selenium;

namespace AmazonAutomationTest.Pages
{
    public class AmazonCartPage
    {
        private readonly IWebDriver driver;

        public AmazonCartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public bool IsItemInCart(string itemName)
        {
            IWebElement cartItem = driver.FindElement(By.XPath($"//span[contains(text(), '{itemName}')]"));
            return cartItem != null;
        }
        // In AmazonCartPage.cs
        public void GoToCart()
        {
            // Implement the logic to navigate to the cart page here
        }

        public bool IsAmountDisplayed()
        {
            IWebElement cartAmount = driver.FindElement(By.XPath("//span[@id='sc-subtotal-amount-activecart']/span"));
            return cartAmount != null;
        }
        public void clickProduct()
        {
            IWebElement wifi = driver.FindElement(By.LinkText("N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)"));
            wifi.Click();
        }
        public void seeAllBuyingOptions()
        {
            IWebElement buyingOptions = driver.FindElement(By.LinkText("See All Buying Options"));
            buyingOptions.Click();

        }
    }
}
