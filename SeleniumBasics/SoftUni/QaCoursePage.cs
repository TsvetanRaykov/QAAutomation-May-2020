namespace SeleniumBasics.SoftUni
{
    using System.Collections.Generic;
    using System.Linq;
    using OpenQA.Selenium;
    using TestUtils.Decorators;

    public class QaCoursePage : BasePage
    {
        public QaCoursePage(WebDriver driver) : base(driver) { }

        private IEnumerable<Element> Headings => this.Driver.FindElements(By.TagName("h1"));
        
        public string[] GetHeadings()
        {
            return this.Headings?
                .Select(a => a.Text)
                .ToArray() ?? new string[0];
        }

    }
}