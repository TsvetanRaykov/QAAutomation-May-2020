namespace SeleniumAdvanced.AutomationPracticeRegistrationNegativeTests
{
    using TestUtils.Decorators;

    public abstract class BasePage
    {
        protected readonly WebDriver Driver;

        protected BasePage(WebDriver driver)
        {
            this.Driver = driver;
        }
    }
}