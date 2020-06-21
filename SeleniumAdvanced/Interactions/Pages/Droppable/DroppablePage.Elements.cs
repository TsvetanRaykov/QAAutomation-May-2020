namespace SeleniumAdvanced.Interactions.Pages.Droppable
{
    using OpenQA.Selenium;
    using TestUtils.Decorators;

    public partial class DroppablePage
    {
        public DroppablePage(WebDriver driver) : base(driver) { }

        private WebElement DraggableBox => this.Driver.FindElement(By.Id("draggable")) as WebElement;

        private Element DroppableBox => this.Driver.FindElement(By.Id("droppable"));

        private Element AcceptDroppableBox => this.Driver.FindElement(By.XPath("//div[@id='acceptDropContainer']/div/following::div"));

        private Element DroppableAcceptSectionLink => this.Driver.FindElement(By.Id("droppableExample-tab-accept"));

        private Element AcceptContainer => this.Driver.FindElement(By.XPath("//div[@id='acceptDropContainer']//*[@id='droppable']"));

        private Element AcceptableBox => this.Driver.FindElement(By.Id("acceptable"));

        private Element NotAcceptableBox => this.Driver.FindElement(By.Id("notAcceptable"));

        protected override string Url => "http://demoqa.com/droppable";
    }
}