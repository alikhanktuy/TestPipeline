using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using VK.Models;

namespace VK
{
    public class Tests
    {
        IWebDriver webDriver;
        [SetUp]
        public void Setup()
        {
            webDriver = new ChromeDriver(); 
            webDriver.Navigate().GoToUrl("https://soundcloud.com/");
            webDriver.Manage().Window.FullScreen();
        }

        [Test]
        public void Run()
        {

            var loginPage = new LoginPage(webDriver);
            var homePage = loginPage.Login("vasyaepam96@gmail.com","123123aA");
            Assert.AreEqual(homePage.GetTitle(), @"Our robots think you are a robot.
Try reloading the page. If you continue to have this problem, please visit our Help center.");
        }
        [TearDown]
        public void TearDown()
        {
            webDriver.Quit();
        }
    }
}