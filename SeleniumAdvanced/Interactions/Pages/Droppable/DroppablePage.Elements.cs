using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Interactions.Pages.Droppable
{
    public partial class DroppablePage
    {
        public DroppablePage(IWebDriver driver) : base(driver) { }

        [CacheLookup, FindsBy(How = How.Id, Using = "draggable")]
        private IWebElement _draggableBox;

        [CacheLookup, FindsBy(How = How.Id, Using = "droppable")]
        private IWebElement _droppableBox;

        [CacheLookup, FindsBy(How = How.XPath, Using = "//div[@id='acceptDropContainer']/div/following::div")]
        private IWebElement _acceptDroppableBox;

        [CacheLookup, FindsBy(How = How.Id, Using = "droppableExample-tab-accept")]
        private IWebElement _droppableAcceptSectionLink;

        [CacheLookup, FindsBy(How = How.XPath, Using = "//div[@id='acceptDropContainer']//*[@id='droppable']")]
        private IWebElement _acceptContainer;

        [CacheLookup, FindsBy(How = How.Id, Using = "acceptable")]
        private IWebElement _acceptableBox;

        [CacheLookup, FindsBy(How = How.Id, Using = "notAcceptable")]
        private IWebElement _notAcceptableBox;

        protected override string Url => "http://demoqa.com/droppable";
    }
}