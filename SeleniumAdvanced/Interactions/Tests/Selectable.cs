using NUnit.Framework;
using SeleniumAdvanced.Interactions.Pages.Selectable;

namespace SeleniumAdvanced.Interactions.Tests
{
    [TestFixture]
    public class Selectable : BaseTest
    {

        private SelectablePage _sut;

        [SetUp]
        public void Setup()
        {
            this.Initialize();
            this._sut = new SelectablePage(this.Driver);
        }

        [Test]
        public void SelectedItemMustHaveCorrectClass()
        {
            this._sut.AssertThatSelectedItemHaveCorrectClass();
        }

        [Test]
        public void SelectedItemMustHaveDifferentColor()
        {
            this._sut
                .GoToGridTab()
                .AssertThatSelectedItemMustDifferentColor();
        }
    }
}