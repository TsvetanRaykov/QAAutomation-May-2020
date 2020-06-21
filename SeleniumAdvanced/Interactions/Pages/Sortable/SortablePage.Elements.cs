namespace SeleniumAdvanced.Interactions.Pages.Sortable
{
    using System.Collections.Generic;
    using OpenQA.Selenium;
    using TestUtils.Decorators;

    public partial class SortablePage
    {
        private List<Element> SortableListItems =>
            this.Driver.FindElements(
                By.XPath("//div[@id='demo-tabpane-list']//div[contains(@class,'list-group-item-action')]"));

        private List<Element> SortableGridItems => this.Driver.FindElements(
            By.XPath("//div[@id='demo-tabpane-grid']//div[contains(@class,'list-group-item-action')]"));


        private Element GridTabLink => this.Driver.FindElement(By.Id("demo-tab-grid"));
    }
}