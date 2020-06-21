using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Interactions.Pages
{
    public partial class DemoQa : BasePage
    {
        public DemoQa(IWebDriver driver) : base(driver) { }

        [CacheLookup, FindsBy(How = How.XPath, Using = "//*/h5[normalize-space(text())='Interactions']")]
        private IWebElement _interactionsLink;

        private IWebElement _targetSectionLink(string sectionName) => this.Driver.FindElement(By.XPath($"//ul//li//span[normalize-space(text())='{sectionName}']"));

        [CacheLookup, FindsBy(How = How.XPath, Using = "//div[@class='main-header']")]
        private IWebElement _sectionHeader;

        protected override string Url => "http://demoqa.com";
    }
}