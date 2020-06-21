using System;
using System.IO;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestUtils.Extensions;

namespace SeleniumAdvanced.Interactions
{
    [TestFixture]
    public abstract class BaseTest
    {
        private static string ScreenShotFolder => Path.GetFullPath(@"..\..\..\Screenshots", Environment.CurrentDirectory);
        protected IWebDriver Driver { get; private set; }

        protected void Initialize()
        {
            var options = new ChromeOptions();
            options.AddArgument("-headless");
            options.AddArgument("window-size=1920x1080");

            this.Driver = new ChromeDriver(Environment.CurrentDirectory, options);
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