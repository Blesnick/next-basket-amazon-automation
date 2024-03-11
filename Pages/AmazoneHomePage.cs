using OpenQA.Selenium;

namespace AmazonAutomationTest.Pages
{
    public class AmazonHomePage
    {
        private readonly IWebDriver driver;

        public AmazonHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToHomePage(string url)
        {
            driver.Navigate().GoToUrl(url);

        }

        // In AmazonHomePage.cs
        public void SearchForItem(string searchTerm)
        {
            IWebElement searchBox = driver.FindElement(By.Id("twotabsearchtextbox"));
            searchBox.SendKeys(searchTerm + Keys.Enter);
        }

    }
}
