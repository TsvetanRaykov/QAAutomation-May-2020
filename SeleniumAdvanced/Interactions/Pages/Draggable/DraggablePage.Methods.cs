namespace SeleniumAdvanced.Interactions.Pages.Draggable
{
    public partial class DraggablePage
    {
        public DraggablePage GoToAxisRestrictionSection()
        {
            this.AxisRestrictionLink.Click();
            return this;
        }
        public DraggablePage GoToContainerRestrictionSection()
        {
            this.ContainerRestrictionLink.Click();
            return this;
        }
    }
}