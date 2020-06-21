using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Interactions.Pages.Selectable
{
    public partial class SelectablePage
    {
        public SelectablePage(IWebDriver driver) : base(driver) { }

        [CacheLookup, FindsBy(How = How.Id, Using = "verticalListContainer")]
        private IWebElement _verticalListContainer;

        private IList<IWebElement> _listItems => this._verticalListContainer.FindElements(By.TagName("li"));

        [CacheLookup, FindsBy(How = How.Id, Using = "demo-tab-grid")]
        private IWebElement _gridTab;

        [CacheLookup, FindsBy(How = How.XPath, Using = "//div[@id='gridContainer']//li")]
        private IList<IWebElement> _testBoxes;

        protected override string Url => "http://demoqa.com/selectable";
    }
}