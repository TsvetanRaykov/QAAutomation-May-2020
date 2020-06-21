using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using OpenQA.Selenium.Support.Extensions;

namespace TestUtils.Extensions
{
    public static class DriverExtensions
    {
        public static IWebDriver PageReady(this IWebDriver driver)
        {
            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            wait.Until(d =>
                ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));

            return driver;
        }

        public static IWebElement ScrollTo(this IWebDriver driver, IWebElement element)
        {
            driver.ExecuteJavaScript("arguments[0].scrollIntoView(true)", element);
            return element;
        }

        public static void ScrollToTop(this IWebDriver driver)
        {
            driver.ExecuteJavaScript("window.scrollTo(0, 0)");
        }

        public static IWebElement SetFormInputValue(this IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
            return element;
        }

        public static void MakeScreenShot(this IWebDriver driver, string directory, string imageName)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            var imagePath = Path.Combine(directory, $"{imageName}.png");

            driver.TakeScreenshot()
                .SaveAsFile(imagePath, ScreenshotImageFormat.Png);
        }

    }
}
