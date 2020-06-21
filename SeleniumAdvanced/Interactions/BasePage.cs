namespace SeleniumAdvanced.Interactions
{
    using OpenQA.Selenium.Interactions;
    using TestUtils.Decorators;

    public abstract class BasePage
    {
        protected abstract string Url { get; }

        protected BasePage(WebDriver driver)
        {
            this.Driver = driver;
            this.Builder = new Actions(this.Driver.WrappedDriver);
            this.Navigate();
        }

        protected WebDriver Driver { get; }
        protected Actions Builder { get; }

        private void Navigate()
        {
            this.Driver.Navigate(this.Url);
        }

    }
}