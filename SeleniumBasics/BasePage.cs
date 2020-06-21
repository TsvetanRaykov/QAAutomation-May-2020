using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumBasics
{
    public class BasePage
    {
        protected readonly IWebDriver Driver;

        protected BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(this.Driver, this);
        }
    }
}