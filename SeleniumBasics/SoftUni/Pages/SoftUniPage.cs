using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumBasics.SoftUni.Pages
{
    public class SoftUniPage : BasePage
    {
        private const string Url = "https://softuni.bg";

        public SoftUniPage(IWebDriver driver) : base(driver) { }

        [FindsBy(How = How.XPath, Using = "//span[@class='cell']//following::span")]
        private IWebElement _trainingsMenuItem;

        [CacheLookup, FindsBy(How = How.XPath, Using = "//div[@class='box-content']/h4[normalize-space(text())='QA Automation']")]
        private IWebElement _courseMenuItem;

        [CacheLookup, FindsBy(How = How.XPath, Using = "//div[contains(@class,'open-courses-wrapper')]//div[contains(@class,'category-title')][normalize-space(text())='Active modules']")]
        private IWebElement _activeModuleSection;

        [CacheLookup, FindsBy(How = How.XPath, Using = "//div[contains(@class,'open-courses-wrapper')]//a[starts-with(text(),'Quality Assurance')]")]
        private IWebElement _moduleMenuItem;

        [CacheLookup, FindsBy(How = How.XPath, Using = "//ul[@class='lang']//a[normalize-space(text())='English']")]
        private IWebElement _langSwitch;

        public SoftUniPage GoToSoftUni()
        {
            this.Driver.Navigate().GoToUrl(Url);
            this.Driver.Manage().Window.Maximize();
            return this.SwitchedToEnglish();
        }

        private SoftUniPage SwitchedToEnglish()
        {
            if (this._trainingsMenuItem.Text.ToLowerInvariant() != "trainings")
            {
                this._langSwitch.Click();
            }
            return this;
        }

        public QaCoursePage OpenCoursePage()
        {
            this._trainingsMenuItem.Click();
            this._activeModuleSection.Click();
            this._moduleMenuItem.Click();
            this._courseMenuItem.Click();

            return new QaCoursePage(this.Driver);
        }
    }
}