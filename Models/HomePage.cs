using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace VK.Models
{
    public class HomePage
    {
        private IWebDriver driver;
        private By hui = By.XPath("//*[@id='signInPasswordForm']/div[3]/div/p");
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public string GetTitle()
        {
            string sad= driver.FindElement(hui).Text;
            return driver.FindElement(hui).Text;
        }
    }
}
