namespace SeleniumAdvanced.Interactions.Tests
{
    using NUnit.Framework;
    using SeleniumAdvanced.Interactions.Pages.Resizable;

    [TestFixture]
    public class Resizable : BaseTest
    {
        private ResizablePage _sut;

        [SetUp]
        public void Setup()
        {
            this.Initialize();
            this._sut = new ResizablePage(this.Driver);
        }

        [Test]
        public void RestrictedBoxMaximumSizeIs500X300()
        {
            this._sut.AssertThatRestrictedBoxMaximumSizeIs500X300();
        }

        [Test]
        public void RestrictedBoxMinimumSizeIs150X150()
        {
            this._sut.AssertThatRestrictedBoxMinimumSizeIs150X150();
        }

        [Test]
        public void ResizableBoxCanBeResized()
        {
            this._sut.AssertThatResizableBoxCanBeResized();
        }

    }
}