using NUnit.Framework;
using OpenQA.Selenium;

namespace AutomationSeleniumC_.Implementation
{


    public class LoginImpl    {

        public IWebDriver driver;

        public LoginImpl(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void loginWithDifferentUsesrs(String user)
        {
            driver.FindElement(By.Id("user-name"))
                    .SendKeys(user);
            driver.FindElement(By.Id("password"))
                    .SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button"))
                    .Click();

            if (user == "locked_out_user")
            {
                String errorMsg = driver.FindElement(By.TagName("h3")).Text;
                Assert.IsTrue(errorMsg.Contains("Epic sadface: Sorry, this user has been locked out."));
                Console.WriteLine("----------------------> User was locked out!");
                return;
            } 
         
              Assert.IsTrue(driver.FindElement(By.XPath("//span[@class='title']")).Displayed);
              Console.WriteLine(user + " -----------------------> was successfully logged in!");
           
        }
    }
}
