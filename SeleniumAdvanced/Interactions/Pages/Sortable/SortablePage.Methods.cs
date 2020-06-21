namespace SeleniumAdvanced.Interactions.Pages.Sortable
{
    public partial class SortablePage
    {
        public SortablePage GoToGridTab()
        {
            this._gridTabLink.Click();
            return this;
        }
    }
}