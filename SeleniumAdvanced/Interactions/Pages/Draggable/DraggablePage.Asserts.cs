using System.Drawing;
using NUnit.Framework;
using TestUtils.Extensions;

namespace SeleniumAdvanced.Interactions.Pages.Draggable
{
    public partial class DraggablePage : DemoQa
    {
   
        public void AssertThatXBoundedBoxNotMoveOnY()
        {
            var yLocationBefore = this._restrictedXBox.Location.Y;

            this.Builder
                .ClickAndHold(this._restrictedXBox)
                .MoveByOffset(100, 200)
                .Release()
                .Perform();

            Assert.AreEqual(yLocationBefore, this._restrictedXBox.Location.Y);
        }

        public void AssertThatYBoundedBoxNotMoveOnX()
        {
            var xLocationBefore = this._restrictedYBox.Location.X;

            this.Builder
                .ClickAndHold(this._restrictedYBox)
                .MoveByOffset(200, 200)
                .Release()
                .Perform();

            Assert.AreEqual(xLocationBefore, this._restrictedYBox.Location.X);
        }

        public void AssertThatContainerRestrictedBoxNotMoveOutsideOfTheBoundaries()
        {
            var restrictionField = new Rectangle(this._containmentWrapperBox.Location, this._containmentWrapperBox.Size);

            this.Builder
                .ClickAndHold(this.Driver.ScrollTo(this._containerWithinTheBox))
                .MoveByOffset(500, 500)
                .Release()
                .Perform();

            Assert.IsTrue(restrictionField.Contains(this._containerWithinTheBox.Location));
        }

    }
}