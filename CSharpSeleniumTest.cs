#nullable enable

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace CSharpSeleniumTest
{
    public class CSharpSeleniumTest
    {
        private IWebDriver? driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void TestGoogleSearch()
        {
            driver.Navigate().GoToUrl("https://www.google.com");

            var searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("test");
            searchBox.Submit();

            // Wait for the results to load
            System.Threading.Thread.Sleep(2000);

            // Verify if the first result link is displayed
            var firstResultLink = driver.FindElement(By.CssSelector("h3"));
            Assert.That(firstResultLink.Displayed, Is.True, "The first result link should be displayed.");

            // Click on the first result link
            firstResultLink.Click();

            // Wait for the page to load
            System.Threading.Thread.Sleep(2000);

            // Verify if the new page title contains "test"
            Assert.That(driver.Title, Does.Contain("test"), "The page title should contain 'test'.");
        }

        [TearDown]
        public void TearDown()
        {
            driver?.Quit();
        }
    }
}
