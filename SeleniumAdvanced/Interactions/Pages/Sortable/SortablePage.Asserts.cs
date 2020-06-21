namespace SeleniumAdvanced.Interactions.Pages.Sortable
{
    using System.Drawing;
    using System.Linq;
    using AutoFixture;
    using NUnit.Framework;
    using OpenQA.Selenium.Interactions;
    using TestUtils.Decorators;
    using TestUtils.Extensions;

    public partial class SortablePage : DemoQa
    {
        public SortablePage(WebDriver driver) : base(driver) { }

        public void AssertThatMovedListItemMustHaveCorrectPosition()
        {
            var itemText = this.SortableListItems[0].Text;

            foreach (var element in this.SortableListItems)
            {
                var sortableItem = (WebElement)element;
                new Actions(this.Driver.WrappedDriver)
                    .DragAndDropToOffset(sortableItem.NativeElement, 0, 50)
                    .Perform();
            }

            var actual = this.SortableListItems[^1].Text;

            Assert.AreEqual(itemText, actual);
        }


        public void AssertThatGridItemsMustBeAlignedAfterSort()
        {
            // Shuffle
            var fixture = new Fixture();
            foreach (var element in this.SortableGridItems)
            {
                var sortableItem = (WebElement)element;
                new Actions(this.Driver.WrappedDriver)
                    .DragAndDropToOffset(sortableItem.ScrollTo().NativeElement, fixture.CreateInt(0, 500), fixture.CreateInt(0, 500))
                    .Perform();
            }

            var rows = new Point[3][];
            var cols = new Point[3][];

            for (int i = 0, l = 0; i < 3; i++)
            {
                var row = new Point[3];
                var col = new Point[3];

                for (int j = 0, m = 0; j < 3; j++, m += 3)
                {
                    row[j] = this.SortableGridItems[l++].Location;
                    col[j] = this.SortableGridItems[i + m].Location;
                }

                rows[i] = row;
                cols[i] = col;
            }

            Assert.True(rows.All(row =>
            {
                var validY = row[0].Y;
                return row.All(box => box.Y.Equals(validY));
            }));

            Assert.True(cols.All(col =>
            {
                var validX = col[0].X;
                return col.All(box => box.X.Equals(validX));
            }));
        }

        protected override string Url => "http://demoqa.com/sortable";
    }
}