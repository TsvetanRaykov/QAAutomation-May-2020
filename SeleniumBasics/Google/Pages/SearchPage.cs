namespace SeleniumBasics.Google.Pages
{
    using OpenQA.Selenium;
    using TestUtils.Decorators;

    public class SearchPage : BasePage
    {
        public SearchPage(WebDriver driver) : base(driver) { }

        private Element FirstResult => this.Driver.FindElement(By.XPath("//*[@id='rso']//a"));

        public TestPage GoToFirstResult()
        {
            this.Driver
                .Navigate(this.FirstResult.GetAttribute("href"));

            return new TestPage(this.Driver);
        }
    }
}