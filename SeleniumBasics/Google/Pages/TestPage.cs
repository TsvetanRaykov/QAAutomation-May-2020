namespace SeleniumBasics.Google.Pages
{
    using TestUtils.Decorators;

    public class TestPage : BasePage
    {
        public TestPage(WebDriver driver) : base(driver) { }

        public string GetPageTitle()
        {
            return this.Driver.WrappedDriver.Title;
        }
    }
}