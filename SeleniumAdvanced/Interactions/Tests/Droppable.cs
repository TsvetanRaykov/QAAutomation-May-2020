namespace SeleniumAdvanced.Interactions.Tests
{
    using NUnit.Framework;
    using SeleniumAdvanced.Interactions.Pages.Droppable;

    [TestFixture]
    public class Droppable : BaseTest
    {
        private DroppablePage _sut;

        [SetUp]
        public void Setup()
        {
            this.Initialize();
            this._sut = new DroppablePage(this.Driver);
        }

        [Test]
        public void AcceptableBoxMustChangeTargetBoxColorWhenDroppedIn()
        {
            this._sut
                .GoToAcceptSection()
                .AssertThatAcceptableBoxChangeTargetBoxColorWhenDroppedIn();
        }

        [Test]
        public void DraggableBoxCanBeDroppedInsideDroppableBox()
        {
            this._sut.AssertThatDraggableBoxCanBeDroppedInsideDroppableBox();
        }
        [Test]
        public void NotAcceptableBoxMustNotChangeTargetColorWhenDroppedIn()
        {
            this._sut
                .GoToAcceptSection()
                .AssertThatNotAcceptableBoxNotChangeTargetColorWhenDroppedIn();
        }

    }
}
