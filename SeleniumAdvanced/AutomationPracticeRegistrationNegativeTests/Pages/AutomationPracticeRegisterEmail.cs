using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestUtils.Extensions;

namespace SeleniumAdvanced.AutomationPracticeRegistrationNegativeTests.Pages
{
    public class AutomationPracticeRegisterEmail : BasePage
    {
        public AutomationPracticeRegisterEmail(IWebDriver driver) : base(driver) { }

        [CacheLookup, FindsBy(How = How.Id, Using = "email_create")]
        private IWebElement _registerEmailField;

        [CacheLookup, FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement _submitButton;

        public AutomationPracticeRegisterEmail FillEmailFormWithValidEmail(string email)
        {
            this.Driver.PageReady();
            this._registerEmailField.SendKeys(email);
            return this;
        }

        public AutomationPracticeRegistration GoToRegistrationPage()
        {
            this._submitButton.Click();
            return new AutomationPracticeRegistration(this.Driver);
        }
    }
}