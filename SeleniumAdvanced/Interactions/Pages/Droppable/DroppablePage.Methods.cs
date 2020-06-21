namespace SeleniumAdvanced.Interactions.Pages.Droppable
{
    public partial class DroppablePage
    {
        public DroppablePage GoToAcceptSection()
        {
            this.DroppableAcceptSectionLink.Click();
            return this;
        }
    }
}