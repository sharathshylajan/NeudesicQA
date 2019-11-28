using System;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace UnitTestProject1
{
    public class BasePage
    {
        public IWebDriver driver;

        #region [Basic] #6 Multiple Browser Implementation 
        /// <summary>
        /// Method to implement multiple browser capabilities
        /// </summary>
        /// <param name="browser"></param>
        public void InitilizeBrowser(string browser)
        {
            //Add Chrome & Firefox browser capabilities 
        }
        #endregion

        /// <summary>
        /// Method to navigate to a specific URL
        /// </summary>
        /// <param name="url"></param>
        public void GotoUrl(String url)
        {
           
        }

    }
}
