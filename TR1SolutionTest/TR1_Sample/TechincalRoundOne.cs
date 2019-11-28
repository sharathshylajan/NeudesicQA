using System;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumDemo.Utilities
{
    public class TechincalRoundOne
    {
        public static IWebDriver driver;

        [Test]
        public void TestMethod1()
        {
            ChromeOptions options = new ChromeOptions();
            driver = new ChromeDriver("C:\\Users\\pavan.gundapanthula\\source\\repos\\SeleniumDemo", options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.google.com/gmail/about/#");
            UtilitiesHelper.Neu_GenericTestStepRecorder(true, "Navigation to the Gmail about sccreen is successful.");
            driver.Neu_TakeScreenShotExtension("Gmail About Screen");
            driver.FindElement(By.XPath("//*[@class='h-c-header__nav-li g-mail-nav-links']//child::a[contains(text(),'Sign in')]")).Click();
            UtilitiesHelper.Neu_SwitchWindow(driver, "Gmail");
            UtilitiesHelper.Neu_GenericTestStepRecorder(true, "Navigation to the Gmail Login sccreen is successful.");
            driver.Neu_TakeScreenShotExtension("User Name Screen");
            driver.FindElement(By.Id("identifierId")).SendKeys("Neudesic983");
            UtilitiesHelper.Neu_GenericTestStepRecorder(true, "Entered the username successfully.");
            driver.Neu_TakeScreenShotExtension("User Name Entered");
            driver.FindElement(By.Id("identifierNext")).Click();
            UtilitiesHelper.Neu_GenericTestStepRecorder(true, "Clicked on Next Button.");
            driver.Neu_TakeScreenShotExtension("Password Screen");
            driver.FindElement(By.Name("password")).SendKeys("Neudesic@123");
            UtilitiesHelper.Neu_GenericTestStepRecorder(true, "Entered the password successfully.");
            driver.Neu_TakeScreenShotExtension("Password Entered Screen");
            driver.FindElement(By.Id("passwordNext")).Click();
            UtilitiesHelper.Neu_GenericTestStepRecorder(true, "Clicked on Sign In Button.");
            driver.Neu_TakeScreenShotExtension("Gmail Landing Screen");

            Thread.Sleep(5000);

            driver.FindElement(By.XPath("//*[text()='Compose']")).Neu_WaitForControlReady(driver, 5000);
            driver.FindElement(By.XPath("//*[text()='Compose']")).Click();
            driver.FindElement(By.XPath("//textarea[@name='to']")).Neu_WaitForControlReady(driver, 5000);
            driver.FindElement(By.XPath("//textarea[@name='to']")).SendKeys("Neudesic983@gmail.com");
            driver.FindElement(By.XPath("//input[@name='subjectbox']")).SendKeys("Testing Mail @ " + DateTime.Now);
            driver.FindElement(By.XPath("//*[text()='Send']//ancestor::div[3]//descendant::div[19]")).Click();

            #region Handle Windows Controls here
            // Write your logic to upload a file......

            #endregion

            Thread.Sleep(10000);
            driver.FindElement(By.XPath("//*[text()='Send']")).Click();
            Thread.Sleep(10000);
            driver.Quit();
        }
        
    }
}
