using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Interactions.Pages.Draggable
{
    public partial class DraggablePage
    {
        public DraggablePage(IWebDriver driver) : base(driver) { }

        [CacheLookup, FindsBy(How = How.Id, Using = "draggableExample-tab-axisRestriction")]
        private IWebElement _axisRestrictionLink;

        [CacheLookup, FindsBy(How = How.Id, Using = "draggableExample-tab-containerRestriction")]
        private IWebElement _containerRestrictionLink;

        [CacheLookup, FindsBy(How = How.Id, Using = "restrictedX")]
        private IWebElement _restrictedXBox;

        [CacheLookup, FindsBy(How = How.Id, Using = "restrictedY")]
        private IWebElement _restrictedYBox;

        [CacheLookup, FindsBy(How = How.Id, Using = "containmentWrapper")]
        private IWebElement _containmentWrapperBox;

        private IWebElement _containerWithinTheBox => this._containmentWrapperBox.FindElement(By.TagName("div"));
        
        protected override string Url => "http://demoqa.com/dragabble";
    }
}