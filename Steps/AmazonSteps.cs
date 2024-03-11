using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using AmazonAutomationTest.Pages;
using NUnit.Framework;
using System.Threading;



namespace AmazonAutomationTest.Steps
{
    [Binding]
    public class AmazonSteps
    {
        private IWebDriver driver;
        private AmazonHomePage amazonHomePage;
        private AmazonProductPage amazonProductPage;
        private AmazonCartPage amazonCartPage;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = WebDriverFactory.CreateWebDriver();
            amazonHomePage = new AmazonHomePage(driver);
            amazonProductPage = new AmazonProductPage(driver);
            amazonCartPage = new AmazonCartPage(driver);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

        [Given(@"I navigate to Amazon as an unregistered user")]
        public void GivenINavigateToAmazonAsAnUnregisteredUser()
        {
            amazonHomePage.GoToHomePage("https://www.amazon.com/");
            Thread.Sleep(20000);
        }

        [When(@"I search for TP-Link N450 WiFi Router")]
        public void WhenISearchFor()
        {
            amazonHomePage.SearchForItem("TP-Link N450 WiFi Router - Wireless Internet Router for Home (TL-WR940N)");
            amazonCartPage.clickProduct();
            amazonCartPage.seeAllBuyingOptions();



        }



        [When(@"I add the corresponding item to the cart")]
        public void WhenIAddTheCorrespondingItemToTheCart()
        {
            amazonProductPage.viewCartBtn();

        }

        [When(@"I navigate to cart")]
        public void WhenINavigateToCart()
        {

            amazonCartPage.GoToCart();
        }

        [Then(@"I validate the correct item and amount is displayed")]
        public void ThenIValidateTheCorrectItemAndAmountIsDisplayed()
        {
            bool isItemInCart = amazonCartPage.IsItemInCart("Wireless Internet Router for Home (TL-WR940N)");
            Assert.IsTrue(isItemInCart);

            bool isAmountDisplayed = amazonCartPage.IsAmountDisplayed();
            Assert.IsTrue(isAmountDisplayed);
        }
    }
}
