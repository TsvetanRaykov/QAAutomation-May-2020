namespace SeleniumAdvanced.Interactions.Pages.Draggable
{
    public partial class DraggablePage
    {
        public DraggablePage GoToAxisRestrictionSection()
        {
            this._axisRestrictionLink.Click();
            return this;
        }
        public DraggablePage GoToContainerRestrictionSection()
        {
            this._containerRestrictionLink.Click();
            return this;
        }
    }
}