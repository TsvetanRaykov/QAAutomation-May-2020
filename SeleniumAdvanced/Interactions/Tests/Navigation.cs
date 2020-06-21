using NUnit.Framework;
using SeleniumAdvanced.Interactions.Pages;

namespace SeleniumAdvanced.Interactions.Tests
{
    [TestFixture]
    public class Navigation : BaseTest
    {
        private DemoQa _sut;

        [SetUp]
        public void Setup()
        {
            this.Initialize();
            this._sut = new DemoQa(this.Driver);
        }

        [TestCase("Resizable")]
        [TestCase("Droppable")]
        [TestCase("Dragabble")]
        [TestCase("Selectable")]
        [TestCase("Sortable")]
        public void AllSectionsAreAvailable(string sectionName)
        {
            this._sut.AssertThatSectionExist(sectionName);
        }
    }
}