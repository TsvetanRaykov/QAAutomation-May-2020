namespace TestUtils.Decorators
{
    using System.Collections.Generic;
    using OpenQA.Selenium;
    using System.Drawing;

    public abstract class Element 
    {
        public abstract By By { get; }
        public abstract string Text { get; }
        public abstract bool? Enabled { get; }
        public abstract bool? Displayed { get; }
        public abstract void TypeText(string text);
        public abstract void Click();
        public abstract string GetAttribute(string attributeName);
        public abstract Size Size { get; }
        public abstract Point Location { get; }
        public abstract string GetCssValue(string property);
        public abstract IWebElement NativeElement { get; }
        public abstract Element FindElement(By by);
        public abstract IEnumerable<Element> FindElements(By by);
        public abstract void Submit();
    }
}
