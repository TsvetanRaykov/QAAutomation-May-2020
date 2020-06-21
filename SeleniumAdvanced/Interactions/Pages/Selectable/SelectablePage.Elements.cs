namespace SeleniumAdvanced.Interactions.Pages.Selectable
{
    using System.Collections.Generic;
    using OpenQA.Selenium;
    using TestUtils.Decorators;

    public partial class SelectablePage
    {
        public SelectablePage(WebDriver driver) : base(driver) { }

        private Element VerticalListContainer => this.Driver.FindElement(By.Id("verticalListContainer"));

        private IEnumerable<Element> ListItems => this.VerticalListContainer.FindElements(By.TagName("li"));

        private Element GridTab => this.Driver.FindElement(By.Id("demo-tab-grid"));

        private List<Element> TestBoxes => this.Driver.FindElements(By.XPath("//div[@id='gridContainer']//li")) ;

        protected override string Url => "http://demoqa.com/selectable";
    }
}