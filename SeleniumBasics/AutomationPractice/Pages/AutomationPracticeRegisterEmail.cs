using OpenQA.Selenium;
using SeleniumBasics.AutomationPractice.Models;
using SeleniumExtras.PageObjects;
using TestUtils.Extensions;

namespace SeleniumBasics.AutomationPractice.Pages
{
    public class AutomationPracticeRegisterEmail : BasePage
    {
        public AutomationPracticeRegisterEmail(IWebDriver driver) : base(driver) { }

        [CacheLookup, FindsBy(How = How.Id, Using = "email_create")]
        private IWebElement _registerEmailField;

        [CacheLookup, FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement _submitButton;

        public AutomationPracticeRegisterPage FillRegistrationForm(Subscriber user)
        {
            this.Driver.PageReady();
            this._registerEmailField.SendKeys(user.Email);
            this._submitButton.Click();
            return new AutomationPracticeRegisterPage(this.Driver);
        }

    }
}