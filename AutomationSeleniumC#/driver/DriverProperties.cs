using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;

namespace AutomationSeleniumC_.driver
{
    public class DriverProperties
    {
        public IWebDriver driver;

        public IWebDriver getWebDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito"); 

            new DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            return driver;
        }
    }
}
