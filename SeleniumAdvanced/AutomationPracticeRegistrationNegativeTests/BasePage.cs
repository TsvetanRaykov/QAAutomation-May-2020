using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.AutomationPracticeRegistrationNegativeTests
{
    public abstract class BasePage
    {
        protected readonly IWebDriver Driver;

        protected BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(this.Driver, this);
        }
    }
}