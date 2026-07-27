using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumAutomation.Tests;

public class GoogleTest
{
    private IWebDriver? driver;

    [SetUp]
    public void Setup()
    {
        driver = new ChromeDriver();

        driver.Manage().Window.Maximize();
    }

    [Test]
    public void VerifyGoogleTitle()
    {
        Assert.That(driver, Is.Not.Null);
        driver.Navigate().GoToUrl("https://www.google.com");

        Assert.That(driver.Title, Does.Contain("Google"));
    }

    [TearDown]
    public void Cleanup()
    {
        if (driver is not null)
        {
            driver.Quit();
            driver.Dispose();
            driver = null;
        }
    }
}