namespace SeleniumAdvanced.Interactions.Pages
{
    public partial class DemoQa
    {
        private DemoQa NavigateToSection(string sectionName)
        {
            this.InteractionsLink
                .ScrollTo()
                .Click();

            this.TargetSectionLink(sectionName)
                .ScrollTo()
                .Click();

            return this;
        }
    }
}