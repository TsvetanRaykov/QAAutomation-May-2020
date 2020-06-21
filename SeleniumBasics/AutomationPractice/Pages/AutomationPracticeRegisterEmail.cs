namespace SeleniumBasics.AutomationPractice.Pages
{
    using OpenQA.Selenium;
    using SeleniumBasics.AutomationPractice.Models;
    using TestUtils.Decorators;

    public class AutomationPracticeRegisterEmail : BasePage
    {
        public AutomationPracticeRegisterEmail(WebDriver driver) : base(driver) { }

      private Element RegisterEmailField => this.Driver.FindElement(By.Id("email_create"));

        private Element SubmitButton => this.Driver.FindElement(By.Id("SubmitCreate"));

        public AutomationPracticeRegisterPage FillRegistrationForm(Subscriber user)
        {
            this.RegisterEmailField.TypeText(user.Email);
            this.SubmitButton.Click();
            return new AutomationPracticeRegisterPage(this.Driver);
        }

    }
}