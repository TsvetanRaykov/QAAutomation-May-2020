using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Interactions.Pages.Sortable
{
    public partial class SortablePage
    {
        [CacheLookup, FindsBy(How = How.XPath, Using = "//div[@id='demo-tabpane-list']//div[contains(@class,'list-group-item-action')]")]
        private IList<IWebElement> _sortableListItems;

        [CacheLookup, FindsBy(How = How.XPath, Using = "//div[@id='demo-tabpane-grid']//div[contains(@class,'list-group-item-action')]")]
        private IList<IWebElement> _sortableGridItems;

        [CacheLookup, FindsBy(How = How.Id, Using = "demo-tab-grid")]
        private IWebElement _gridTabLink;
    }
}