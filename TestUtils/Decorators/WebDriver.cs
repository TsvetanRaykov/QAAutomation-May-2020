namespace TestUtils.Decorators
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Chrome;
    using OpenQA.Selenium.Edge;
    using OpenQA.Selenium.Firefox;
    using OpenQA.Selenium.IE;
    using OpenQA.Selenium.Opera;
    using OpenQA.Selenium.Safari;
    using OpenQA.Selenium.Support.Extensions;
    using OpenQA.Selenium.Support.UI;

    public class WebDriver : Driver
    {
        private WebDriverWait _webDriverWait;

        public IWebDriver WrappedDriver { get; private set; }

        public override void Start(Browser browser, dynamic options = null)
        {
            this.WrappedDriver = browser switch
            {
                Browser.Chrome =>
                new ChromeDriver(Environment.CurrentDirectory, options ?? new ChromeOptions()),
                Browser.Firefox =>
                new FirefoxDriver(Environment.CurrentDirectory, options ?? new FirefoxOptions()),
                Browser.Edge =>
                new EdgeDriver(Environment.CurrentDirectory, options ?? new EdgeOptions()),
                Browser.Opera =>
                new OperaDriver(Environment.CurrentDirectory, options ?? new OperaOptions()),
                Browser.Safari =>
                new SafariDriver(Environment.CurrentDirectory, options ?? new SafariOptions()),
                Browser.InternetExplorer =>
                new InternetExplorerDriver(Environment.CurrentDirectory, options ?? new InternetExplorerOptions()),
                _ => throw new ArgumentOutOfRangeException(nameof(browser), browser, null),
            };
            this._webDriverWait = new WebDriverWait(this.WrappedDriver, TimeSpan.FromSeconds(30));
        }

        public void Navigate(string url)
        {
            WrappedDriver.Navigate().GoToUrl(url);
        }

        public override void Quit()
        {
            this.WrappedDriver.Quit();
        }

        public override void GoToUrl(string url)
        {
            this.WrappedDriver.Navigate().GoToUrl(url);
        }

        public override Element FindElement(By locator)
        {
            var nativeWebElement = this._webDriverWait
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(locator));

            return new WebElement(this.WrappedDriver, nativeWebElement, locator);
        }

        public override List<Element> FindElements(By locator)
        {
            var nativeWebElements = this._webDriverWait
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.PresenceOfAllElementsLocatedBy(locator));

            return nativeWebElements
                .Select(nativeWebElement => new WebElement(this.WrappedDriver, nativeWebElement, locator))
                .Cast<Element>()
                .ToList();
        }

        public void MakeScreenShot(string screenShotFolder, string imageName)
        {
            if (!Directory.Exists(screenShotFolder))
            {
                Directory.CreateDirectory(screenShotFolder);
            }

            var imagePath = Path.Combine(screenShotFolder, $"{imageName}.png");

            this.WrappedDriver.TakeScreenshot()
                .SaveAsFile(imagePath, ScreenshotImageFormat.Png);
        }

        public WebDriver PageReady()
        {
            this._webDriverWait.Until(d =>
                ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

            return this;
        }

    }
}
