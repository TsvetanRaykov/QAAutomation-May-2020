namespace SeleniumAdvanced.AutomationPracticeRegistrationNegativeTests.Pages
{
    using OpenQA.Selenium;
    using TestUtils.Decorators;

    public class AutomationPracticeHome : BasePage
    {
        private const string Url = "http://automationpractice.com/index.php";

        public AutomationPracticeHome(WebDriver driver) : base(driver) { }

        public AutomationPracticeRegisterEmail GoToEmailForm()
        {
            this.Driver.Navigate(Url);
            this.SignInItem.Click();
            return new AutomationPracticeRegisterEmail(this.Driver);
        }

        private Element SignInItem => this.Driver.FindElement(By.XPath("//a[@class='login']"));

    }
}