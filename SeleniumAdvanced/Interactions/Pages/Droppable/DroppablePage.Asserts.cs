namespace SeleniumAdvanced.Interactions.Pages.Droppable
{
    using NUnit.Framework;

    public partial class DroppablePage : DemoQa
    {

        public void AssertThatDraggableBoxCanBeDroppedInsideDroppableBox()
        {
            this.Builder
                .DragAndDrop(this.DraggableBox.ScrollTo().NativeElement, this.DroppableBox.NativeElement)
                .Perform();

            Assert.AreEqual("Dropped!", this.DroppableBox.Text);
        }

        public void AssertThatAcceptableBoxChangeTargetBoxColorWhenDroppedIn()
        {
            var colorBefore = this.AcceptContainer.GetCssValue("background-color");

            this.Builder
                .DragAndDrop(this.AcceptableBox.NativeElement, this.AcceptDroppableBox.NativeElement)
                .Perform();

            var colorAfter = this.AcceptContainer.GetCssValue("background-color");

            Assert.AreNotEqual(colorBefore, colorAfter);
        }

        public void AssertThatNotAcceptableBoxNotChangeTargetColorWhenDroppedIn()
        {
            var colorBefore = this.AcceptContainer.GetCssValue("background-color");

            this.Builder
                .MoveToElement(this.NotAcceptableBox.NativeElement)
                .DragAndDropToOffset(this.NotAcceptableBox.NativeElement, 300, 0)
                .MoveByOffset(300, 0)
                .Perform();

            var colorAfter = this.AcceptContainer.GetCssValue("background-color");

            Assert.AreEqual(colorBefore, colorAfter);
        }

    }
}