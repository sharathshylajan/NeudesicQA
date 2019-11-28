using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using UnitTestProject1;

namespace TR1AssessmentProject
{
    [TestClass]
    public class TR1Assessment: BasePage //Generic functions in BasePage.cs
    {
        [TestMethod]
        public void Basic()
        {
            #region[Basic] #1 Identify element using ID attribute & verify if it's displayed
            GotoUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
            //Develope the code within the respective region

            #endregion

            #region[Basic] #2 Identify 'Click me using this link text' link using LinkText, click on that element & Verify 'Link success' text after clicking
            GotoUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
            

            #endregion

            #region[Basic] #3 Radio Button - Click on 'Male' radio button if not selected
            GotoUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
           

            #endregion

            #region[Basic] #4 Select ‘Audi’ from the dropdown and validate that ‘Audi’ is selected 
            GotoUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
            

            #endregion

            #region[Basic] #5 Fetch the ‘Salary’ whose work is ‘Manual’ from the web table with no ID
            GotoUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
            

            #endregion
        }
        [TestMethod]
        public void Intermediate()
        {
            #region[Intermediate] #1 [A]Form - Positive Scenario 
            GotoUrl("https://ultimateqa.com/filling-out-forms/");
            

            #endregion

            #region[Intermediate] #1 [B] Form - Negative Scenario 
            GotoUrl("https://ultimateqa.com/filling-out-forms/");
            

            #endregion

            #region[Intermediate] #2 Action + Pop Up handling 
            GotoUrl("https://demoqa.com/tooltip-and-double-click/");
            

            #endregion

            #region[Intermediate] #3 Window Handling
            GotoUrl("https://demoqa.com/automation-practice-switch-windows/");
            
            
            #endregion

            #region[Intermediate] #4 Use JavaScriptExecutor to click on any element on the web page 
            GotoUrl("https://ultimateqa.com/simple-html-elements-for-automation/");
           

            #endregion

            #region[Intermediate] #5 iFrame Handling
            GotoUrl("http://hugelearning.com/iframe-practice-page/");
           

            #endregion
        }

        #region[Intermediate] #6 Implement NUnit/MSTest annotations in the current solution
        

        #endregion
        
    }
}
