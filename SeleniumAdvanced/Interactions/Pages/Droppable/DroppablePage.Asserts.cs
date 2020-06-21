using NUnit.Framework;
using TestUtils.Extensions;

namespace SeleniumAdvanced.Interactions.Pages.Droppable
{
    public partial class DroppablePage : DemoQa
    {
   
        public void AssertThatDraggableBoxCanBeDroppedInsideDroppableBox()
        {
            this.Builder
                .DragAndDrop(this.Driver.ScrollTo(this._draggableBox), this._droppableBox)
                .Perform();

            Assert.AreEqual("Dropped!", this._droppableBox.Text);
        }

        public void AssertThatAcceptableBoxChangeTargetBoxColorWhenDroppedIn()
        {
            var colorBefore = this._acceptContainer.GetCssValue("background-color");

            this.Builder
                .DragAndDrop(this._acceptableBox, this._acceptDroppableBox)
                .Perform();

            var colorAfter = this._acceptContainer.GetCssValue("background-color");

            Assert.AreNotEqual(colorBefore, colorAfter);
        }

        public void AssertThatNotAcceptableBoxNotChangeTargetColorWhenDroppedIn()
        {
            var colorBefore = this._acceptContainer.GetCssValue("background-color");

            this.Builder
                .MoveToElement(this._notAcceptableBox)
                .DragAndDropToOffset(this._notAcceptableBox, 300, 0)
                .MoveByOffset(300, 0)
                .Perform();

            var colorAfter = this._acceptContainer.GetCssValue("background-color");

            Assert.AreEqual(colorBefore, colorAfter);
        }

    }
}