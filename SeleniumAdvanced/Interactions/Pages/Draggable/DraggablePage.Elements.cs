namespace SeleniumAdvanced.Interactions.Pages.Draggable
{
    using OpenQA.Selenium;
    using TestUtils.Decorators;

    public partial class DraggablePage
    {
        public DraggablePage(WebDriver driver) : base(driver) { }

        private Element AxisRestrictionLink => this.Driver.FindElement(By.Id("draggableExample-tab-axisRestriction"));

        private Element ContainerRestrictionLink => this.Driver.FindElement(By.Id("draggableExample-tab-containerRestriction"));

        private Element RestrictedXBox => this.Driver.FindElement(By.Id("restrictedX")) as WebElement;

        private Element RestrictedYBox => this.Driver.FindElement(By.Id("restrictedY")) as WebElement;

        private Element ContainmentWrapperBox => this.Driver.FindElement(By.Id("containmentWrapper")) as WebElement;

        private WebElement ContainerWithinTheBox => this.ContainmentWrapperBox.FindElement(By.TagName("div")) as WebElement ;
        
        protected override string Url => "http://demoqa.com/dragabble";
    }
}