namespace SeleniumAdvanced.Interactions.Pages.Draggable
{
    using System.Drawing;
    using NUnit.Framework;

    public partial class DraggablePage : DemoQa
    {
   
        public void AssertThatXBoundedBoxNotMoveOnY()
        {
            var yLocationBefore = this.RestrictedXBox.Location.Y;

            this.Builder
                .ClickAndHold(this.RestrictedXBox.NativeElement)
                .MoveByOffset(100, 200)
                .Release()
                .Perform();

            Assert.AreEqual(yLocationBefore, this.RestrictedXBox.Location.Y);
        }

        public void AssertThatYBoundedBoxNotMoveOnX()
        {
            var xLocationBefore = this.RestrictedYBox.Location.X;

            this.Builder
                .ClickAndHold(this.RestrictedYBox.NativeElement)
                .MoveByOffset(200, 200)
                .Release()
                .Perform();

            Assert.AreEqual(xLocationBefore, this.RestrictedYBox.Location.X);
        }

        public void AssertThatContainerRestrictedBoxNotMoveOutsideOfTheBoundaries()
        {
            var restrictionField = new Rectangle(this.ContainmentWrapperBox.Location, this.ContainmentWrapperBox.Size);

            this.Builder
                .ClickAndHold(this.ContainerWithinTheBox.ScrollTo().NativeElement)
                .MoveByOffset(500, 500)
                .Release()
                .Perform();

            Assert.IsTrue(restrictionField.Contains(this.ContainerWithinTheBox.Location));
        }

    }
}