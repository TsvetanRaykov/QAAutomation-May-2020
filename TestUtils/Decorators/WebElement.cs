namespace TestUtils.Decorators
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using OpenQA.Selenium;
    using OpenQA.Selenium.Support.Extensions;
    using OpenQA.Selenium.Support.UI;

    public class WebElement : Element
    {
        private readonly IWebDriver _webDriver;
        private readonly WebDriverWait _webDriverWait;

        public override IWebElement NativeElement { get; }

        public override Element FindElement(By by)
        {
            var element = this.NativeElement.FindElement(by);
            return new WebElement(this._webDriver, element, by);
        }

        public override IEnumerable<Element> FindElements(By @by)
        {
            var nativeWebElements = this.NativeElement.FindElements(@by);

            return nativeWebElements
                .Select(nativeWebElement => new WebElement(this._webDriver, nativeWebElement, @by))
                .Cast<Element>()
                .ToList();
        }

        public override void Submit() => this.NativeElement.Submit();

        public WebElement(IWebDriver webDriver, IWebElement webElement, By by)
        {
            this._webDriver = webDriver;
            this.NativeElement = webElement;
            this.By = by;
            this._webDriverWait = new WebDriverWait(this._webDriver, TimeSpan.FromSeconds(30));
        }

        public override By By { get; }

        public override string Text => this.NativeElement?.Text;

        public override bool? Enabled => this.NativeElement?.Enabled;

        public override bool? Displayed => this.NativeElement?.Displayed;

        public override void Click()
        {
            this.WaitToBeClickable(this.By)?
                .Click();
        }

        public override string GetCssValue(string propertyName) => this.NativeElement.GetCssValue(propertyName);

        public override string GetAttribute(string attributeName) => this.NativeElement?.GetAttribute(attributeName);

        public override Size Size => this.NativeElement.Size;

        public override Point Location => this.NativeElement.Location;

        public override void TypeText(string text)
        {
            this.NativeElement?.Clear();
            this.NativeElement?.SendKeys(text);
        }

        public Element ScrollTo()
        {
            this._webDriver.ExecuteJavaScript("arguments[0].scrollIntoView(true)", this.NativeElement);
            return this;
        }

        private IWebElement WaitToBeClickable(By by) => 
            this._webDriverWait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(@by));
    }
}
