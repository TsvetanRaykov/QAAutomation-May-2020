namespace SeleniumAdvanced.AutomationPracticeRegistrationNegativeTests.Pages
{
    using OpenQA.Selenium;
    using TestUtils.Decorators;

    public class AutomationPracticeRegisterEmail : BasePage
    {
        public AutomationPracticeRegisterEmail(WebDriver driver) : base(driver) { }

        private Element RegisterEmailField => this.Driver.FindElement(By.Id("email_create"));

        private Element SubmitButton => this.Driver.FindElement(By.Id("SubmitCreate"));

        public AutomationPracticeRegisterEmail FillEmailFormWithValidEmail(string email)
        {
            this.RegisterEmailField.TypeText(email);
            return this;
        }

        public AutomationPracticeRegistration GoToRegistrationPage()
        {
            this.SubmitButton.Click();
            return new AutomationPracticeRegistration(this.Driver);
        }
    }
}