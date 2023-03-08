using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationSeleniumC_.driver
{
    public class InitializeUserDriver
    {

        public IWebDriver driver;

        DriverProperties driverProperties = new DriverProperties();

        [SetUp]
        public void Setup()

        {
            driver = driverProperties.getWebDriver();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Console.WriteLine("--------------------------> Start of Test!");
        }

        [TearDown]
        public void TearDown()

        {
            driver.Quit();
            Console.WriteLine("-----------------------> Driver Closed!");

        }
    }
}
