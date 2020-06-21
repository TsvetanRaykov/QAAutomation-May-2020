namespace SeleniumBasics
{
    using TestUtils.Decorators;

    public class BasePage
    {
        protected readonly WebDriver Driver;

        protected BasePage(WebDriver driver)
        {
            this.Driver = driver;
        }
    }
}