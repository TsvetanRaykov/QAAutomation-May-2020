namespace SeleniumAdvanced.Interactions.Pages
{
    using OpenQA.Selenium;
    using TestUtils.Decorators;

    public partial class DemoQa : BasePage
    {
        public DemoQa(WebDriver driver) : base(driver) { }

        private WebElement InteractionsLink => 
            this.Driver.FindElement(By.XPath("//*/h5[normalize-space(text())='Interactions']")) as WebElement;

        private WebElement TargetSectionLink(string sectionName) => 
            this.Driver.FindElement(By.XPath($"//ul//li//span[normalize-space(text())='{sectionName}']")) as WebElement;

        private Element SectionHeader => 
            this.Driver.FindElement(By.XPath("//div[@class='main-header']"));

        protected override string Url => "http://demoqa.com";
    }
}