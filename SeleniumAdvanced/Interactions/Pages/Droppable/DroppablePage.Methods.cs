namespace SeleniumAdvanced.Interactions.Pages.Droppable
{
    public partial class DroppablePage
    {
        public DroppablePage GoToAcceptSection()
        {
            this._droppableAcceptSectionLink.Click();
            return this;
        }
    }
}