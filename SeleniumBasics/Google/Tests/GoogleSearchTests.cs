using NUnit.Framework;
using SeleniumBasics.Google.Pages;

namespace SeleniumBasics.Google.Tests
{
    [TestFixture]
    public class GoogleSearchTests : BaseTest
    {
        [Test]
        public void FirstGoogleSearchResultForSeleniumHasCorrectPageTitle()
        {
            var run = new GooglePage(this.Driver);

            var firstResultTitle = run
                .GoToGoogle()
                .Search("selenium")
                .GoToFirstResult()
                .GetPageTitle();

            Assert.AreEqual("SeleniumHQ Browser Automation", firstResultTitle);
        }
    }
}