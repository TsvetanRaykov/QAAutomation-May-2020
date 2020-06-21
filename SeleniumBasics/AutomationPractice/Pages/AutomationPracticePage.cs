using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumBasics.AutomationPractice.Pages
{
    public class AutomationPracticePage : BasePage
    {
        private const string Url = "http://automationpractice.com/index.php";

        public AutomationPracticePage(IWebDriver driver) : base(driver) { }

        [CacheLookup, FindsBy(How = How.XPath, Using = "//a[@class='login']")]
        private IWebElement _signInItem;

        public AutomationPracticePage GoToAutomationPracticePage()
        {
            this.Driver.Navigate().GoToUrl(Url);
            return this;
        }

        public AutomationPracticeRegisterEmail GoToLoginPage()
        {
            this._signInItem.Click();
            return new AutomationPracticeRegisterEmail(this.Driver);
        }
    }
}