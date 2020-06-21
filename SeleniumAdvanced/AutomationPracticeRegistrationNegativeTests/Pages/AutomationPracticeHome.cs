using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.AutomationPracticeRegistrationNegativeTests.Pages
{
    public class AutomationPracticeHome : BasePage
    {
        private const string Url = "http://automationpractice.com/index.php";

        public AutomationPracticeHome(IWebDriver driver) : base(driver) { }

        public AutomationPracticeRegisterEmail GoToEmailForm()
        {
            this.Driver.Navigate().GoToUrl(Url);
            this._signInItem.Click();
            return new AutomationPracticeRegisterEmail(this.Driver);
        }

        [CacheLookup, FindsBy(How = How.XPath, Using = "//a[@class='login']")]
        private readonly IWebElement _signInItem;


    }
}