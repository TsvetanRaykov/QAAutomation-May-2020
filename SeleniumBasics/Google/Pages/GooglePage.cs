namespace SeleniumBasics.Google.Pages
{
#pragma warning disable 649
    using OpenQA.Selenium;
    using TestUtils.Decorators;

    public class GooglePage : BasePage
    {
        private const string TestUrl = "https://www.google.com";

        public GooglePage(WebDriver driver) : base(driver) { }

        private Element SearchField => this.Driver.FindElement(By.Name("q")) as WebElement;

        public GooglePage GoToGoogle()
        {
            this.Driver.Navigate(TestUrl);
            return this;
        }

        public SearchPage Search(string searchString)
        {
            this.SearchField.TypeText(searchString);
            this.SearchField.Submit();
            return new SearchPage(this.Driver);
        }
    }
}