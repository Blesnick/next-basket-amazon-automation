using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AmazonAutomationTest
{
    public class WebDriverFactory
    {
        public static IWebDriver CreateWebDriver()
        {
            ChromeOptions options = new ChromeOptions();
            // Remove the headless option to run in headed mode
            // options.AddArgument("--headless");

            // Optionally, you can set other Chrome options here
            // options.AddArgument("--start-maximized");

            // Initialize the Chrome driver with the options
            return new ChromeDriver(options);
        }
    }
}
