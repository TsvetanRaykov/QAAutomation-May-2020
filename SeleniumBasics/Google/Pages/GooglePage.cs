#pragma warning disable 649
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestUtils.Extensions;

namespace SeleniumBasics.Google.Pages
{
    public class GooglePage : BasePage
    {
        private const string TestUrl = "https://www.google.com";

        public GooglePage(IWebDriver driver) : base(driver) { }

        [CacheLookup, FindsBy(How = How.Name, Using = "q")]
        private IWebElement _searchField;

        public GooglePage GoToGoogle()
        {
            this.Driver.Navigate().GoToUrl(TestUrl);
            return this;
        }

        public SearchPage Search(string searchString)
        {
            this._searchField.SetFormInputValue(searchString);
            this._searchField.Submit();
            return new SearchPage(this.Driver);
        }
    }
}