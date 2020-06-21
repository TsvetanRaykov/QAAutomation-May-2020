using System;
using System.IO;
using AutoFixture;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestUtils.Extensions;

namespace SeleniumAdvanced.AutomationPracticeRegistrationNegativeTests
{
    [TestFixture]
    public class BaseTest
    {
        private static string ScreenShotFolder => Path.GetFullPath(@"..\..\..\Screenshots", Environment.CurrentDirectory);
       
        protected IWebDriver Driver;
        protected IFixture Fixture;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            var options = new ChromeOptions();
            options.AddArgument("-headless");
            options.AddArgument("window-size=1920x1080");
            options.AddArgument("start-maximized");

            this.Driver = new ChromeDriver(Environment.CurrentDirectory, options);
           
            this.Fixture = new Fixture();
        }

        [OneTimeTearDown]
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