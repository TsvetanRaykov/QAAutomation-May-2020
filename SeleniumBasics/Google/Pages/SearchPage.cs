using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumBasics.Google.Pages
{
    public class SearchPage : BasePage
    {
        public SearchPage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.XPath, Using = "//*[@id='rso']//a")]
        private readonly IWebElement _firstResult;

        public TestPage GoToFirstResult()
        {
            this.Driver
                .Navigate()
                .GoToUrl(this._firstResult.GetAttribute("href"));
            return new TestPage(this.Driver);
        }
    }
}