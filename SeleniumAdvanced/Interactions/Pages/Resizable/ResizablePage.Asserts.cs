namespace SeleniumAdvanced.Interactions.Pages.Resizable
{
    using System.Drawing;
    using NUnit.Framework;

    public partial class ResizablePage : DemoQa
    {
      
        public void AssertThatRestrictedBoxMaximumSizeIs500X300()
        {
            var expectedSize = new Size(500, 300);

            this.Builder
                .DragAndDropToOffset(this.ResizableRestrictedBoxHandler.ScrollTo().NativeElement,
                    400,
                    200)
                .Perform();

            Assert.AreEqual(expectedSize, this.ResizableRestrictedBox.Size);
        }

        public void AssertThatRestrictedBoxMinimumSizeIs150X150()
        {
            var expectedSize = new Size(150, 150);

            this.Builder
                .DragAndDropToOffset(this.ResizableRestrictedBoxHandler.NativeElement,
                    -100,
                    -100)
                .Perform();

            Assert.AreEqual(expectedSize, this.ResizableRestrictedBox.Size);
        }

        public void AssertThatResizableBoxCanBeResized()
        {
            var expectedSize = this.ResizableBox.Size;

            this.Builder
                .DragAndDropToOffset(this.ResizableBoxHandler.ScrollTo().NativeElement, 200, 200)
                .Perform();

            Assert.AreNotEqual(expectedSize, this.ResizableBox.Size);
        }

    }
}