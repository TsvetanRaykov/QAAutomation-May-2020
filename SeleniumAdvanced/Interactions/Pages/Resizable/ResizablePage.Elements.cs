using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Interactions.Pages.Resizable
{
    public partial class ResizablePage
    {
        public ResizablePage(IWebDriver driver) : base(driver) { }

        [CacheLookup, FindsBy(How = How.Id, Using = "resizableBoxWithRestriction")]
        private IWebElement _resizableRestrictedBox;

        [CacheLookup]
        private IWebElement _resizableRestrictedBoxHandler =>
            this._resizableRestrictedBox.FindElement(By.XPath("span"));

        [CacheLookup, FindsBy(How = How.Id, Using = "resizable")]
        private IWebElement _resizableBox;

        [CacheLookup]
        private IWebElement _resizableBoxHandler =>
            this._resizableBox.FindElement(By.XPath("span"));

        protected override string Url => "http://demoqa.com/resizable";

    }
}