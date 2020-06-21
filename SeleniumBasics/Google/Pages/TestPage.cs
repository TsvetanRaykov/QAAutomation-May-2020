using OpenQA.Selenium;
using TestUtils.Extensions;

namespace SeleniumBasics.Google.Pages
{
    public class TestPage : BasePage
    {
        public TestPage(IWebDriver driver) : base(driver) { }

        public string GetPageTitle()
        {
            return this.Driver.PageReady().Title;
        }
    }
}