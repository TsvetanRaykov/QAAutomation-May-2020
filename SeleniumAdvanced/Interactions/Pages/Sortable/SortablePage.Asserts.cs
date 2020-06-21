using System.Drawing;
using System.Linq;
using AutoFixture;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using TestUtils.Extensions;

namespace SeleniumAdvanced.Interactions.Pages.Sortable
{
    public partial class SortablePage : DemoQa
    {
        public SortablePage(IWebDriver driver) : base(driver) { }

        public void AssertThatMovedListItemMustHaveCorrectPosition()
        {
            var itemText = this._sortableListItems[0].Text;

            foreach (var sortableItem in this._sortableListItems)
            {
                new Actions(this.Driver)
                    .DragAndDropToOffset(sortableItem, 0, 50)
                    .Perform();
            }

            PageFactory.InitElements(this.Driver, this);
            var actual = this._sortableListItems[^1].Text;

            Assert.AreEqual(itemText, actual);
        }


        public void AssertThatGridItemsMustBeAlignedAfterSort()
        {
            // Shuffle
            var fixture = new Fixture();
            PageFactory.InitElements(this.Driver, this);
            foreach (var sortableItem in this._sortableGridItems)
            {
                new Actions(this.Driver)
                    .DragAndDropToOffset(this.Driver.ScrollTo(sortableItem), fixture.CreateInt(0, 500), fixture.CreateInt(0, 500))
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
                    row[j] = this._sortableGridItems[l++].Location;
                    col[j] = this._sortableGridItems[i + m].Location;
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