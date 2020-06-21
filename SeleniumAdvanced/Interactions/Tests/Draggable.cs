using NUnit.Framework;
using SeleniumAdvanced.Interactions.Pages.Draggable;

namespace SeleniumAdvanced.Interactions.Tests
{
    [TestFixture]
    public class Draggable : BaseTest
    {
        private DraggablePage _sut;

        [SetUp]
        public void Setup()
        {
            this.Initialize();
            this._sut = new DraggablePage(this.Driver);
        }

        [Test]
        public void ContainerRestrictedBoxMustNotMoveOutsideOfTheBoundaries()
        {
            this._sut
                .GoToContainerRestrictionSection()
                .AssertThatContainerRestrictedBoxNotMoveOutsideOfTheBoundaries();
        }

        [Test]
        public void AssertThatXBoundedBoxMustNotMoveOnY()
        {
            this._sut
                .GoToAxisRestrictionSection()
                .AssertThatXBoundedBoxNotMoveOnY();
        }
        [Test]
        public void YBoundedBoxMustNotMoveOnX()
        {
            this._sut
                .GoToAxisRestrictionSection()
                .AssertThatYBoundedBoxNotMoveOnX();
        }

    }
}