namespace SeleniumBasics
{
    using System;
    using System.IO;
    using NUnit.Framework;
    using NUnit.Framework.Interfaces;
    using OpenQA.Selenium.Chrome;
    using TestUtils.Decorators;

    [TestFixture]
    public class BaseTest
    {
        private static string ScreenShotFolder => Path.GetFullPath(@"..\..\..\Screenshots", Environment.CurrentDirectory);

        protected WebDriver Driver;

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArgument("-headless");
            options.AddArgument("window-size=1920x1080");
            options.AddArgument("start-maximized");

            this.Driver = new WebDriver();
            this.Driver.Start(Browser.Chrome, options);
        }


        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                this.Driver.MakeScreenShot(ScreenShotFolder, TestContext.CurrentContext.Test.FullName);
            }
            this.Driver.Quit();
        }
    }
}