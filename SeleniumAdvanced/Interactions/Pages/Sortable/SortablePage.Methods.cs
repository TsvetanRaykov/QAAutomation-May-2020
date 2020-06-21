namespace SeleniumAdvanced.Interactions.Pages.Sortable
{
    public partial class SortablePage
    {
        public SortablePage GoToGridTab()
        {
            this.GridTabLink.Click();
            return this;
        }
    }
}