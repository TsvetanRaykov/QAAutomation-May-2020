using System.Drawing;
using NUnit.Framework;
using TestUtils.Extensions;

namespace SeleniumAdvanced.Interactions.Pages.Resizable
{
    public partial class ResizablePage : DemoQa
    {
      
        public void AssertThatRestrictedBoxMaximumSizeIs500X300()
        {
            var expectedSize = new Size(500, 300);

            this.Builder
                .DragAndDropToOffset(this.Driver.ScrollTo(this._resizableRestrictedBoxHandler),
                    400,
                    200)
                .Perform();

            Assert.AreEqual(expectedSize, this._resizableRestrictedBox.Size);
        }

        public void AssertThatRestrictedBoxMinimumSizeIs150X150()
        {
            var expectedSize = new Size(150, 150);

            this.Builder
                .DragAndDropToOffset(this._resizableRestrictedBoxHandler,
                    -100,
                    -100)
                .Perform();

            Assert.AreEqual(expectedSize, this._resizableRestrictedBox.Size);
        }

        public void AssertThatResizableBoxCanBeResized()
        {
            var expectedSize = this._resizableBox.Size;

            this.Builder
                .DragAndDropToOffset(this.Driver.ScrollTo(this._resizableBoxHandler), 200, 200)
                .Perform();

            Assert.AreNotEqual(expectedSize, this._resizableBox.Size);
        }

    }
}