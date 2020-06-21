namespace SeleniumAdvanced.Interactions.Tests
{
    using NUnit.Framework;
    using SeleniumAdvanced.Interactions.Pages.Sortable;

    [TestFixture]
    public class Sortable : BaseTest
    {

        private SortablePage _sut;

        [SetUp]
        public void Setup()
        {
            this.Initialize();
            this._sut = new SortablePage(this.Driver);
        }

        [Test]
        public void GridItemsMustBeAlignedAfterSort()
        {
            this._sut
                .GoToGridTab()
                .AssertThatGridItemsMustBeAlignedAfterSort();
        }

        [Test]
        public void MovedListItemMustHaveCorrectPosition()
        {
            this._sut.AssertThatMovedListItemMustHaveCorrectPosition();
        }
    }
}