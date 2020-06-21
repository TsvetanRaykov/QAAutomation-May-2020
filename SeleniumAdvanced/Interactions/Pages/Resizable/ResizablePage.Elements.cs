namespace SeleniumAdvanced.Interactions.Pages.Resizable
{
    using OpenQA.Selenium;
    using TestUtils.Decorators;

    public partial class ResizablePage
    {
        public ResizablePage(WebDriver driver) : base(driver) { }

        private Element ResizableRestrictedBox => this.Driver.FindElement(By.Id("resizableBoxWithRestriction"));

        private WebElement ResizableRestrictedBoxHandler =>
            this.ResizableRestrictedBox.FindElement(By.XPath("span")) as WebElement;

        private Element ResizableBox => this.Driver.FindElement(By.Id("resizable"));

        private WebElement ResizableBoxHandler =>
            this.ResizableBox.FindElement(By.XPath("span")) as WebElement;

        protected override string Url => "http://demoqa.com/resizable";

    }
}