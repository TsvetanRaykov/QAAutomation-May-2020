namespace SeleniumBasics.AutomationPractice.Pages
{
    using OpenQA.Selenium;
    using TestUtils.Decorators;

    public class AutomationPracticePage : BasePage
    {
        private const string Url = "http://automationpractice.com/index.php";

        public AutomationPracticePage(WebDriver driver) : base(driver) { }

      private Element SignInItem => this.Driver.FindElement(By.XPath("//a[@class='login']"));

        public AutomationPracticePage GoToAutomationPracticePage()
        {
            this.Driver.Navigate(Url);
            return this;
        }

        public AutomationPracticeRegisterEmail GoToLoginPage()
        {
            this.SignInItem.Click();
            return new AutomationPracticeRegisterEmail(this.Driver);
        }
    }
}