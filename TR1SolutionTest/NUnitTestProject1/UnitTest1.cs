using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Tests
    {
        IWebDriver _webDriver;
        [SetUp]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            _webDriver.Manage().Window.Maximize();
            _webDriver.Url = "www.google.com";
            Assert.Pass();
        }
    }
}