using NUnit.Framework;
using SeleniumBasics.SoftUni.Pages;

namespace SeleniumBasics.SoftUni.Tests
{
    public class Tests : BaseTest
    {

        [Test]
        public void QaAutomationCoursePageContainsCorrectHeading()
        {
            var run = new SoftUniPage(this.Driver);

            var headings = run
                .GoToSoftUni()
                .OpenCoursePage()
                .GetHeadings();

            Assert.Contains("QA Automation - May 2020", headings);
        }

    }
}