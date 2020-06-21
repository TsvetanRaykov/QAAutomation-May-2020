using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace SeleniumAdvanced.Interactions
{
    public abstract class BasePage
    {
        protected abstract string Url { get; }

        protected BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Builder = new Actions(this.Driver);
            this.Navigate();
        }

        protected IWebDriver Driver { get; }
        protected Actions Builder { get; }

        private void Navigate()
        {
            this.Driver.Navigate().GoToUrl(this.Url);
            PageFactory.InitElements(this.Driver, this);
        }

    }
}