namespace SeleniumBasics.AutomationPractice.Pages
{
    using System;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.UI;
    using TestUtils.Decorators;

    public class AutomationPracticeRegisterPage : BasePage
    {
        public AutomationPracticeRegisterPage(WebDriver driver) : base(driver) { }

        private Element _emailField=>this.Driver.FindElement(By.Id("email"));

        public string GetEmailFieldValue()
        {
            new WebDriverWait(this.Driver.WrappedDriver, TimeSpan.FromSeconds(10))
                .Until(d => (bool)((IJavaScriptExecutor)d).
                  ExecuteScript("return document.getElementById('email').value !== ''"));

            return this._emailField.GetAttribute("value");
        }
    }
}