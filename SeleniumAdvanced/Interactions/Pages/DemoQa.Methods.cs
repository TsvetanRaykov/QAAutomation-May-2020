using TestUtils.Extensions;

namespace SeleniumAdvanced.Interactions.Pages
{
    public partial class DemoQa
    {
        private DemoQa NavigateToSection(string sectionName)
        {
            this.Driver
                .ScrollTo(this._interactionsLink)
                .Click();

            this.Driver
                .ScrollTo(this._targetSectionLink(sectionName))
                .Click();

            return this;
        }
    }
}