using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace SeleniumBasics.AutomationPractice.Pages
{
    public class AutomationPracticeRegisterPage : BasePage
    {
        public AutomationPracticeRegisterPage(IWebDriver driver) : base(driver) { }

        [CacheLookup, FindsBy(How = How.Id, Using = "email")]
        private IWebElement _emailField;

        public string GetEmailFieldValue()
        {
            new WebDriverWait(this.Driver, TimeSpan.FromSeconds(10))
                .Until(d => (bool)((IJavaScriptExecutor)d).
                  ExecuteScript("return document.getElementById('email').value !== ''"));

            return this._emailField.GetAttribute("value");
        }
    }
}