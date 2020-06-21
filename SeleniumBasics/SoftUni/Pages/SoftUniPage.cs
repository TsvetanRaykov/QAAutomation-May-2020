namespace SeleniumBasics.SoftUni.Pages
{
    using OpenQA.Selenium;
    using TestUtils.Decorators;

    public class SoftUniPage : BasePage
    {
        private const string Url = "https://softuni.bg";

        public SoftUniPage(WebDriver driver) : base(driver) { }

        private Element TrainingsMenuItem => this.Driver.FindElement(By.XPath("//span[@class='cell']//following::span"));

        private Element CourseMenuItem => this.Driver.FindElement(By.XPath("//div[@class='box-content']/h4[normalize-space(text())='QA Automation']"));

        private Element ActiveModuleSection => this.Driver.FindElement(By.XPath("//div[contains(@class,'open-courses-wrapper')]//div[contains(@class,'category-title')][normalize-space(text())='Active modules']"));

        private Element ModuleMenuItem => this.Driver.FindElement(By.XPath("//div[contains(@class,'open-courses-wrapper')]//a[starts-with(text(),'Quality Assurance')]"));

        private Element LangSwitch => this.Driver.FindElement(By.XPath("//ul[@class='lang']//a[normalize-space(text())='English']"));

        public SoftUniPage GoToSoftUni()
        {
            this.Driver.Navigate(Url);
            return this.SwitchedToEnglish();
        }

        private SoftUniPage SwitchedToEnglish()
        {
            if (this.TrainingsMenuItem.Text.ToLowerInvariant() != "trainings")
            {
                this.LangSwitch.Click();
            }
            return this;
        }

        public QaCoursePage OpenCoursePage()
        {
            this.TrainingsMenuItem.Click();
            this.ActiveModuleSection.Click();
            this.ModuleMenuItem.Click();
            this.CourseMenuItem.Click();

            return new QaCoursePage(this.Driver);
        }
    }
}