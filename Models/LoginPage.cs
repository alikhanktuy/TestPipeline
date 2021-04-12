using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace VK.Models
{
    public class LoginPage
    {
        private IWebDriver driver;
        private By signinButtonBy = By.XPath("//*[@id='content']/div/div/div[1]/div/div[2]/button[1]");
        private By emailInputBy = By.XPath("//*[@id='sign_in_up_email']");
        private By continueButtonBy = By.XPath("//button[@id='sign_in_up_submit']");
        private By passwordFieldBy = By.XPath("//input[@id='enter_password_field']");
        private By enterPasswordButtonBy = By.XPath("//button[@id='enter_password_submit']");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        public HomePage Login(string email,string password)
        {

            driver.FindElement(signinButtonBy).Click();
            Thread.Sleep(200);

            var frame = driver.FindElement(By.XPath("/html/body/div[3]/div/div/div/iframe"));
            driver.SwitchTo().Frame(frame);
            driver.FindElement(emailInputBy).SendKeys(email);
            driver.FindElement(continueButtonBy).Click();
            Thread.Sleep(1000);
            driver.FindElement(passwordFieldBy).SendKeys(password);
            driver.FindElement(enterPasswordButtonBy).Click();
            Thread.Sleep(500);
            return new HomePage(driver);
        }
    }
}
